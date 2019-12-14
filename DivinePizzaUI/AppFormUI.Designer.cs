namespace DivinePizzaUI
{
    partial class AppFormUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppFormUI));
            this.sidebar = new System.Windows.Forms.Panel();
            this.Box = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.countLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.changeUserBtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.saladsBtn = new System.Windows.Forms.RadioButton();
            this.drinksBtn = new System.Windows.Forms.RadioButton();
            this.pizzasBtn = new System.Windows.Forms.RadioButton();
            this.mailBtn = new System.Windows.Forms.PictureBox();
            this.instagramBtn = new System.Windows.Forms.PictureBox();
            this.facebookBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salads = new DivinePizzaUI.SaladsUserUI();
            this.drinks = new DivinePizzaUI.DrinksUserUI();
            this.pizzas = new DivinePizzaUI.PizzasUserUI();
            this.sidebar.SuspendLayout();
            this.Box.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeUserBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagramBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.sidebar.Controls.Add(this.Box);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.label3);
            this.sidebar.Controls.Add(this.mailBtn);
            this.sidebar.Controls.Add(this.instagramBtn);
            this.sidebar.Controls.Add(this.facebookBtn);
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(203, 1242);
            this.sidebar.TabIndex = 0;
            // 
            // Box
            // 
            this.Box.BackColor = System.Drawing.Color.White;
            this.Box.Controls.Add(this.panel2);
            this.Box.Controls.Add(this.pictureBox5);
            this.Box.Controls.Add(this.countLbl);
            this.Box.Controls.Add(this.priceLbl);
            this.Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box.Location = new System.Drawing.Point(49, 667);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(108, 51);
            this.Box.TabIndex = 13;
            this.Box.Click += new System.EventHandler(this.Box_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Location = new System.Drawing.Point(49, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 51);
            this.panel2.TabIndex = 8;
            // 
            // countLbl
            // 
            this.countLbl.BackColor = System.Drawing.Color.Transparent;
            this.countLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.countLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.countLbl.Location = new System.Drawing.Point(4, 6);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(44, 24);
            this.countLbl.TabIndex = 6;
            this.countLbl.Text = "0";
            this.countLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLbl
            // 
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.priceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.priceLbl.Location = new System.Drawing.Point(44, 10);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceLbl.Size = new System.Drawing.Size(75, 29);
            this.priceLbl.TabIndex = 7;
            this.priceLbl.Text = "0 $";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.saladsBtn);
            this.panel3.Controls.Add(this.drinksBtn);
            this.panel3.Controls.Add(this.pizzasBtn);
            this.panel3.Location = new System.Drawing.Point(-5, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 411);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 780);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "© 2018 DIVINE PIZZA";
            // 
            // changeUserBtn
            // 
            this.changeUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeUserBtn.Image = global::DivinePizzaUI.Properties.Resources.changeuser_icon;
            this.changeUserBtn.Location = new System.Drawing.Point(972, 0);
            this.changeUserBtn.Name = "changeUserBtn";
            this.changeUserBtn.Size = new System.Drawing.Size(24, 22);
            this.changeUserBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.changeUserBtn.TabIndex = 4;
            this.changeUserBtn.TabStop = false;
            this.changeUserBtn.Click += new System.EventHandler(this.changeUserBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Image = global::DivinePizzaUI.Properties.Resources.exit;
            this.exitBtn.Location = new System.Drawing.Point(996, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(24, 22);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitBtn.TabIndex = 3;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::DivinePizzaUI.Properties.Resources.boxes_icon;
            this.pictureBox5.Location = new System.Drawing.Point(11, 33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 12);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // saladsBtn
            // 
            this.saladsBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.saladsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.saladsBtn.BackgroundImage = global::DivinePizzaUI.Properties.Resources.salads_whiteicon;
            this.saladsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saladsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saladsBtn.FlatAppearance.BorderSize = 0;
            this.saladsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.saladsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.saladsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.saladsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saladsBtn.Location = new System.Drawing.Point(5, 231);
            this.saladsBtn.Name = "saladsBtn";
            this.saladsBtn.Size = new System.Drawing.Size(203, 114);
            this.saladsBtn.TabIndex = 2;
            this.saladsBtn.TabStop = true;
            this.saladsBtn.UseVisualStyleBackColor = false;
            this.saladsBtn.CheckedChanged += new System.EventHandler(this.saladsBtn_CheckedChanged);
            this.saladsBtn.MouseLeave += new System.EventHandler(this.saladsBtn_MouseLeave);
            this.saladsBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.saladsBtn_MouseMove);
            // 
            // drinksBtn
            // 
            this.drinksBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.drinksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.drinksBtn.BackgroundImage = global::DivinePizzaUI.Properties.Resources.drinks_whiteicon;
            this.drinksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.drinksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drinksBtn.FlatAppearance.BorderSize = 0;
            this.drinksBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.drinksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.drinksBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.drinksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinksBtn.Location = new System.Drawing.Point(5, 117);
            this.drinksBtn.Name = "drinksBtn";
            this.drinksBtn.Size = new System.Drawing.Size(203, 114);
            this.drinksBtn.TabIndex = 1;
            this.drinksBtn.TabStop = true;
            this.drinksBtn.UseVisualStyleBackColor = false;
            this.drinksBtn.CheckedChanged += new System.EventHandler(this.drinksBtn_CheckedChanged);
            this.drinksBtn.MouseLeave += new System.EventHandler(this.drinksBtn_MouseLeave);
            this.drinksBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drinksBtn_MouseMove);
            // 
            // pizzasBtn
            // 
            this.pizzasBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.pizzasBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pizzasBtn.BackgroundImage = global::DivinePizzaUI.Properties.Resources.pizzas_whiteicon;
            this.pizzasBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pizzasBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pizzasBtn.FlatAppearance.BorderSize = 0;
            this.pizzasBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.pizzasBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.pizzasBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.pizzasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pizzasBtn.Location = new System.Drawing.Point(5, 3);
            this.pizzasBtn.Name = "pizzasBtn";
            this.pizzasBtn.Size = new System.Drawing.Size(203, 114);
            this.pizzasBtn.TabIndex = 0;
            this.pizzasBtn.TabStop = true;
            this.pizzasBtn.UseVisualStyleBackColor = false;
            this.pizzasBtn.CheckedChanged += new System.EventHandler(this.pizzasBtn_CheckedChanged);
            this.pizzasBtn.MouseLeave += new System.EventHandler(this.pizzasBtn_MouseLeave);
            this.pizzasBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pizzasBtn_MouseMove);
            // 
            // mailBtn
            // 
            this.mailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailBtn.Image = global::DivinePizzaUI.Properties.Resources.envelope_icon;
            this.mailBtn.Location = new System.Drawing.Point(122, 746);
            this.mailBtn.Name = "mailBtn";
            this.mailBtn.Size = new System.Drawing.Size(24, 24);
            this.mailBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mailBtn.TabIndex = 10;
            this.mailBtn.TabStop = false;
            this.mailBtn.Click += new System.EventHandler(this.mailBtn_Click);
            // 
            // instagramBtn
            // 
            this.instagramBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instagramBtn.Image = global::DivinePizzaUI.Properties.Resources.instagram_icon;
            this.instagramBtn.Location = new System.Drawing.Point(89, 746);
            this.instagramBtn.Name = "instagramBtn";
            this.instagramBtn.Size = new System.Drawing.Size(24, 24);
            this.instagramBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.instagramBtn.TabIndex = 9;
            this.instagramBtn.TabStop = false;
            // 
            // facebookBtn
            // 
            this.facebookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facebookBtn.Image = global::DivinePizzaUI.Properties.Resources.facebook_icon;
            this.facebookBtn.Location = new System.Drawing.Point(55, 746);
            this.facebookBtn.Name = "facebookBtn";
            this.facebookBtn.Size = new System.Drawing.Size(24, 24);
            this.facebookBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.facebookBtn.TabIndex = 8;
            this.facebookBtn.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DivinePizzaUI.Properties.Resources.logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(45, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // salads
            // 
            this.salads.BackColor = System.Drawing.Color.White;
            this.salads.Location = new System.Drawing.Point(204, 0);
            this.salads.Name = "salads";
            this.salads.Size = new System.Drawing.Size(816, 1242);
            this.salads.TabIndex = 3;
            // 
            // drinks
            // 
            this.drinks.BackColor = System.Drawing.Color.White;
            this.drinks.Location = new System.Drawing.Point(204, 0);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(816, 1242);
            this.drinks.TabIndex = 2;
            // 
            // pizzas
            // 
            this.pizzas.BackColor = System.Drawing.Color.White;
            this.pizzas.Location = new System.Drawing.Point(204, 0);
            this.pizzas.Name = "pizzas";
            this.pizzas.Size = new System.Drawing.Size(816, 1242);
            this.pizzas.TabIndex = 1;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 824);
            this.Controls.Add(this.changeUserBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.salads);
            this.Controls.Add(this.drinks);
            this.Controls.Add(this.pizzas);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1039, 824);
            this.MinimumSize = new System.Drawing.Size(1039, 824);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "app";
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeUserBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagramBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox facebookBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox mailBtn;
        private System.Windows.Forms.PictureBox instagramBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton pizzasBtn;
        private System.Windows.Forms.RadioButton saladsBtn;
        private System.Windows.Forms.RadioButton drinksBtn;
        private PizzasUserUI pizzas;
        public System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Panel Box;
        private System.Windows.Forms.Panel panel2;
        private DrinksUserUI drinks;
        private SaladsUserUI salads;
        public System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.PictureBox changeUserBtn;
    }
}