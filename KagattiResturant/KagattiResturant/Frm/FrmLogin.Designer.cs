namespace KagattiResturant.Frm
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.P_Btn = new Stimulsoft.Controls.Win.DotNetBar.PanelEx();
            this.LRe = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.L_Password = new System.Windows.Forms.Label();
            this.L_Login_info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TUserName = new System.Windows.Forms.TextBox();
            this.LUserName = new System.Windows.Forms.Label();
            this.PBack.SuspendLayout();
            this.P_Btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PBack
            // 
            this.PBack.Controls.Add(this.TUserName);
            this.PBack.Controls.Add(this.LUserName);
            this.PBack.Controls.Add(this.pictureBox1);
            this.PBack.Controls.Add(this.P_Btn);
            this.PBack.Controls.Add(this.TPassword);
            this.PBack.Controls.Add(this.L_Password);
            this.PBack.Controls.Add(this.L_Login_info);
            this.PBack.Size = new System.Drawing.Size(629, 165);
            this.PBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PBack.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PBack.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PBack.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PBack.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PBack.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PBack.Style.GradientAngle = 90;
            this.PBack.TabIndex = 19;
            // 
            // P_Btn
            // 
            this.P_Btn.Controls.Add(this.LRe);
            this.P_Btn.Controls.Add(this.Btn_Cancel);
            this.P_Btn.Controls.Add(this.Btn_OK);
            this.P_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_Btn.Location = new System.Drawing.Point(0, 0);
            this.P_Btn.Name = "P_Btn";
            this.P_Btn.Size = new System.Drawing.Size(163, 165);
            this.P_Btn.TabIndex = 6;
            // 
            // LRe
            // 
            this.LRe.AutoSize = true;
            this.LRe.Location = new System.Drawing.Point(12, 170);
            this.LRe.Name = "LRe";
            this.LRe.Size = new System.Drawing.Size(44, 18);
            this.LRe.TabIndex = 2;
            this.LRe.Text = "label1";
            this.LRe.Visible = false;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cancel.Location = new System.Drawing.Point(13, 60);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(132, 31);
            this.Btn_Cancel.TabIndex = 1;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_OK.Location = new System.Drawing.Point(13, 12);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(132, 31);
            this.Btn_OK.TabIndex = 0;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // TPassword
            // 
            this.TPassword.Location = new System.Drawing.Point(166, 114);
            this.TPassword.Name = "TPassword";
            this.TPassword.PasswordChar = '*';
            this.TPassword.Size = new System.Drawing.Size(311, 25);
            this.TPassword.TabIndex = 2;
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Location = new System.Drawing.Point(169, 93);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(69, 18);
            this.L_Password.TabIndex = 2;
            this.L_Password.Text = "Password";
            // 
            // L_Login_info
            // 
            this.L_Login_info.AutoSize = true;
            this.L_Login_info.Location = new System.Drawing.Point(169, 9);
            this.L_Login_info.Name = "L_Login_info";
            this.L_Login_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Login_info.Size = new System.Drawing.Size(335, 18);
            this.L_Login_info.TabIndex = 0;
            this.L_Login_info.Text = "Please enter UserName And password to open file";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(510, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TUserName
            // 
            this.TUserName.Location = new System.Drawing.Point(166, 60);
            this.TUserName.Name = "TUserName";
            this.TUserName.Size = new System.Drawing.Size(311, 25);
            this.TUserName.TabIndex = 1;
            // 
            // LUserName
            // 
            this.LUserName.AutoSize = true;
            this.LUserName.Location = new System.Drawing.Point(169, 32);
            this.LUserName.Name = "LUserName";
            this.LUserName.Size = new System.Drawing.Size(77, 18);
            this.LUserName.TabIndex = 9;
            this.LUserName.Text = "UserName";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.Btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.CancelButton = this.Btn_Cancel;
            this.ClientSize = new System.Drawing.Size(629, 165);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogin";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.PBack.ResumeLayout(false);
            this.PBack.PerformLayout();
            this.P_Btn.ResumeLayout(false);
            this.P_Btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label L_Login_info;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.TextBox TPassword;
        private Stimulsoft.Controls.Win.DotNetBar.PanelEx P_Btn;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label LRe;
        private System.Windows.Forms.TextBox TUserName;
        private System.Windows.Forms.Label LUserName;
    }
}