using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HimeRun {
    class ControlList {
        public List<Control> AllControls = new List<Control>();
        private void GetAllControls(Control parent) {
            if (AllControls.IndexOf(parent) == -1) {
                AllControls.Add(parent);
            }
            foreach (Control item in parent.Controls) {
                AllControls.Add(item);
                if (item.HasChildren) {
                    GetAllControls(item);
                }
            }
        }
        public ControlList(Control parent) {
            GetAllControls(parent);
        }

        public static void LoadLangFile(Form form, string fileName) {
            string filePath = Environment.CurrentDirectory + @"\language\" + fileName + ".lang";
            if (!System.IO.File.Exists(filePath)) {
                return;
            }
            string rawLangFile = System.IO.File.ReadAllText(filePath);
            string[] fileArray = rawLangFile.Split('\n');
            if (fileArray.Length == 0) {
                return;
            }
            List<string[]> fileMatrix = new List<string[]>();
            foreach (string fileString in fileArray) {
                string[] fileGroup = fileString.Split('=');
                fileMatrix.Add(fileGroup);
            }
            ControlList formControlList = new ControlList(form);
            foreach (Control item in formControlList.AllControls) {
                string translatedText = "";
                foreach (string[] textGroup in fileMatrix) {
                    if (textGroup[0] == item.Text) {
                        translatedText = textGroup[1];
                    }
                }
                if (translatedText != "") {
                    item.Text = translatedText;
                }
            }
        }
    }
}
