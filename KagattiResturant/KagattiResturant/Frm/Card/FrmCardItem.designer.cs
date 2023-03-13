namespace KagattiResturant.Frm.Card
{
    partial class FrmCardItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardItem));
            this.TSection = new GControls.UI.SearchEdit();
            this.LName = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.Tprice = new System.Windows.Forms.TextBox();
            this.LPrice = new System.Windows.Forms.Label();
            this.LSection = new System.Windows.Forms.Label();
            this.TQuantity = new System.Windows.Forms.TextBox();
            this.LQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.PBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // TNumber
            // 
            this.TNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // BtnDesign
            // 
            this.BtnDesign.Image = ((System.Drawing.Image)(resources.GetObject("BtnDesign.Image")));
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(9, 331);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.PBack.Controls.Add(this.TQuantity);
            this.PBack.Controls.Add(this.LQuantity);
            this.PBack.Controls.Add(this.LSection);
            this.PBack.Controls.Add(this.Tprice);
            this.PBack.Controls.Add(this.LPrice);
            this.PBack.Controls.Add(this.TName);
            this.PBack.Controls.Add(this.LName);
            this.PBack.Controls.Add(this.TSection);
            this.PBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PBack.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PBack.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PBack.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PBack.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PBack.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PBack.Style.GradientAngle = 90;
            this.PBack.Paint += new System.Windows.Forms.PaintEventHandler(this.PBack_Paint);
            this.PBack.Controls.SetChildIndex(this.TSection, 0);
            this.PBack.Controls.SetChildIndex(this.LName, 0);
            this.PBack.Controls.SetChildIndex(this.TName, 0);
            this.PBack.Controls.SetChildIndex(this.LPrice, 0);
            this.PBack.Controls.SetChildIndex(this.Tprice, 0);
            this.PBack.Controls.SetChildIndex(this.LSection, 0);
            this.PBack.Controls.SetChildIndex(this.LQuantity, 0);
            this.PBack.Controls.SetChildIndex(this.TQuantity, 0);
            // 
            // TSection
            // 
            this.TSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TSection.ButtonShow = true;
            this.TSection.Condition = null;
            this.TSection.ConnectionString = "";
            this.TSection.DisplayText = "Name";
            this.TSection.FormSearchText = null;
            this.TSection.GenerateFelidSearch = false;
            this.TSection.guid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.TSection.ID = 0;
            this.TSection.Location = new System.Drawing.Point(115, 198);
            this.TSection.Margin = new System.Windows.Forms.Padding(768, 1717, 768, 1717);
            this.TSection.More_Choices = false;
            this.TSection.Name = "TSection";
            this.TSection.NForm = null;
            this.TSection.PkFelid = "GUID";
            this.TSection.Size = new System.Drawing.Size(299, 30);
            this.TSection.TabIndex = 27;
            this.TSection.TableName = "VwSearchRestSection";
            this.TSection.Value = "";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(29, 77);
            this.LName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(59, 23);
            this.LName.TabIndex = 28;
            this.LName.Text = "Name";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(115, 73);
            this.TName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(298, 30);
            this.TName.TabIndex = 29;
            this.TName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tprice
            // 
            this.Tprice.Location = new System.Drawing.Point(115, 125);
            this.Tprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tprice.Name = "Tprice";
            this.Tprice.Size = new System.Drawing.Size(298, 30);
            this.Tprice.TabIndex = 31;
            this.Tprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LPrice
            // 
            this.LPrice.AutoSize = true;
            this.LPrice.Location = new System.Drawing.Point(29, 128);
            this.LPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPrice.Name = "LPrice";
            this.LPrice.Size = new System.Drawing.Size(50, 23);
            this.LPrice.TabIndex = 30;
            this.LPrice.Text = "Price";
            // 
            // LSection
            // 
            this.LSection.AutoSize = true;
            this.LSection.Location = new System.Drawing.Point(25, 180);
            this.LSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LSection.Name = "LSection";
            this.LSection.Size = new System.Drawing.Size(71, 23);
            this.LSection.TabIndex = 32;
            this.LSection.Text = "Section";
            // 
            // TQuantity
            // 
            this.TQuantity.Location = new System.Drawing.Point(115, 242);
            this.TQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TQuantity.Name = "TQuantity";
            this.TQuantity.Size = new System.Drawing.Size(298, 30);
            this.TQuantity.TabIndex = 34;
            this.TQuantity.Text = "0";
            this.TQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TQuantity.TextChanged += new System.EventHandler(this.TQuantity_TextChanged);
            // 
            // LQuantity
            // 
            this.LQuantity.AutoSize = true;
            this.LQuantity.Location = new System.Drawing.Point(13, 242);
            this.LQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LQuantity.Name = "LQuantity";
            this.LQuantity.Size = new System.Drawing.Size(80, 23);
            this.LQuantity.TabIndex = 33;
            this.LQuantity.Text = "Quantity";
            // 
            // FrmCardItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 403);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmCardItem";
            this.RepName = "C:\\Users\\Geth\\AppData\\Local\\Microsoft\\VisualStudio\\14.0\\ProjectAssemblies\\hrfm_sh" +
    "f01\\CustRep\\CardPrint\\FrmCardItem.mrt";
            this.SearshTableName = "VwSearchRestItem";
            this.TableName = "RestItem";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.FrmCardItem_Load);
            this.SizeChanged += new System.EventHandler(this.FrmCardItem_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.PBack.ResumeLayout(false);
            this.PBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LSection;
        private System.Windows.Forms.TextBox Tprice;
        private System.Windows.Forms.Label LPrice;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Label LName;
        private GControls.UI.SearchEdit TSection;
        private System.Windows.Forms.TextBox TQuantity;
        private System.Windows.Forms.Label LQuantity;


    }
}