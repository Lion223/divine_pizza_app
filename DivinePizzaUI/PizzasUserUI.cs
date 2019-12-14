using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DivinePizzaUI
{
    public partial class PizzasUserUI : UserControl
    {
        public static Dictionary<string, int> pizzas = new Dictionary<string, int>();

        public PizzasUserUI()
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
            pizzas = new Dictionary<string, int>(AppFormUI.orders);
            if (pizzas.ContainsKey(name))
                pizzas[name]++;
            else
                pizzas.Add(name, 1);
            AppFormUI.orders = new Dictionary<string, int>(pizzas);
            AppFormUI app = (AppFormUI)this.Parent;
            int count = Int16.Parse(app.countLbl.Text);
            int boxprice = Int16.Parse(app.priceLbl.Text.Substring(0, app.priceLbl.Text.Length - 2));
            count++;
            boxprice += price;
            AppFormUI.price = boxprice;
            app.countLbl.Text = count.ToString();
            app.priceLbl.Text = boxprice.ToString() + " $";
        }

        private void pizzaBuyBtn1_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Cheese Monster Pizza", 25);
        }
        private void pizzaBuyBtn2_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Sausage God Pizza", 35);
        }
        private void pizzaBuyBtn3_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Fetapizza", 15);
        }
        private void pizzaBuyBtn4_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Salmolicious", 30);
        }
        private void pizzaBuyBtn5_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Tropical Pizza", 35);
        }
        private void pizzaBuyBtn6_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Cheesy Peezy", 40);
        }
    }
}
