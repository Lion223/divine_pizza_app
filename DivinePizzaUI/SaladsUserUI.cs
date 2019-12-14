using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DivinePizzaUI
{
    public partial class SaladsUserUI : UserControl
    {
        public static Dictionary<string, int> salads = new Dictionary<string, int>();

        public SaladsUserUI()
        {
            InitializeComponent();
        }

        private void Notify()
        {
            notify.Visible = true;
            notify.Icon = SystemIcons.Information;
            notify.BalloonTipTitle = "Divine Pizza";
            notify.BalloonTipText = "Added to Box";
            notify.BalloonTipIcon = ToolTipIcon.Info;
            notify.ShowBalloonTip(1000);
        }
        private void AddToBox(string name, int price)
        {
            salads = new Dictionary<string, int>(AppFormUI.orders);
            if (salads.ContainsKey(name))
                salads[name]++;
            else
                salads.Add(name, 1);
            AppFormUI.orders = new Dictionary<string, int>(salads);
            AppFormUI app = (AppFormUI)this.Parent;
            int count = Int16.Parse(app.countLbl.Text);
            int boxprice = Int16.Parse(app.priceLbl.Text.Substring(0, app.priceLbl.Text.Length - 2));
            count++;
            boxprice += price;
            AppFormUI.price = boxprice;
            app.countLbl.Text = count.ToString();
            app.priceLbl.Text = boxprice.ToString() + " $";
        }

        private void saladBuyBtn1_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Sucrine Salad", 25);
        }

        private void saladBuyBtn2_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Burrata Salad", 35);
        }
        private void saladBuyBtn3_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Fruitcinn Salad", 35);
        }
        private void saladBuyBtn4_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Summer Heap Salad", 35);
        }
        private void saladBuyBtn5_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Seaweed Salad", 35);
        }
        private void saladBuyBtn6_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Winter Beet Hummus", 35);
        }
    }
}
