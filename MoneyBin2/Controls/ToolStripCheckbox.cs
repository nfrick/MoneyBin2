using System;
using System.Windows.Forms;

namespace MoneyBin2
{
    public class ToolStripCheckbox : ToolStripControlHost {
        // https://docs.microsoft.com/pt-br/dotnet/framework/winforms/controls/how-to-wrap-a-windows-forms-control-with-toolstripcontrolhost
        public ToolStripCheckbox() : base(new CheckBox()) { }

        public ToolStripCheckbox(string name) : base(new CheckBox(), name) {
            Name = name;
        }

        public ToolStripCheckbox(string name, string text) : base(new CheckBox(), name) {
            Name = name;
            Text = text;
        }

        public ToolStripCheckbox(string name, string text, bool value) : base(new CheckBox(), name) {
            Name = name;
            Text = text;
            Checked = value;
        }

        public CheckBox checkBoxControl => Control as CheckBox;

        public bool Checked {
            get => ((CheckBox)Control).Checked;
            set => ((CheckBox)Control).Checked = value;
        }

        // Subscribe and unsubscribe the control events you wish to expose.
        protected override void OnSubscribeControlEvents(Control c) {
            // Call the base so the base events are connected.
            base.OnSubscribeControlEvents(c);

            // Cast the control to a MonthCalendar control.
            var checkBoxControl = (CheckBox)c;

            // Add the event.
            checkBoxControl.CheckedChanged += new EventHandler(OnCheckedChanged);
        }

        protected override void OnUnsubscribeControlEvents(Control c) {
            // Call the base method so the basic events are unsubscribed.
            base.OnUnsubscribeControlEvents(c);

            // Cast the control to a MonthCalendar control.
            var dtpControl = (CheckBox)c;

            // Remove the event.
            dtpControl.CheckedChanged -= new EventHandler(OnCheckedChanged);
        }

        // Declare the DateChanged event.
        public event EventHandler CheckedChanged;

        // Raise the DateChanged event.
        private void OnCheckedChanged(object sender, EventArgs e) {
            CheckedChanged?.Invoke(this, e);
        }
    }
}