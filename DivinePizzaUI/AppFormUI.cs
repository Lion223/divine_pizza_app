using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DivinePizzaUI
{
    public partial class AppFormUI : Form
    {
        string phoneNumber;
        public static int order;
        public static int price = 0;
        public string SomeValue
        {
            get { return countLbl.Text; }
            set { countLbl.Text = value; }
        }

        public static Dictionary<string, int> orders { get; set; }

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

        public AppFormUI()
        {
            InitializeComponent();
            phoneNumber = loginForm.phoneNumber;
            orders = new Dictionary<string, int>();
        }

        private void pizzasBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (pizzasBtn.Checked)
            {
                pizzasBtn.BackgroundImage = DivinePizzaUI.Properties.Resources.pizzas_icon;
                pizzas.Visible = true;
                drinks.Visible = false;
                salads.Visible = false;
            }
            else
                pizzasBtn.BackgroundImage = DivinePizzaUI.Properties.Resources.pizzas_whiteicon;
        }

        private void pizzasBtn_MouseMove(object sender, MouseEventArgs e)
        {
            if (!pizzasBtn.Checked)
                pizzasBtn.BackgroundImage = DivinePizzaUI.Properties.Resources.pizzas_icon;
        }

        private void pizzasBtn_MouseLeave(object sender, EventArgs e)
        {
            if (!pizzasBtn.Checked)
                pizzasBtn.BackgroundImage = DivinePizzaUI.Properties.Resources.pizzas_whiteicon;
        }

        private void drinksBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (drinksBtn.Checked)
            {
                drinksBtn.BackgroundImage = DivinePizzaUI.Properties.Resources.drinks_icon;
                pizzas.Visible = false;
                drinks.Visible = true;
                salads.Visible = false;
            }
            else
                drinksBtn.BackgroundImage = DivinePizzaUI.Properties.Resources.drinks_whiteicon;
        }

        private void drinksBtn_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drinksBtn.Checked)
                drinksBtn.BackgroundImage = DivinePizzaUI.Properties.Resources.drinks_icon;
        }

        private void drinksBtn_MouseLeave(object sender, EventArgs e)
        {
            if (!drinksBtn.Checked)
                drinksBtn.BackgroundImage = DivinePizzaUI.Properties.Resources.drinks_whiteicon;
        }

        private void saladsBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (saladsBtn.Checked)
            {
                saladsBtn.BackgroundImage = DivinePizzaUI.Properties.Resources.salads_icon;
                pizzas.Visible = false;
                drinks.Visible = false;
                salads.Visible = true;
            }
            else
                saladsBtn.BackgroundImage = DivinePizzaUI.Properties.Resources.salads_whiteicon;
        }

        private void saladsBtn_MouseMove(object sender, MouseEventArgs e)
        {
            if (!saladsBtn.Checked)
                saladsBtn.BackgroundImage = DivinePizzaUI.Properties.Resources.salads_icon;
        }

        private void saladsBtn_MouseLeave(object sender, EventArgs e)
        {
            if (!saladsBtn.Checked)
                saladsBtn.BackgroundImage = DivinePizzaUI.Properties.Resources.salads_whiteicon;
        }

        private void mailBtn_Click(object sender, EventArgs e)
        {
            var mail = new MailFormUI();
            mail.Show();
        }

        private void Box_Click(object sender, EventArgs e)
        {
            var box = new OrderFormUI();
            box.Owner = this;
            box.Show();
        }

        private void changeUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new loginForm();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
