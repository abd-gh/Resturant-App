namespace KagattiResturant.Frm
{
    partial class FrmBasee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBasee));
            GControls.Class.Tags tags1 = new GControls.Class.Tags();
            this.PBack = new Stimulsoft.Controls.Win.DotNetBar.PanelEx();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBack
            // 
            this.PBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.PBack.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007;
            this.PBack.Controls.Add(this.button1);
            this.PBack.Controls.Add(this.button2);
            this.PBack.Controls.Add(this.label1);
            this.PBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBack.Location = new System.Drawing.Point(0, 0);
            this.PBack.Name = "PBack";
            this.PBack.Size = new System.Drawing.Size(484, 127);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancel Active";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "The Program Activation";
            // 
            // FrmBasee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 127);
            this.Controls.Add(this.PBack);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBasee";
            tags1.OrgenalName = "FBase";
            tags1.Tag = null;
            this.Tag = tags1;
            this.Text = "FrmBasee";
            this.MinimumSizeChanged += new System.EventHandler(this.FrmBasee_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.FrmBasee_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBasee_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmBasee_MouseDown);
            this.PBack.ResumeLayout(false);
            this.PBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Stimulsoft.Controls.Win.DotNetBar.PanelEx PBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}