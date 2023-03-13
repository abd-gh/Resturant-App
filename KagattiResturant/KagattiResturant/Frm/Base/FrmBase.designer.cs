namespace GBase
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            GControls.Class.Tags tags1 = new GControls.Class.Tags();
            this.PBack = new Stimulsoft.Controls.Win.DotNetBar.PanelEx();
            this.SuspendLayout();
            // 
            // PBack
            // 
            this.PBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.PBack.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007;
            this.PBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBack.Location = new System.Drawing.Point(0, 0);
            this.PBack.Name = "PBack";
            this.PBack.Size = new System.Drawing.Size(759, 284);
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
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 284);
            this.Controls.Add(this.PBack);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBase";
            tags1.OrgenalName = "FBase";
            tags1.Tag = null;
            this.Tag = tags1;
            this.Text = "FrmBase";
            this.MinimumSizeChanged += new System.EventHandler(this.FrmBase_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Stimulsoft.Controls.Win.DotNetBar.PanelEx PBack;
    }
}