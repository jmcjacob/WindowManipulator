using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WindowManipulator
{
    public partial class mainWindow : Form
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommands nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool DestroyWindow(IntPtr hwnd);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public Process[] processlist = null;

        public mainWindow()
        {
            InitializeComponent();

            windowList.Items.Clear();
            processlist = Process.GetProcesses();
            int id = 0;
            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    windowList.Items.Add(id.ToString() + "-" + process.ProcessName.ToString() + "-" + process.MainWindowTitle.ToString());
                }
                id++;
            }
        }

        private void maximizeButton(object sender, EventArgs e)
        {
            try
            {
                if (windowList.Text != "")
                {
                    int position = int.Parse(windowList.Text.Split('-')[0]);
                    IntPtr hwnd = FindWindowByCaption(IntPtr.Zero, processlist[position].MainWindowTitle.ToString());
                    ShowWindow(hwnd, ShowWindowCommands.Restore);
                    ShowWindow(hwnd, ShowWindowCommands.Maximize);
                }
            }
            catch(Exception exception)
            {
                Debug.Write(exception);
            }
        }

        private void closeButton(object sender, EventArgs e)
        {
            if (windowList.Text != "")
            {
                int position = int.Parse(windowList.Text.Split('-')[0]);
                Process[] proc = Process.GetProcessesByName(processlist[position].ProcessName.ToString());
                proc[0].Kill();
                windowList.Items.Remove(windowList.Text);
            }
        }

        private void minimizeButton(object sender, EventArgs e)
        {
            if (windowList.Text != "")
            {
                int position = int.Parse(windowList.Text.Split('-')[0]);
                IntPtr hwnd = FindWindowByCaption(IntPtr.Zero, processlist[position].MainWindowTitle.ToString());
                ShowWindow(hwnd, ShowWindowCommands.Restore);
                ShowWindow(hwnd, ShowWindowCommands.Minimize);
            }
        }

        private void updateButton(object sender, EventArgs e)
        {
            windowList.Items.Clear();
            processlist = Process.GetProcesses();
            int id = 0;
            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    windowList.Items.Add(id.ToString() + "-" + process.ProcessName + "-" + process.MainWindowTitle.ToString());
                }
                id++;
            }
        }

        private void resizeButton(object sender, EventArgs e)
        {
            if (windowList.Text != "")
            {
                int position = int.Parse(windowList.Text.Split('-')[0]);
                IntPtr hwnd = FindWindowByCaption(IntPtr.Zero, processlist[position].MainWindowTitle.ToString());
                RECT rct;
                if (!GetWindowRect(new HandleRef(this, hwnd), out rct))
                {
                    MessageBox.Show("ERROR");
                    return;
                }
                int X = rct.Left;
                int Y = rct.Top;
                int Width = rct.Right - rct.Left + 1;
                int Height = rct.Bottom - rct.Top + 1;

                if (IsDigitsOnly(width.Text) && int.Parse(width.Text) >= 100 && IsDigitsOnly(height.Text) && int.Parse(height.Text) >= 100)
                {
                    ShowWindow(hwnd, ShowWindowCommands.Restore);
                    MoveWindow(hwnd, X, Y, int.Parse(width.Text), int.Parse(height.Text), true);
                }
                else if (IsDigitsOnly(width.Text) && int.Parse(width.Text) >= 100 && !IsDigitsOnly(height.Text))
                {
                    ShowWindow(hwnd, ShowWindowCommands.Restore);
                    MoveWindow(hwnd, X, Y, int.Parse(width.Text), Height, true);
                }
                else if (!IsDigitsOnly(width.Text) && IsDigitsOnly(height.Text) && int.Parse(height.Text) >= 100)
                {
                    ShowWindow(hwnd, ShowWindowCommands.Restore);
                    MoveWindow(hwnd, X, Y, Width, int.Parse(height.Text), true);
                }
                else
                {
                    MessageBox.Show("Please enter vaild values for Width and Height.");
                }
            }
            else
            {
                MessageBox.Show("Please select a application.");
            }
        }

        private void positionButton(object sender, EventArgs e)
        {
            if (windowList.Text != "")
            {
                int position = int.Parse(windowList.Text.Split('-')[0]);
                IntPtr hwnd = FindWindowByCaption(IntPtr.Zero, processlist[position].MainWindowTitle.ToString());
                RECT rct;
                if (!GetWindowRect(new HandleRef(this, hwnd), out rct))
                {
                    MessageBox.Show("ERROR");
                    return;
                }
                int X = rct.Left;
                int Y = rct.Top;
                int Width = rct.Right - rct.Left + 1;
                int Height = rct.Bottom - rct.Top + 1;

                if (IsDigitsOnly(x.Text) && int.Parse(x.Text) >= 0 && IsDigitsOnly(y.Text) && int.Parse(y.Text) >= 0)
                {
                    ShowWindow(hwnd, ShowWindowCommands.Restore);
                    MoveWindow(hwnd, int.Parse(x.Text), int.Parse(y.Text), Width, Height, true);
                }
                else if (IsDigitsOnly(x.Text) && int.Parse(x.Text) >= 0 && !IsDigitsOnly(y.Text))
                {
                    ShowWindow(hwnd, ShowWindowCommands.Restore);
                    MoveWindow(hwnd, int.Parse(x.Text), Y, Width, Height, true);
                }
                else if (!IsDigitsOnly(x.Text) && IsDigitsOnly(y.Text) && int.Parse(y.Text) >= 0)
                {
                    ShowWindow(hwnd, ShowWindowCommands.Restore);
                    MoveWindow(hwnd, X, int.Parse(y.Text), Width, Height, true);
                }
                else
                {
                    MessageBox.Show("Please enter valid values for X and Y.");
                }
            }
            else
            {
                MessageBox.Show("Please select a application.");
            }
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
