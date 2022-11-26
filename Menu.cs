using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSGO;

namespace xp
{
    public partial class Menu : Form
    {
        public const string WINDOW_NAME = "Counter-Strike: Global Offensive - Direct3D 9";

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public static IntPtr handle = FindWindow(null, WINDOW_NAME);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]

        public static extern bool GetWindowRect(IntPtr hwnd, out RECT IpRect);

        public static RECT rect;

        public struct RECT
        {
            public int left, top, right, bottom;
        }

        csgo cs = new csgo();
        int iFov, Fov;
        
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Thread main = new Thread(Main) { IsBackground = true };
            main.Start();

            CheckForIllegalCrossThreadCalls = false;

            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;


            


            GetWindowRect(handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);



            this.Left = rect.left;
            this.Top = rect.top;


        }

       

        void Main()
        {
            cs.GetInformation();

            while (true)
            {
                
                if (cbTriggerbot.Checked)
                {
                    if(GetAsyncKeyState(Keys.ShiftKey) < 0)
                    {
                        cs.Triggerbot();
                    }
                    
                }

                if (GetAsyncKeyState(Keys.F12) < 0)
                {
                    this.Show();
                }

                if (GetAsyncKeyState(Keys.F11) < 0)
                {
                    this.Hide();
                }

                if(cbFov.Checked)
                {
                    Fov = SliderFov.Value;
                    cs.FovChanger(Fov);
                }

                if(cbIfov.Checked)
                {
                    iFov = SlideriFov.Value;
                    cs.iFovChanger(iFov);
                }

                if (cbThirdPerson.Checked)
                {
                    cs.EnableThirdPerson();
                }
                else
                {
                    cs.DisableThirdPerson();
                }

                if (cbBhop.Checked)
                {
                    if(GetAsyncKeyState(Keys.Space) < 0)
                    {
                        cs.Bhop();
                    }
                   
                }

                if (cbAntiFlash.Checked)
                {
                    cs.AntiFlash();
                }
            }
            
        }
    }
}
