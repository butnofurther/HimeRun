using System;
using System.Threading;
using System.Windows.Forms;

namespace HimeRun {
    static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool single;
            new Mutex(true, Application.ProductName, out single);
            if (!single) {
                MessageBox.Show(
                    "This application can only run at once.",
                    "Multi Instance",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                Environment.Exit(0);
            }
            Application.Run(new MainForm());
        }
    }
}
