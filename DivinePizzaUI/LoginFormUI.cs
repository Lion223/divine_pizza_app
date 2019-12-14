using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace DivinePizzaUI
{
    public partial class loginForm : Form
    {
        int code;
        public static string phoneNumber;

        // Add drop shadow to a form and make it movable
        #region SM
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }
        #endregion

        private bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public loginForm()
        {
            InitializeComponent();
            if (!CheckForInternetConnection())
            {
                MessageBox.Show("Internet connection is not available at the moment");
                Environment.Exit(0);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void sendPhoneBtn_Click(object sender, EventArgs e)
        {
            // Length count check
            if (phoneTb.Text.Count() == 13)
            {
                // 4-digit code generation
                Random rnd = new Random();
                code = rnd.Next(1000, 10000);
                codeLbl.Text = code.ToString();
                statusLbl.ForeColor = Color.White;
                statusLbl.Text = "Code has been sent";
                phoneNumber = phoneTb.Text;
                if (!codeLbl.Visible)
                {
                    // API Twilio for SMS

                    /*
                    var accountSid = "#";
                    var authToken = "#";
                    TwilioClient.Init(accountSid, authToken);
                    var messageOptions = new CreateMessageOptions(
                        new PhoneNumber(phoneNumber));
                    messageOptions.From = new PhoneNumber("#");
                    messageOptions.Body = "Divine Pizza confirmation code: " + codeLbl.Text;
                    var message = MessageResource.Create(messageOptions);
                    */
                }
            }
            else
            {
                statusLbl.ForeColor = Color.FromArgb(255, 227, 18, 18);
                statusLbl.Text = "Invalid phone number";
            }
        }

        private void sendCodeBtn_Click(object sender, EventArgs e)
        {
            if (codeLbl.Text != "")
            {
                if (codeTb.Text != code.ToString())
                {
                    statusLbl.ForeColor = Color.FromArgb(255, 227, 18, 18);
                    statusLbl.Text = "Invalid code";
                }
                else
                {
                    codeLbl.Visible = false;
                    this.Hide();
                    var app = new AppFormUI();
                    app.Closed += (s, args) => this.Close();
                    app.Show();
                }
            }
        }

        private void phoneTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                if (!char.IsDigit(e.KeyChar) || phoneTb.Text.Count() > 12)
                    e.Handled = true;
            }
        }

        private void phoneTb_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && phoneTb.Text.Length == 4)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void checkcodeBtn_Click(object sender, EventArgs e)
        {
            codeLbl.Visible = true;
        }
    }
}
