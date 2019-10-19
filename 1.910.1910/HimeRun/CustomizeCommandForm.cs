using System;
using System.Windows.Forms;

namespace HimeRun {
    public partial class CustomizeCommandForm : Form {

        public string ConfirmedName = "";
        public string ConfirmedDiscrib = "";
        public string ConfirmedCode = "";

        public CustomizeCommandForm(string name = "My Command", string discrib = "", string code = "") {
            InitializeComponent();
            TName.Text = name;
            TDiscrib.Text = discrib;
            TCode.Text = code;
        }

        private void Clear(object sender, EventArgs e) {
            TCode.Text = "";
        }

        private void Close(object sender, EventArgs e) {
            Close();
        }

        private void Submit(object sender, EventArgs e) {
            if (TName.Text == "" || TCode.Text == "") {
                MessageBox.Show(
                    "Command name and Command code has to be not empty.",
                    "Customize Command",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            ConfirmedName = TName.Text;
            ConfirmedDiscrib = TDiscrib.Text;
            ConfirmedCode = TCode.Text.Replace('\n', ' ');
            Close();
        }

        private void NameInput(object sender, EventArgs e) {
            LName.Text = LName.Text.Replace(" ", "");
        }
    }
}
