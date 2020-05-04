using System;
using System.Windows.Forms;

namespace MoneyBin2
{
    public class ToolStripDateTimePicker : ToolStripControlHost {
        // https://docs.microsoft.com/pt-br/dotnet/framework/winforms/controls/how-to-wrap-a-windows-forms-control-with-toolstripcontrolhost
        public ToolStripDateTimePicker() : base(new DateTimePicker()) { }

        public ToolStripDateTimePicker(string name) : base(new DateTimePicker(), name) {
            Name = name;
        }

        public ToolStripDateTimePicker(string name, DateTime value) : base(new DateTimePicker(), name) {
            Name = name;
            Value = value;
        }

        public ToolStripDateTimePicker(string name, DateTime value, DateTimePickerFormat format) : base(new DateTimePicker(), name) {
            Name = name;
            Value = value;
            Format = format;
        }

        public ToolStripDateTimePicker(string name, DateTimePickerFormat format) : base(new DateTimePicker(), name) {
            Name = name;
            Format = format;
        }

        public ToolStripDateTimePicker(DateTimePickerFormat format) : base(new DateTimePicker()) {
            Format = format;
        }

        public DateTimePicker DateTimePickerControl => Control as DateTimePicker;

        public DateTime Value {
            get => ((DateTimePicker)Control).Value;
            set => ((DateTimePicker)Control).Value = value;
        }

        public DateTime MinDate {
            get => ((DateTimePicker)Control).MinDate;
            set => ((DateTimePicker)Control).MinDate = value;
        }

        public DateTime MaxDate {
            get => ((DateTimePicker)Control).MaxDate;
            set => ((DateTimePicker)Control).MaxDate = value;
        }

        public DateTimePickerFormat Format {
            get => ((DateTimePicker)Control).Format;
            set => ((DateTimePicker)Control).Format = value;
        }

        // Subscribe and unsubscribe the control events you wish to expose.
        protected override void OnSubscribeControlEvents(Control c) {
            // Call the base so the base events are connected.
            base.OnSubscribeControlEvents(c);

            // Cast the control to a MonthCalendar control.
            var dateTimePickerControl = (DateTimePicker)c;

            // Add the event.
            dateTimePickerControl.ValueChanged += new EventHandler(OnValueChanged);
        }

        protected override void OnUnsubscribeControlEvents(Control c) {
            // Call the base method so the basic events are unsubscribed.
            base.OnUnsubscribeControlEvents(c);

            // Cast the control to a MonthCalendar control.
            var dtpControl = (DateTimePicker)c;

            // Remove the event.
            dtpControl.ValueChanged -= new EventHandler(OnValueChanged);
        }

        // Declare the DateChanged event.
        public event EventHandler ValueChanged;

        // Raise the DateChanged event.
        private void OnValueChanged(object sender, EventArgs e) {
            ValueChanged?.Invoke(this, e);
        }
    }
}