namespace GBase
{
    partial class FrmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangePassword));
            GControls.Class.Tags tags1 = new GControls.Class.Tags();
            this.PBack = new Stimulsoft.Controls.Win.DotNetBar.PanelEx();
            this.LConformPassword = new System.Windows.Forms.Label();
            this.TConformPassword = new System.Windows.Forms.TextBox();
            this.LNewPassword = new System.Windows.Forms.Label();
            this.TNewPassword = new System.Windows.Forms.TextBox();
            this.LOldPassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.TOldPassword = new System.Windows.Forms.TextBox();
            this.PBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBack
            // 
            this.PBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.PBack.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007;
            this.PBack.Controls.Add(this.LConformPassword);
            this.PBack.Controls.Add(this.TConformPassword);
            this.PBack.Controls.Add(this.LNewPassword);
            this.PBack.Controls.Add(this.TNewPassword);
            this.PBack.Controls.Add(this.LOldPassword);
            this.PBack.Controls.Add(this.btnSave);
            this.PBack.Controls.Add(this.TOldPassword);
            this.PBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBack.Location = new System.Drawing.Point(0, 0);
            this.PBack.Name = "PBack";
            this.PBack.Size = new System.Drawing.Size(460, 212);
            this.PBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PBack.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PBack.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PBack.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PBack.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PBack.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PBack.Style.GradientAngle = 90;
            this.PBack.TabIndex = 19;
            this.PBack.Paint += new System.Windows.Forms.PaintEventHandler(this.PBack_Paint);
            // 
            // LConformPassword
            // 
            this.LConformPassword.AutoSize = true;
            this.LConformPassword.Location = new System.Drawing.Point(29, 118);
            this.LConformPassword.Name = "LConformPassword";
            this.LConformPassword.Size = new System.Drawing.Size(130, 18);
            this.LConformPassword.TabIndex = 25;
            this.LConformPassword.Text = "Conform Password";
            // 
            // TConformPassword
            // 
            this.TConformPassword.Location = new System.Drawing.Point(167, 115);
            this.TConformPassword.Name = "TConformPassword";
            this.TConformPassword.Size = new System.Drawing.Size(226, 25);
            this.TConformPassword.TabIndex = 26;
            // 
            // LNewPassword
            // 
            this.LNewPassword.AutoSize = true;
            this.LNewPassword.Location = new System.Drawing.Point(29, 76);
            this.LNewPassword.Name = "LNewPassword";
            this.LNewPassword.Size = new System.Drawing.Size(102, 18);
            this.LNewPassword.TabIndex = 23;
            this.LNewPassword.Text = "New Password";
            this.LNewPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // TNewPassword
            // 
            this.TNewPassword.Location = new System.Drawing.Point(167, 69);
            this.TNewPassword.Name = "TNewPassword";
            this.TNewPassword.Size = new System.Drawing.Size(226, 25);
            this.TNewPassword.TabIndex = 24;
            // 
            // LOldPassword
            // 
            this.LOldPassword.AutoSize = true;
            this.LOldPassword.Location = new System.Drawing.Point(29, 32);
            this.LOldPassword.Name = "LOldPassword";
            this.LOldPassword.Size = new System.Drawing.Size(95, 18);
            this.LOldPassword.TabIndex = 20;
            this.LOldPassword.Text = "Old Password";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(183, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 33);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TOldPassword
            // 
            this.TOldPassword.Location = new System.Drawing.Point(167, 29);
            this.TOldPassword.Name = "TOldPassword";
            this.TOldPassword.Size = new System.Drawing.Size(226, 25);
            this.TOldPassword.TabIndex = 21;
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 212);
            this.Controls.Add(this.PBack);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            tags1.OrgenalName = "FBase";
            tags1.Tag = null;
            this.Tag = tags1;
            this.Text = "FrmChangePassword";
            this.TopMost = true;
            this.MinimumSizeChanged += new System.EventHandler(this.FrmChangePassword_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.FrmChangePassword_Load);
            this.PBack.ResumeLayout(false);
            this.PBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Stimulsoft.Controls.Win.DotNetBar.PanelEx PBack;
        private System.Windows.Forms.Label LConformPassword;
        private System.Windows.Forms.TextBox TConformPassword;
        private System.Windows.Forms.Label LNewPassword;
        private System.Windows.Forms.TextBox TNewPassword;
        private System.Windows.Forms.Label LOldPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox TOldPassword;
    }
}