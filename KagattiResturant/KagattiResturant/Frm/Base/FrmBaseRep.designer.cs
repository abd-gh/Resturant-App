namespace GBase.Frm.Base
{
    partial class FrmBaseRep
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
            GControls.Class.Tags tags1 = new GControls.Class.Tags();
            GControls.Class.Tags tags2 = new GControls.Class.Tags();
            this.PLeft = new Stimulsoft.Controls.Win.DotNetBar.PanelEx();
            this.LField = new System.Windows.Forms.Label();
            this.ListField = new System.Windows.Forms.CheckedListBox();
            this.PRight = new Stimulsoft.Controls.Win.DotNetBar.PanelEx();
            this.BtnView = new Stimulsoft.Controls.Win.DotNetBar.ButtonX();
            this.BtnClose = new Stimulsoft.Controls.Win.DotNetBar.ButtonX();
            this.Pcontent = new System.Windows.Forms.Panel();
            this.PBack.SuspendLayout();
            this.PLeft.SuspendLayout();
            this.PRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBack
            // 
            this.PBack.Controls.Add(this.Pcontent);
            this.PBack.Location = new System.Drawing.Point(147, 0);
            this.PBack.Size = new System.Drawing.Size(285, 318);
            this.PBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PBack.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PBack.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PBack.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PBack.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PBack.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PBack.Style.GradientAngle = 90;
            tags1.OrgenalName = "";
            tags1.Tag = null;
            this.PBack.Tag = tags1;
            // 
            // PLeft
            // 
            this.PLeft.CanvasColor = System.Drawing.SystemColors.Control;
            this.PLeft.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007;
            this.PLeft.Controls.Add(this.LField);
            this.PLeft.Controls.Add(this.ListField);
            this.PLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLeft.Location = new System.Drawing.Point(0, 0);
            this.PLeft.Name = "PLeft";
            this.PLeft.Size = new System.Drawing.Size(147, 318);
            this.PLeft.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PLeft.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PLeft.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PLeft.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PLeft.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PLeft.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PLeft.Style.GradientAngle = 90;
            this.PLeft.TabIndex = 19;
            // 
            // LField
            // 
            this.LField.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LField.Location = new System.Drawing.Point(7, 5);
            this.LField.Name = "LField";
            this.LField.Size = new System.Drawing.Size(132, 22);
            this.LField.TabIndex = 15;
            this.LField.Text = "Feild";
            this.LField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListField
            // 
            this.ListField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListField.FormattingEnabled = true;
            this.ListField.Location = new System.Drawing.Point(7, 30);
            this.ListField.Name = "ListField";
            this.ListField.Size = new System.Drawing.Size(132, 284);
            this.ListField.TabIndex = 14;
            // 
            // PRight
            // 
            this.PRight.CanvasColor = System.Drawing.SystemColors.Control;
            this.PRight.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007;
            this.PRight.Controls.Add(this.BtnView);
            this.PRight.Controls.Add(this.BtnClose);
            this.PRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PRight.Location = new System.Drawing.Point(432, 0);
            this.PRight.Name = "PRight";
            this.PRight.Size = new System.Drawing.Size(148, 318);
            this.PRight.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PRight.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PRight.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PRight.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PRight.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PRight.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PRight.Style.GradientAngle = 90;
            this.PRight.TabIndex = 18;
            // 
            // BtnView
            // 
            this.BtnView.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnView.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnView.Is20Button = false;
            this.BtnView.Location = new System.Drawing.Point(24, 12);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(112, 37);
            this.BtnView.TabIndex = 46;
            this.BtnView.Tag = "";
            this.BtnView.Text = "View";
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Is20Button = false;
            this.BtnClose.Location = new System.Drawing.Point(24, 264);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(111, 37);
            this.BtnClose.TabIndex = 45;
            this.BtnClose.Tag = "";
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Pcontent
            // 
            this.Pcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pcontent.Location = new System.Drawing.Point(0, 0);
            this.Pcontent.Name = "Pcontent";
            this.Pcontent.Size = new System.Drawing.Size(285, 318);
            this.Pcontent.TabIndex = 0;
            // 
            // FrmBaseRep
            // 
            this.AcceptButton = this.BtnView;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(580, 318);
            this.Controls.Add(this.PLeft);
            this.Controls.Add(this.PRight);
            this.Name = "FrmBaseRep";
            tags2.OrgenalName = "FrmBase";
            tags2.Tag = null;
            this.Tag = tags2;
            this.Text = "BaseRep";
            this.Load += new System.EventHandler(this.FrmBaseRep_Load);
            this.Controls.SetChildIndex(this.PRight, 0);
            this.Controls.SetChildIndex(this.PLeft, 0);
            this.Controls.SetChildIndex(this.PBack, 0);
            this.PBack.ResumeLayout(false);
            this.PLeft.ResumeLayout(false);
            this.PRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Stimulsoft.Controls.Win.DotNetBar.PanelEx PLeft;
        private System.Windows.Forms.Label LField;
        public System.Windows.Forms.CheckedListBox ListField;
        private Stimulsoft.Controls.Win.DotNetBar.PanelEx PRight;
        private Stimulsoft.Controls.Win.DotNetBar.ButtonX BtnView;
        private Stimulsoft.Controls.Win.DotNetBar.ButtonX BtnClose;
        public System.Windows.Forms.Panel Pcontent;
    }
}
