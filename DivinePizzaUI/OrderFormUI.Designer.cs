namespace DivinePizzaUI
{
    partial class OrderFormUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderFormUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buyBtn = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.h1Lbl = new System.Windows.Forms.Label();
            this.pricePnl = new System.Windows.Forms.Panel();
            this.priceLbl = new System.Windows.Forms.Label();
            this.orderLbl = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.buyBtn.SuspendLayout();
            this.pricePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 98);
            this.panel1.TabIndex = 1;
            // 
            // buyBtn
            // 
            this.buyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.buyBtn.Controls.Add(this.label4);
            this.buyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buyBtn.Location = new System.Drawing.Point(0, 317);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(350, 57);
            this.buyBtn.TabIndex = 4;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(105, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Make an order";
            // 
            // h1Lbl
            // 
            this.h1Lbl.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h1Lbl.Location = new System.Drawing.Point(24, 106);
            this.h1Lbl.Name = "h1Lbl";
            this.h1Lbl.Size = new System.Drawing.Size(302, 40);
            this.h1Lbl.TabIndex = 5;
            this.h1Lbl.Text = "Your Box";
            this.h1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pricePnl
            // 
            this.pricePnl.AutoSize = true;
            this.pricePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pricePnl.Controls.Add(this.priceLbl);
            this.pricePnl.Location = new System.Drawing.Point(129, 272);
            this.pricePnl.Name = "pricePnl";
            this.pricePnl.Size = new System.Drawing.Size(100, 40);
            this.pricePnl.TabIndex = 7;
            // 
            // priceLbl
            // 
            this.priceLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.ForeColor = System.Drawing.Color.White;
            this.priceLbl.Location = new System.Drawing.Point(9, 7);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(83, 22);
            this.priceLbl.TabIndex = 8;
            this.priceLbl.Text = "0 $";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderLbl
            // 
            this.orderLbl.BackColor = System.Drawing.Color.White;
            this.orderLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.orderLbl.ForeColor = System.Drawing.Color.Gray;
            this.orderLbl.HideSelection = false;
            this.orderLbl.Location = new System.Drawing.Point(24, 149);
            this.orderLbl.Multiline = true;
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.ReadOnly = true;
            this.orderLbl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.orderLbl.Size = new System.Drawing.Size(302, 117);
            this.orderLbl.TabIndex = 6;
            this.orderLbl.Text = "is empty";
            this.orderLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitBtn
            // 
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Image = global::DivinePizzaUI.Properties.Resources.exit;
            this.exitBtn.Location = new System.Drawing.Point(326, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(24, 22);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DivinePizzaUI.Properties.Resources.logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(122, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Divine Pizza App";
            this.notify.Visible = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 374);
            this.ControlBox = false;
            this.Controls.Add(this.orderLbl);
            this.Controls.Add(this.h1Lbl);
            this.Controls.Add(this.pricePnl);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 374);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 374);
            this.Name = "Order";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.buyBtn.ResumeLayout(false);
            this.buyBtn.PerformLayout();
            this.pricePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel buyBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label h1Lbl;
        private System.Windows.Forms.Panel pricePnl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox orderLbl;
        private System.Windows.Forms.NotifyIcon notify;
    }
}