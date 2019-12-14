namespace DivinePizzaUI
{
    partial class loginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.sendPhoneBtn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sendCodeBtn = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.codeLbl = new System.Windows.Forms.Label();
            this.checkcodeBtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.phoneTb = new MetroFramework.Controls.MetroTextBox();
            this.codeTb = new MetroFramework.Controls.MetroTextBox();
            this.sendPhoneBtn.SuspendLayout();
            this.sendCodeBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkcodeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sendPhoneBtn
            // 
            this.sendPhoneBtn.BackColor = System.Drawing.Color.White;
            this.sendPhoneBtn.Controls.Add(this.label1);
            this.sendPhoneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendPhoneBtn.Location = new System.Drawing.Point(43, 329);
            this.sendPhoneBtn.Name = "sendPhoneBtn";
            this.sendPhoneBtn.Size = new System.Drawing.Size(239, 49);
            this.sendPhoneBtn.TabIndex = 7;
            this.sendPhoneBtn.Click += new System.EventHandler(this.sendPhoneBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "SEND";
            // 
            // sendCodeBtn
            // 
            this.sendCodeBtn.BackColor = System.Drawing.Color.White;
            this.sendCodeBtn.Controls.Add(this.label2);
            this.sendCodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendCodeBtn.Location = new System.Drawing.Point(43, 467);
            this.sendCodeBtn.Name = "sendCodeBtn";
            this.sendCodeBtn.Size = new System.Drawing.Size(239, 49);
            this.sendCodeBtn.TabIndex = 10;
            this.sendCodeBtn.Click += new System.EventHandler(this.sendCodeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "CONFIRM";
            // 
            // statusLbl
            // 
            this.statusLbl.BackColor = System.Drawing.Color.Transparent;
            this.statusLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ForeColor = System.Drawing.Color.White;
            this.statusLbl.Location = new System.Drawing.Point(42, 548);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(240, 22);
            this.statusLbl.TabIndex = 9;
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codeLbl
            // 
            this.codeLbl.BackColor = System.Drawing.Color.Transparent;
            this.codeLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.codeLbl.Location = new System.Drawing.Point(202, 0);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(75, 22);
            this.codeLbl.TabIndex = 11;
            this.codeLbl.Text = "####";
            this.codeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.codeLbl.Visible = false;
            // 
            // checkcodeBtn
            // 
            this.checkcodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkcodeBtn.Image = global::DivinePizzaUI.Properties.Resources.checkcode_icon;
            this.checkcodeBtn.Location = new System.Drawing.Point(274, 0);
            this.checkcodeBtn.Name = "checkcodeBtn";
            this.checkcodeBtn.Size = new System.Drawing.Size(24, 22);
            this.checkcodeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.checkcodeBtn.TabIndex = 12;
            this.checkcodeBtn.TabStop = false;
            this.checkcodeBtn.Click += new System.EventHandler(this.checkcodeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Image = global::DivinePizzaUI.Properties.Resources.exit;
            this.exitBtn.Location = new System.Drawing.Point(298, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(24, 22);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitBtn.TabIndex = 2;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DivinePizzaUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(54, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // phoneTb
            // 
            // 
            // 
            // 
            this.phoneTb.CustomButton.Image = null;
            this.phoneTb.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.phoneTb.CustomButton.Name = "";
            this.phoneTb.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.phoneTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phoneTb.CustomButton.TabIndex = 1;
            this.phoneTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phoneTb.CustomButton.UseSelectable = true;
            this.phoneTb.CustomButton.Visible = false;
            this.phoneTb.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.phoneTb.ForeColor = System.Drawing.Color.White;
            this.phoneTb.Lines = new string[] {
        "+380"};
            this.phoneTb.Location = new System.Drawing.Point(43, 295);
            this.phoneTb.MaxLength = 32767;
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.PasswordChar = '\0';
            this.phoneTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneTb.SelectedText = "";
            this.phoneTb.SelectionLength = 0;
            this.phoneTb.SelectionStart = 0;
            this.phoneTb.ShortcutsEnabled = true;
            this.phoneTb.Size = new System.Drawing.Size(240, 35);
            this.phoneTb.Style = MetroFramework.MetroColorStyle.White;
            this.phoneTb.TabIndex = 13;
            this.phoneTb.Text = "+380";
            this.phoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneTb.UseCustomBackColor = true;
            this.phoneTb.UseCustomForeColor = true;
            this.phoneTb.UseSelectable = true;
            this.phoneTb.UseStyleColors = true;
            this.phoneTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phoneTb.WaterMarkFont = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneTb_KeyDown);
            this.phoneTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTb_KeyPress);
            // 
            // codeTb
            // 
            // 
            // 
            // 
            this.codeTb.CustomButton.Image = null;
            this.codeTb.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.codeTb.CustomButton.Name = "";
            this.codeTb.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.codeTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.codeTb.CustomButton.TabIndex = 1;
            this.codeTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codeTb.CustomButton.UseSelectable = true;
            this.codeTb.CustomButton.Visible = false;
            this.codeTb.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.codeTb.ForeColor = System.Drawing.Color.White;
            this.codeTb.Lines = new string[0];
            this.codeTb.Location = new System.Drawing.Point(43, 433);
            this.codeTb.MaxLength = 32767;
            this.codeTb.Name = "codeTb";
            this.codeTb.PasswordChar = '\0';
            this.codeTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codeTb.SelectedText = "";
            this.codeTb.SelectionLength = 0;
            this.codeTb.SelectionStart = 0;
            this.codeTb.ShortcutsEnabled = true;
            this.codeTb.Size = new System.Drawing.Size(240, 35);
            this.codeTb.Style = MetroFramework.MetroColorStyle.White;
            this.codeTb.TabIndex = 14;
            this.codeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codeTb.UseCustomBackColor = true;
            this.codeTb.UseCustomForeColor = true;
            this.codeTb.UseSelectable = true;
            this.codeTb.UseStyleColors = true;
            this.codeTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.codeTb.WaterMarkFont = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(322, 600);
            this.ControlBox = false;
            this.Controls.Add(this.codeTb);
            this.Controls.Add(this.phoneTb);
            this.Controls.Add(this.checkcodeBtn);
            this.Controls.Add(this.codeLbl);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.sendCodeBtn);
            this.Controls.Add(this.sendPhoneBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.sendPhoneBtn.ResumeLayout(false);
            this.sendPhoneBtn.PerformLayout();
            this.sendCodeBtn.ResumeLayout(false);
            this.sendCodeBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkcodeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Panel sendPhoneBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sendCodeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.PictureBox checkcodeBtn;
        private MetroFramework.Controls.MetroTextBox phoneTb;
        private MetroFramework.Controls.MetroTextBox codeTb;
    }
}

