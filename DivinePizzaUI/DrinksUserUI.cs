using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DivinePizzaUI
{
    public partial class DrinksUserUI : UserControl
    {
        public static Dictionary<string, int> drinks = new Dictionary<string, int>();

        public DrinksUserUI()
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
            drinks = new Dictionary<string, int>(AppFormUI.orders);
            if (drinks.ContainsKey(name))
                drinks[name]++;
            else
                drinks.Add(name, 1);
            AppFormUI.orders = new Dictionary<string, int>(drinks);
            AppFormUI app = (AppFormUI)this.Parent;
            int count = Int16.Parse(app.countLbl.Text);
            int boxprice = Int16.Parse(app.priceLbl.Text.Substring(0, app.priceLbl.Text.Length - 2));
            count++;
            boxprice += price;
            AppFormUI.price = boxprice;
            app.countLbl.Text = count.ToString();
            app.priceLbl.Text = boxprice.ToString() + " $";
        }

        private void drinkBuyBtn1_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Coca-Cola", 5);
        }

        private void drinkBuyBtn2_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Beer \"Lager\"", 10);
        }

        private void drinkBuyBtn3_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Beer \"Black Label\"", 20);
        }

        private void drinkBuyBtn4_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Beer \"Mythos\"", 10);
        }

        private void drinkBuyBtn5_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Beer \"Piwko\"", 15);
        }

        private void drinkBuyBtn6_Click(object sender, EventArgs e)
        {
            Notify();
            AddToBox("Beer \"Eutro\"", 10);
        }
    }
}
