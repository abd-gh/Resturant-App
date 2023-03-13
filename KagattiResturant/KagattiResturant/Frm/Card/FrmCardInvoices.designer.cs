namespace KagattiResturant.Frm.Card
{
    partial class FrmCardInvoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardInvoices));
            this.TTitle = new System.Windows.Forms.TextBox();
            this.TPrice = new System.Windows.Forms.TextBox();
            this.TNotes = new System.Windows.Forms.TextBox();
            this.TUsers = new GControls.UI.SearchEdit();
            this.LTitle = new System.Windows.Forms.Label();
            this.LPrice = new System.Windows.Forms.Label();
            this.LNotes = new System.Windows.Forms.Label();
            this.LUsers = new System.Windows.Forms.Label();
            this.LDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.PBack.Controls.Add(this.label1);
            this.PBack.Controls.Add(this.LDate);
            this.PBack.Controls.Add(this.LUsers);
            this.PBack.Controls.Add(this.LNotes);
            this.PBack.Controls.Add(this.LPrice);
            this.PBack.Controls.Add(this.LTitle);
            this.PBack.Controls.Add(this.TUsers);
            this.PBack.Controls.Add(this.TNotes);
            this.PBack.Controls.Add(this.TPrice);
            this.PBack.Controls.Add(this.TTitle);
            this.PBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PBack.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PBack.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PBack.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PBack.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PBack.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PBack.Style.GradientAngle = 90;
            this.PBack.Paint += new System.Windows.Forms.PaintEventHandler(this.PBack_Paint);
            this.PBack.Controls.SetChildIndex(this.TTitle, 0);
            this.PBack.Controls.SetChildIndex(this.TPrice, 0);
            this.PBack.Controls.SetChildIndex(this.TNotes, 0);
            this.PBack.Controls.SetChildIndex(this.TUsers, 0);
            this.PBack.Controls.SetChildIndex(this.LTitle, 0);
            this.PBack.Controls.SetChildIndex(this.LPrice, 0);
            this.PBack.Controls.SetChildIndex(this.LNotes, 0);
            this.PBack.Controls.SetChildIndex(this.LUsers, 0);
            this.PBack.Controls.SetChildIndex(this.LDate, 0);
            this.PBack.Controls.SetChildIndex(this.label1, 0);
            // 
            // TTitle
            // 
            this.TTitle.Location = new System.Drawing.Point(100, 68);
            this.TTitle.Name = "TTitle";
            this.TTitle.Size = new System.Drawing.Size(173, 25);
            this.TTitle.TabIndex = 5;
            // 
            // TPrice
            // 
            this.TPrice.Location = new System.Drawing.Point(100, 105);
            this.TPrice.Name = "TPrice";
            this.TPrice.Size = new System.Drawing.Size(173, 25);
            this.TPrice.TabIndex = 6;
            // 
            // TNotes
            // 
            this.TNotes.Location = new System.Drawing.Point(100, 138);
            this.TNotes.Name = "TNotes";
            this.TNotes.Size = new System.Drawing.Size(173, 25);
            this.TNotes.TabIndex = 7;
            // 
            // TUsers
            // 
            this.TUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TUsers.ButtonShow = true;
            this.TUsers.Condition = null;
            this.TUsers.ConnectionString = "";
            this.TUsers.DisplayText = "LoginName";
            this.TUsers.Enabled = false;
            this.TUsers.FormSearchText = null;
            this.TUsers.GenerateFelidSearch = false;
            this.TUsers.guid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.TUsers.ID = 0;
            this.TUsers.Location = new System.Drawing.Point(100, 172);
            this.TUsers.Margin = new System.Windows.Forms.Padding(368, 738, 368, 738);
            this.TUsers.More_Choices = false;
            this.TUsers.Name = "TUsers";
            this.TUsers.NForm = null;
            this.TUsers.PkFelid = "GUID";
            this.TUsers.Size = new System.Drawing.Size(173, 25);
            this.TUsers.TabIndex = 28;
            this.TUsers.TableName = "VwSearchGUsers";
            this.TUsers.Value = "";
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Location = new System.Drawing.Point(20, 71);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(35, 18);
            this.LTitle.TabIndex = 21;
            this.LTitle.Text = "Title";
            // 
            // LPrice
            // 
            this.LPrice.AutoSize = true;
            this.LPrice.Location = new System.Drawing.Point(20, 108);
            this.LPrice.Name = "LPrice";
            this.LPrice.Size = new System.Drawing.Size(38, 18);
            this.LPrice.TabIndex = 30;
            this.LPrice.Text = "Price";
            // 
            // LNotes
            // 
            this.LNotes.AutoSize = true;
            this.LNotes.Location = new System.Drawing.Point(20, 139);
            this.LNotes.Name = "LNotes";
            this.LNotes.Size = new System.Drawing.Size(46, 18);
            this.LNotes.TabIndex = 31;
            this.LNotes.Text = "Notes";
            // 
            // LUsers
            // 
            this.LUsers.AutoSize = true;
            this.LUsers.Location = new System.Drawing.Point(20, 172);
            this.LUsers.Name = "LUsers";
            this.LUsers.Size = new System.Drawing.Size(45, 18);
            this.LUsers.TabIndex = 32;
            this.LUsers.Text = "Users";
            // 
            // LDate
            // 
            this.LDate.AutoSize = true;
            this.LDate.Location = new System.Drawing.Point(20, 213);
            this.LDate.Name = "LDate";
            this.LDate.Size = new System.Drawing.Size(39, 18);
            this.LDate.TabIndex = 33;
            this.LDate.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "label1";
            // 
            // FrmCardInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 330);
            this.Name = "FrmCardInvoices";
            this.RepName = "C:\\Users\\Geth\\AppData\\Local\\Microsoft\\VisualStudio\\14.0\\ProjectAssemblies\\hrfm_sh" +
    "f01\\CustRep\\CardPrint\\FrmCardInvoices.mrt";
            this.SearshTableName = "VwSearchRestInvoices";
            this.TableName = "RestInvoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.FrmCardInvoices_Load);
            this.SizeChanged += new System.EventHandler(this.FrmCardInvoices_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.PBack.ResumeLayout(false);
            this.PBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TNotes;
        private System.Windows.Forms.TextBox TPrice;
        private System.Windows.Forms.TextBox TTitle;
        private System.Windows.Forms.Label LUsers;
        private System.Windows.Forms.Label LNotes;
        private System.Windows.Forms.Label LPrice;
        private System.Windows.Forms.Label LTitle;
        private GControls.UI.SearchEdit TUsers;
        private System.Windows.Forms.Label LDate;
        private System.Windows.Forms.Label label1;

    }
}