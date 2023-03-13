namespace KagattiResturant.Frm.Card
{
    partial class FrmRepRestItem
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
            this.TItem = new GControls.UI.SearchEdit();
            this.TToDate = new System.Windows.Forms.DateTimePicker();
            this.TFromeDate = new System.Windows.Forms.DateTimePicker();
            this.LItem = new System.Windows.Forms.Label();
            this.LFromDate = new System.Windows.Forms.Label();
            this.LToDate = new System.Windows.Forms.Label();
            this.Pcontent.SuspendLayout();
            this.PBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListField
            // 
            this.ListField.SelectedIndexChanged += new System.EventHandler(this.ListField_SelectedIndexChanged);
            this.ListField.SelectedValueChanged += new System.EventHandler(this.ListField_SelectedIndexChanged);
            // 
            // Pcontent
            // 
            this.Pcontent.Controls.Add(this.LToDate);
            this.Pcontent.Controls.Add(this.LFromDate);
            this.Pcontent.Controls.Add(this.LItem);
            this.Pcontent.Controls.Add(this.TFromeDate);
            this.Pcontent.Controls.Add(this.TToDate);
            this.Pcontent.Controls.Add(this.TItem);
            this.Pcontent.Size = new System.Drawing.Size(461, 318);
            this.Pcontent.Paint += new System.Windows.Forms.PaintEventHandler(this.Pcontent_Paint);
            // 
            // PBack
            // 
            this.PBack.Size = new System.Drawing.Size(461, 318);
            this.PBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PBack.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PBack.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PBack.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PBack.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PBack.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PBack.Style.GradientAngle = 90;
            // 
            // TItem
            // 
            this.TItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TItem.ButtonShow = true;
            this.TItem.Condition = null;
            this.TItem.ConnectionString = "";
            this.TItem.DisplayText = "Name";
            this.TItem.FormSearchText = null;
            this.TItem.GenerateFelidSearch = false;
            this.TItem.guid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.TItem.ID = 0;
            this.TItem.Location = new System.Drawing.Point(193, 30);
            this.TItem.Margin = new System.Windows.Forms.Padding(6518151, 47115090, 6518151, 47115090);
            this.TItem.More_Choices = false;
            this.TItem.Name = "TItem";
            this.TItem.NForm = null;
            this.TItem.PkFelid = "GUID";
            this.TItem.Size = new System.Drawing.Size(259, 25);
            this.TItem.TabIndex = 25;
            this.TItem.TableName = "VwSearchRestItem";
            this.TItem.Value = "";
            this.TItem.Load += new System.EventHandler(this.TCustomerName_Load);
            // 
            // TToDate
            // 
            this.TToDate.CustomFormat = "";
            this.TToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TToDate.Location = new System.Drawing.Point(193, 127);
            this.TToDate.Name = "TToDate";
            this.TToDate.Size = new System.Drawing.Size(259, 25);
            this.TToDate.TabIndex = 83;
            // 
            // TFromeDate
            // 
            this.TFromeDate.CustomFormat = "";
            this.TFromeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TFromeDate.Location = new System.Drawing.Point(193, 79);
            this.TFromeDate.Name = "TFromeDate";
            this.TFromeDate.Size = new System.Drawing.Size(259, 25);
            this.TFromeDate.TabIndex = 84;
            // 
            // LItem
            // 
            this.LItem.AutoSize = true;
            this.LItem.Location = new System.Drawing.Point(35, 37);
            this.LItem.Name = "LItem";
            this.LItem.Size = new System.Drawing.Size(40, 18);
            this.LItem.TabIndex = 85;
            this.LItem.Text = "Item";
            // 
            // LFromDate
            // 
            this.LFromDate.AutoSize = true;
            this.LFromDate.Location = new System.Drawing.Point(35, 86);
            this.LFromDate.Name = "LFromDate";
            this.LFromDate.Size = new System.Drawing.Size(78, 18);
            this.LFromDate.TabIndex = 86;
            this.LFromDate.Text = "From Date";
            this.LFromDate.Click += new System.EventHandler(this.LFromDate_Click);
            // 
            // LToDate
            // 
            this.LToDate.AutoSize = true;
            this.LToDate.Location = new System.Drawing.Point(35, 132);
            this.LToDate.Name = "LToDate";
            this.LToDate.Size = new System.Drawing.Size(62, 18);
            this.LToDate.TabIndex = 87;
            this.LToDate.Text = "To Date";
            // 
            // FrmRepRestItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 318);
            this.Name = "FrmRepRestItem";
            this.Text = "Agent Report";
            this.Load += new System.EventHandler(this.FrmRepRestItem_Load);
            this.SizeChanged += new System.EventHandler(this.FrmBaseRep_SizeChanged);
            this.Pcontent.ResumeLayout(false);
            this.Pcontent.PerformLayout();
            this.PBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GControls.UI.SearchEdit TItem;
        private System.Windows.Forms.Label LToDate;
        private System.Windows.Forms.Label LFromDate;
        private System.Windows.Forms.Label LItem;
        private System.Windows.Forms.DateTimePicker TFromeDate;
        private System.Windows.Forms.DateTimePicker TToDate;
    }
}