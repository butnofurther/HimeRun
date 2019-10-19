using HimeUtil;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.IO;
using System.Security.Principal;

namespace HimeRun {
    public partial class MainForm : Form {

        private readonly OptionForm OPTION_FORM;
        private SQLiteHelper DBLinker = new SQLiteHelper(Environment.CurrentDirectory, "core.db");
        private string fileType = "";
        private string FileType {
            get {
                return fileType;
            }
            set {
                fileType = value;
                if (fileType == "") {
                    LFileType.Text = "[ALL TYPES]";
                } else {
                    LFileType.Text = "[" + fileType.ToUpper() + "]";
                }
            }
        }
        private int SearchAfterHowManyCharInputed = 3;
        private bool ENABLE_WEB_SEARCH = true;
        private string SEARCH_ENGINE = "Baidu";

        public MainForm() {
            if (!IsAdmin()) {
                MessageBox.Show(
                    "This app requires Administrator Authorize to run.",
                    "Require Authorize",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Environment.Exit(0);
            }
            OPTION_FORM = new OptionForm() {
                Owner = this
            };
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            TopMost = true;
            ShowInTaskbar = false;
            this.SetShadow();
            SetShowPosition();
            SetSearchAfterHowManyCharInputed();
            GetEnableWebSearch();
            SetStartUp();
        }

        // check if current user has administrator authorize.
        private bool IsAdmin() {
            WindowsIdentity current = WindowsIdentity.GetCurrent();
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        /// <summary>
        /// start up setting, to regedit
        /// </summary>
        private void SetStartUp() {
            string result = DBLinker.GetOneLine(@"select keyValue from config where keyName = 'AutoStartUp' limit 1;");
            // win7-10 auto start setting
            // C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp // is xp system
            const string key = "SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run";
            if (result == "1") {
                string strAssName = Application.StartupPath + @"\" + Application.ProductName + @".exe";
                string ShortFileName = Application.ProductName; RegistryKey rgkRun = Registry.LocalMachine.OpenSubKey(key, true);
                if (rgkRun == null) {
                    rgkRun = Registry.LocalMachine.CreateSubKey(key);
                }
                rgkRun.SetValue(ShortFileName, strAssName);
            } else {
                string ShortFileName = Application.ProductName; RegistryKey rgkRun = Registry.LocalMachine.OpenSubKey(key, true);
                if (rgkRun == null) {
                    rgkRun = Registry.LocalMachine.CreateSubKey(key);
                }
                rgkRun.DeleteValue(ShortFileName, false);
            }
        }

        // create shortcut
        private void CreateShortcut(string directory, string shortcutName, string originalFileFullName) {
            try {
                if (!Directory.Exists(directory)) {
                    Directory.CreateDirectory(directory);
                }
            } catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "System Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            string shortcutFullName = Path.Combine(directory, shortcutName + ".lnk");
            WshShell ws = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)ws.CreateShortcut(shortcutFullName);
            shortcut.TargetPath = originalFileFullName;
            shortcut.WorkingDirectory = Environment.CurrentDirectory;
            shortcut.IconLocation = originalFileFullName;
            shortcut.Save();
        }

        private void SetSearchAfterHowManyCharInputed() {
            string result = DBLinker.GetOneLine(@"select keyValue from config where keyName = 'SearchAfterHowManyCharInputed' limit 1;");
            SearchAfterHowManyCharInputed = int.Parse(result);
        }

        private void SetShowPosition() {
            string position = DBLinker.GetOneLine(@"select keyValue from config where keyName = 'ShowPosition' limit 1;");
            switch (position) {
                case "Left-Top":
                    Left = 0;
                    Top = 0;
                    break;
                case "Right-Top":
                    Left = SystemInformation.WorkingArea.Width - Width;
                    Top = 0;
                    break;
                case "Left-Bottom":
                    Left = 0;
                    Top = SystemInformation.WorkingArea.Height - Height;
                    break;
                case "Right-Bottom":
                    Left = SystemInformation.WorkingArea.Width - Width;
                    Top = SystemInformation.WorkingArea.Height - Height;
                    break;
                case "Screen-Center":
                    Left = (SystemInformation.WorkingArea.Width - Width) / 2;
                    Top = (SystemInformation.WorkingArea.Height - Height) / 2;
                    break;
            }
        }

        private void GetEnableWebSearch() { 
            string result = DBLinker.GetOneLine(@"select keyValue from config where keyName = 'EnableWebSearch' limit 1;");
            ENABLE_WEB_SEARCH = result == "1";
            if (ENABLE_WEB_SEARCH) { 
                SEARCH_ENGINE = DBLinker.GetOneLine(@"select keyValue from config where keyName = 'WebSearchEngine' limit 1;");
            }
        }

        /// <summary>
        /// regist the hotkey
        /// </summary>
        private const int WM_HOTKEY = 0x312; 
        private const int WM_CREATE = 0x1; 
        private const int WM_DESTROY = 0x2; 
        private const int KEY_ID = 0x3572; 
        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);
            switch (m.Msg) {
                case WM_HOTKEY: 
                    switch (m.WParam.ToInt32()) {
                        case KEY_ID:
                            if (Visible) {
                                Hide();
                            } else {
                                Show();
                            }
                            break;
                    }
                    break;
                case WM_CREATE:
                    try {
                        string hotKeys = DBLinker.GetOneLine(@"
                            select keyValue from config where keyName = 'HotKeys' limit 1;
                        ");
                        if (hotKeys == null) {
                            return;
                        }
                        string[] hotKeyTextArray = hotKeys.Split(';');
                        AppHotKey.KeyModifiers keyModifiers = AppHotKey.KeyModifiers.None;
                        switch (hotKeyTextArray[0]) {
                            case "Win":
                                keyModifiers = AppHotKey.KeyModifiers.WindowsKey;
                                break;
                            case "Alt":
                                keyModifiers = AppHotKey.KeyModifiers.Alt;
                                break;
                            case "Ctrl":
                                keyModifiers = AppHotKey.KeyModifiers.Ctrl;
                                break;
                            case "Shift":
                                keyModifiers = AppHotKey.KeyModifiers.Shift;
                                break;
                            default:
                                keyModifiers = AppHotKey.KeyModifiers.None;
                                break;
                        }
                        AppHotKey.RegKey(Handle, KEY_ID, keyModifiers, AppHotKey.KeyMap(hotKeyTextArray[1]));
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case WM_DESTROY: 
                    AppHotKey.UnRegKey(Handle, KEY_ID);
                    break;
            }
        }

        /// <summary>
        /// exit whole program
        /// </summary>
        /// <param name="sender">not used</param>
        /// <param name="e">not used</param>
        private void Exit(object sender, EventArgs e) {
            DialogResult con = MessageBox.Show(
                "Are you sure to exit this program completely?",
                "Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );
            if (con == DialogResult.OK) {
                Environment.Exit(0);
            }
        }
        /// <summary>
        /// showing the option subwin
        /// </summary>
        /// <param name="sender">not used</param>
        /// <param name="e">not used</param>
        private void OptionFormShow(object sender, EventArgs e) {
            OPTION_FORM.ShowDialog();
        }

        /// <summary>
        /// Search from db of path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        List<string[]> InputResult = new List<string[]>();
        private void RunInput(object sender, EventArgs e) {
            TMain.Text = TMain.Text.Replace(" ", "");
            TMain.Select(TMain.Text.Length, 0);
            if (TMain.Text.Length < SearchAfterHowManyCharInputed) {
                LFileName.Text = "";
                LPath.Text = "";
                LArguments.Text = "";
                InputResult = new List<string[]>();
                return;
            }
            try {
                string sql = $@"
                    select * from (
                        select 
                            '[CMD]' || c.name as c0,
                            c.code as c1,
                            c.discrib as c2
                        from customizeCommand c
                        where c.name like '%{ TMain.Text }%'
                        union all
                        select
                            f.fileMainName as c0,
                            f.path as c1,
                            (select a.args from arguments a where a.fileMainName = f.fileMainName and a.path = f.path) as c2
                        from files f
                        where (
                                f.fileMainName like '%{ TMain.Text }%'
                                or f.fileDiscrib like '%{ TMain.Text }%'
                                or f.pinyin like '%{ TMain.Text }%'
                            )
                            and f.fileExtension like '%{ FileType }%'
                    ) g
                    order by (select count(l.runTime) from runLog l where l.fileMainName = g.c0 and l.path = g.c1 ) desc;
                ";
                InputResult = DBLinker.ExecuteToList(sql);
                if (InputResult.Count == 0) {
                    LFileName.Text = "NO FILE";
                    LPath.Text = ENABLE_WEB_SEARCH ? "Ctrl + Enter Search on Web." : "Try to reload the dictionary.";
                    LArguments.Text = "";
                    return;
                }
                LFileName.Text = InputResult[0][0];
                LPath.Text = InputResult[0][1];
                LArguments.Text = InputResult[0][2] == "" ? "(No Args)" : "(" + InputResult[0][2] + ")";
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        // Next result
        private void NextInputResult() {
            int index = -1;
            for(int i = 0; i < InputResult.Count; i++) {
                string[] item = InputResult[i];
                if (item[0] == LFileName.Text && item[1] == LPath.Text) {
                    index = i;
                }
            }
            int newIndex = index + 1;
            if (newIndex >= InputResult.Count) {
                LFileName.Text = InputResult[0][0];
                LPath.Text = InputResult[0][1];
                LArguments.Text = InputResult[0][2] == "" ? "(No Args)" : "(" + InputResult[0][2] + ")";
            } else {
                LFileName.Text = InputResult[newIndex][0];
                LPath.Text = InputResult[newIndex][1];
                LArguments.Text = InputResult[newIndex][2] == "" ? "(No Args)" : "(" + InputResult[newIndex][2] + ")";
            }
        }
        // before
        private void PreviewInputResult() {
            int index = -1;
            for (int i = 0; i < InputResult.Count; i++) {
                string[] item = InputResult[i];
                if (item[0] == LFileName.Text && item[1] == LPath.Text) {
                    index = i;
                }
            }
            int newIndex = index - 1;
            if (newIndex < 0) {
                LFileName.Text = InputResult[InputResult.Count - 1][0];
                LPath.Text = InputResult[InputResult.Count - 1][1];
                LArguments.Text = InputResult[InputResult.Count - 1][2] == "" ? "(No Args)" : "(" + InputResult[InputResult.Count - 1][2] + ")";
            } else {
                LFileName.Text = InputResult[newIndex][0];
                LPath.Text = InputResult[newIndex][1];
                LArguments.Text = InputResult[newIndex][2] == "" ? "(No Args)" : InputResult[newIndex][2];
            }
        }

        private void FileTypeChange(object sender, EventArgs e) {
            TMain.Text = "";
            RunInput(sender, e);
            List<string> allTypes = new List<string>();
            allTypes.Add("");
            List<string[]> extensionResult = DBLinker.ExecuteToList($@"
                select distinct(fileExtension)
                from files;
            ");
            foreach (string[] er in extensionResult) {
                string[] extensionArray = er[0].Split(';');
                foreach (string ea in extensionArray) {
                    if (!allTypes.Contains(ea)) {
                        allTypes.Add(ea);
                    }
                }
            }
            int currentIndex = allTypes.IndexOf(FileType);
            if (currentIndex == allTypes.Count - 1) {
                FileType = allTypes[0];
            } else {
                FileType = allTypes[currentIndex + 1];
            }
        }

        /// <summary>
        /// hide off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hide(object sender, EventArgs e) {
            TMain.Text = "";
            InputResult = new List<string[]>();
            Hide();
        }

        private void Run(object sender, EventArgs e) {
            if (LFileName.Text == "NO FILE" || LFileName.Text == "") {
                return;
            }
            try {
                string args = "";
                if (LArguments.Text != "(No Args)") {
                    args = LArguments.Text;
                }
                // write db count
                DBLinker.Execute($@"
                    insert into runLog values(
                        datetime('now'),
                        '{ LFileName.Text }',
                        '{ LPath.Text }',
                        '{ args }'
                    );
                ");
                Process p = new Process();
                if (args != "") {
                    p.StartInfo.Arguments = args;
                }
                if (LFileName.Text.IndexOf("[CMD]") == -1) {
                    p.StartInfo.FileName = LPath.Text + @"\" + LFileName.Text;
                    p.StartInfo.WorkingDirectory = LPath.Text;
                    p.Start();
                } else {
                    p.StartInfo.FileName = "cmd.exe";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardInput = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();
                    p.StandardInput.WriteLine(LPath.Text);
                }
                Hide();
                OPTION_FORM.GetRunLog();
            } catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Program Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        ///  watching the main input for running
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TMainKeyWatch(object sender, KeyEventArgs e) {
            if (e.Modifiers == Keys.Control) {
                switch (e.KeyCode) {
                    case Keys.Enter:
                        SearchWeb();
                        break;
                }
                return;
            }
            switch (e.KeyCode) {
                case Keys.Enter:
                    Run(sender, null);
                    break;
                case Keys.Escape:
                    Hide();
                    break;
                case Keys.Down:
                    NextInputResult();
                    break;
                case Keys.Up:
                    PreviewInputResult();
                    break;
                case Keys.Tab:
                    PreviewRunLog();
                    break;
            }
        }

        private void PreviewRunLog() {
            List<string[]> runLogList = DBLinker.ExecuteToList($@"
                select distinct fileMainName from main.runLog
                order by runTime desc
                limit 100;
            ");
            if (TMain.Text == "") {
                TMain.Text = runLogList[0][0].Split('.')[0];
                RunInput(null, null);
                return;
            }
            for (int i = 0; i < runLogList.Count; i++) {
                if (runLogList[i][0].Split('.')[0] == TMain.Text) {
                    if (i == runLogList.Count - 1) {
                        TMain.Text = runLogList[0][0].Split('.')[0];
                        RunInput(null, null);
                        return;
                    }
                    TMain.Text = runLogList[i + 1][0].Split('.')[0];
                    RunInput(null, null);
                    return;
                }
            }
        }

        /// <summary>
        /// search keyword from web search engine
        /// </summary>
        private void SearchWeb() {
            if (TMain.Text == "") {
                return;
            }
            string url = "";
            switch (SEARCH_ENGINE) {
                default:
                    url = $"https://www.baidu.com/s?ie=utf-8&f=8&rsv_bp=1&rsv_idx=1&tn=baidu&wd={ TMain.Text }&rsv_pq=e01ade020011cd78&rsv_t=712erko%2F2ODvOJfrwrQev5jIbBkZJ1E7RrBb4Yynb6Nd%2BMC%2F8yTPaNWZ1Dw&rqlang=cn&rsv_enter=1&rsv_dl=tb&rsv_sug3=9&rsv_sug1=4&rsv_sug7=101&rsv_sug2=0&inputT=1332&rsv_sug4=2385";
                    break;
            }
            Process.Start(url);
            Hide();
        }
    }
}
