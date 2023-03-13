namespace KagattiResturant.Frm.Card
{
    partial class FrmCardSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardSection));
            this.LName = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.combPrinter = new Stimulsoft.Controls.Win.DotNetBar.Controls.ComboBoxEx();
            this.LPrinter = new System.Windows.Forms.Label();
            this.LIsProduct = new System.Windows.Forms.Label();
            this.CIsProduct = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.PBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDesign
            // 
            this.BtnDesign.Image = ((System.Drawing.Image)(resources.GetObject("BtnDesign.Image")));
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(7, 271);
            // 
            // BtnShow
            // 
            this.BtnShow.Image = ((System.Drawing.Image)(resources.GetObject("BtnShow.Image")));
            // 
            // BtnDel
            // 
            this.BtnDel.Image = ((System.Drawing.Image)(resources.GetObject("BtnDel.Image")));
            // 
            // BtnSave
            // 
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            // 
            // BtnNew
            // 
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            // 
            // PBack
            // 
            this.PBack.Controls.Add(this.CIsProduct);
            this.PBack.Controls.Add(this.LIsProduct);
            this.PBack.Controls.Add(this.LPrinter);
            this.PBack.Controls.Add(this.combPrinter);
            this.PBack.Controls.Add(this.TName);
            this.PBack.Controls.Add(this.LName);
            this.PBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PBack.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PBack.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PBack.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PBack.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PBack.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PBack.Style.GradientAngle = 90;
            this.PBack.Paint += new System.Windows.Forms.PaintEventHandler(this.PBack_Paint);
            this.PBack.Controls.SetChildIndex(this.LName, 0);
            this.PBack.Controls.SetChildIndex(this.TName, 0);
            this.PBack.Controls.SetChildIndex(this.combPrinter, 0);
            this.PBack.Controls.SetChildIndex(this.LPrinter, 0);
            this.PBack.Controls.SetChildIndex(this.LIsProduct, 0);
            this.PBack.Controls.SetChildIndex(this.CIsProduct, 0);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(21, 70);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(52, 18);
            this.LName.TabIndex = 5;
            this.LName.Text = "Name ";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(101, 67);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(230, 25);
            this.TName.TabIndex = 6;
            // 
            // combPrinter
            // 
            this.combPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combPrinter.FormattingEnabled = true;
            this.combPrinter.Location = new System.Drawing.Point(100, 113);
            this.combPrinter.Name = "combPrinter";
            this.combPrinter.Size = new System.Drawing.Size(231, 26);
            this.combPrinter.TabIndex = 34;
            // 
            // LPrinter
            // 
            this.LPrinter.AutoSize = true;
            this.LPrinter.Location = new System.Drawing.Point(21, 112);
            this.LPrinter.Name = "LPrinter";
            this.LPrinter.Size = new System.Drawing.Size(49, 18);
            this.LPrinter.TabIndex = 35;
            this.LPrinter.Text = "Printer";
            // 
            // LIsProduct
            // 
            this.LIsProduct.AutoSize = true;
            this.LIsProduct.Location = new System.Drawing.Point(12, 167);
            this.LIsProduct.Name = "LIsProduct";
            this.LIsProduct.Size = new System.Drawing.Size(75, 18);
            this.LIsProduct.TabIndex = 36;
            this.LIsProduct.Text = "Is Product";
            // 
            // CIsProduct
            // 
            this.CIsProduct.BackColor = System.Drawing.Color.White;
            this.CIsProduct.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CIsProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CIsProduct.Location = new System.Drawing.Point(101, 167);
            this.CIsProduct.Name = "CIsProduct";
            this.CIsProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CIsProduct.Size = new System.Drawing.Size(230, 22);
            this.CIsProduct.TabIndex = 45;
            this.CIsProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CIsProduct.UseVisualStyleBackColor = false;
            // 
            // FrmCardSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 330);
            this.Name = "FrmCardSection";
            this.RepName = "C:\\Users\\Geth\\AppData\\Local\\Microsoft\\VisualStudio\\14.0\\ProjectAssemblies\\hrfm_sh" +
    "f01\\CustRep\\CardPrint\\FrmCardSection.mrt";
            this.SearshTableName = "VwSearchRestSection";
            this.TableName = "RestSection";
            this.Text = "Section";
            this.Load += new System.EventHandler(this.FrmCardSection_Load);
            this.SizeChanged += new System.EventHandler(this.FrmCardSection_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.PBack.ResumeLayout(false);
            this.PBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LPrinter;
        private Stimulsoft.Controls.Win.DotNetBar.Controls.ComboBoxEx combPrinter;
        private System.Windows.Forms.Label LIsProduct;
        private System.Windows.Forms.CheckBox CIsProduct;

    }
}