using System.Windows.Forms;
using System;

namespace HimeRun {
    public partial class PromptForm : Form {

        public string ConfirmedMessage = "";

        public PromptForm(string title = "Prompt", string value = "", string submitButtonText = "OK") {
            InitializeComponent();
            Text = title;
            TValue.Text = value;
            BSubmit.Text = submitButtonText;
        }

        private void Submit(object sender, EventArgs e) {
            ConfirmedMessage = TValue.Text;
            Close();
        }
    }
}
