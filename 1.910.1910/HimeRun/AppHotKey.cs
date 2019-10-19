using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HimeRun {
    public class AppHotKey {
        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();
        //如果函数执行成功，返回值不为0。
        //如果函数执行失败，返回值为0。要得到扩展错误信息，调用GetLastError。
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(
            IntPtr hWnd,                //要定义热键的窗口的句柄
            int id,                     //定义热键ID（不能与其它ID重复）          
            KeyModifiers fsModifiers,   //标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效
            Keys vk                     //定义热键的内容
            );

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(
            IntPtr hWnd,                //要取消热键的窗口的句柄
            int id                      //要取消热键的ID
            );

        //定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）
        [Flags()]
        public enum KeyModifiers {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8
        }
        /// <summary>
        /// 注册热键
        /// </summary>
        /// <param name="hwnd">窗口句柄</param>
        /// <param name="hotKey_id">热键ID</param>
        /// <param name="keyModifiers">组合键</param>
        /// <param name="key">热键</param>
        public static void RegKey(IntPtr hwnd, int hotKey_id, KeyModifiers keyModifiers, Keys key) {
            try {
                if (!RegisterHotKey(hwnd, hotKey_id, keyModifiers, key)) {
                    if (Marshal.GetLastWin32Error() == 1409) { MessageBox.Show("热键被占用 ！"); } else {
                        MessageBox.Show("注册热键失败！");
                    }
                }
            } catch (Exception) { }
        }
        /// <summary>
        /// 注销热键
        /// </summary>
        /// <param name="hwnd">窗口句柄</param>
        /// <param name="hotKey_id">热键ID</param>
        public static void UnRegKey(IntPtr hwnd, int hotKey_id) {
            //注销Id号为hotKey_id的热键设定
            UnregisterHotKey(hwnd, hotKey_id);
        }

        public static Keys KeyMap(string keyText) {
            switch (keyText) {
                default: return Keys.Enter;
                case "F1": return Keys.F1;
                case "F2": return Keys.F2;
                case "F3": return Keys.F3;
                case "F4": return Keys.F4;
                case "F5": return Keys.F5;
                case "F6": return Keys.F6;
                case "F7": return Keys.F7;
                case "F8": return Keys.F8;
                case "F9": return Keys.F9;
                case "F10": return Keys.F10;
                case "F11": return Keys.F11;
                case "F12": return Keys.F12;
                case "0": return Keys.D0;
                case "1": return Keys.D1;
                case "2": return Keys.D2;
                case "3": return Keys.D3;
                case "4": return Keys.D4;
                case "5": return Keys.D5;
                case "6": return Keys.D6;
                case "7": return Keys.D7;
                case "8": return Keys.D8;
                case "9": return Keys.D9;
                case "A": return Keys.A;
                case "B": return Keys.B;
                case "C": return Keys.C;
                case "D": return Keys.D;
                case "E": return Keys.E;
                case "F": return Keys.F;
                case "G": return Keys.G;
                case "H": return Keys.H;
                case "I": return Keys.I;
                case "J": return Keys.J;
                case "K": return Keys.K;
                case "L": return Keys.L;
                case "M": return Keys.M;
                case "N": return Keys.N;
                case "O": return Keys.O;
                case "P": return Keys.P;
                case "Q": return Keys.Q;
                case "R": return Keys.R;
                case "S": return Keys.S;
                case "T": return Keys.T;
                case "U": return Keys.U;
                case "V": return Keys.V;
                case "W": return Keys.W;
                case "X": return Keys.X;
                case "Y": return Keys.Y;
                case "Z": return Keys.Z;
            }
        }

    }
}
