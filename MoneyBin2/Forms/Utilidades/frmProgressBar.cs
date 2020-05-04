using System;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmProgressBar : Form {

        public frmProgressBar() {
            InitializeComponent();
            if (!this.IsHandleCreated) {
                this.CreateHandle();
            }
        }

        protected sealed override void CreateHandle() {
            base.CreateHandle();
        }

        public int Maximum {
            get => progressBar.Maximum;
            set => progressBar.Maximum = value;
        }

        public void UpdateProgress() {
            UpdateProgressBar();
        }

        public void UpdateProgress(int progress) {
            UpdateProgressBar(progress);
        }

        public void UpdateProgress(int progress, string label) {
            UpdateProgressBar(progress);
            UpdateLabelMessage(label);
        }

        public void UpdateProgress(string label) {
            UpdateProgressBar();
            UpdateLabelMessage(label);
        }

        private void UpdateProgressBar() {
            progressBar.BeginInvoke(
            new Action(() => { progressBar.Increment(1); }));
            labelProgresso.BeginInvoke(new Action(() => { labelProgresso.Text = $@"{progressBar.Value} of {progressBar.Maximum}"; }));
        }

        private void UpdateProgressBar(int progress) {
            progressBar.BeginInvoke(
            new Action(() => { progressBar.Value = progress; }));
        }

        private void UpdateLabelMessage(string label) {
            labelMessage.BeginInvoke(new Action(() => { this.Text = labelMessage.Text = label; }));
        }
    }
}
