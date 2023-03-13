namespace KagattiResturant.Frm.Card
{
    partial class FrmRepRestEmp
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
            this.TToDate = new System.Windows.Forms.DateTimePicker();
            this.TFromeDate = new System.Windows.Forms.DateTimePicker();
            this.LFromDate = new System.Windows.Forms.Label();
            this.LToDate = new System.Windows.Forms.Label();
            this.LEmployee = new System.Windows.Forms.Label();
            this.TUser = new GControls.UI.SearchEdit();
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
            this.Pcontent.Controls.Add(this.LEmployee);
            this.Pcontent.Controls.Add(this.TUser);
            this.Pcontent.Controls.Add(this.LToDate);
            this.Pcontent.Controls.Add(this.LFromDate);
            this.Pcontent.Controls.Add(this.TFromeDate);
            this.Pcontent.Controls.Add(this.TToDate);
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
            // LEmployee
            // 
            this.LEmployee.AutoSize = true;
            this.LEmployee.Location = new System.Drawing.Point(35, 39);
            this.LEmployee.Name = "LEmployee";
            this.LEmployee.Size = new System.Drawing.Size(71, 18);
            this.LEmployee.TabIndex = 89;
            this.LEmployee.Text = "Employee";
            // 
            // TUser
            // 
            this.TUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TUser.ButtonShow = true;
            this.TUser.Condition = null;
            this.TUser.ConnectionString = "";
            this.TUser.DisplayText = "Name";
            this.TUser.FormSearchText = null;
            this.TUser.GenerateFelidSearch = false;
            this.TUser.guid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.TUser.ID = 0;
            this.TUser.Location = new System.Drawing.Point(193, 39);
            this.TUser.Margin = new System.Windows.Forms.Padding(2069, 5199, 2069, 5199);
            this.TUser.More_Choices = false;
            this.TUser.Name = "TUser";
            this.TUser.NForm = null;
            this.TUser.PkFelid = "GUID";
            this.TUser.Size = new System.Drawing.Size(259, 25);
            this.TUser.TabIndex = 88;
            this.TUser.TableName = "VwSearchRestEmployee";
            this.TUser.Value = "";
            // 
            // FrmRepRestEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 318);
            this.Name = "FrmRepRestEmp";
            this.Text = "Agent Report";
            this.Load += new System.EventHandler(this.FrmRepRestEmp_Load);
            this.SizeChanged += new System.EventHandler(this.FrmBaseRep_SizeChanged);
            this.Pcontent.ResumeLayout(false);
            this.Pcontent.PerformLayout();
            this.PBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LToDate;
        private System.Windows.Forms.Label LFromDate;
        private System.Windows.Forms.DateTimePicker TFromeDate;
        private System.Windows.Forms.DateTimePicker TToDate;
        private System.Windows.Forms.Label LEmployee;
        private GControls.UI.SearchEdit TUser;
    }
}