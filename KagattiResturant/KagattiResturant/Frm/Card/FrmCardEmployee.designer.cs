namespace KagattiResturant.Frm.Card
{
    partial class FrmCardEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardEmployee));
            this.LName = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.TPhone = new System.Windows.Forms.TextBox();
            this.LPhone = new System.Windows.Forms.Label();
            this.TSalary = new System.Windows.Forms.TextBox();
            this.LSalary = new System.Windows.Forms.Label();
            this.TNotes = new System.Windows.Forms.TextBox();
            this.LNotes = new System.Windows.Forms.Label();
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
            this.PBack.Controls.Add(this.TNotes);
            this.PBack.Controls.Add(this.LNotes);
            this.PBack.Controls.Add(this.TSalary);
            this.PBack.Controls.Add(this.LSalary);
            this.PBack.Controls.Add(this.TPhone);
            this.PBack.Controls.Add(this.LPhone);
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
            this.PBack.Controls.SetChildIndex(this.LPhone, 0);
            this.PBack.Controls.SetChildIndex(this.TPhone, 0);
            this.PBack.Controls.SetChildIndex(this.LSalary, 0);
            this.PBack.Controls.SetChildIndex(this.TSalary, 0);
            this.PBack.Controls.SetChildIndex(this.LNotes, 0);
            this.PBack.Controls.SetChildIndex(this.TNotes, 0);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(11, 56);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(52, 18);
            this.LName.TabIndex = 5;
            this.LName.Text = "Name ";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(69, 53);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(261, 25);
            this.TName.TabIndex = 6;
            // 
            // TPhone
            // 
            this.TPhone.Location = new System.Drawing.Point(69, 90);
            this.TPhone.Name = "TPhone";
            this.TPhone.Size = new System.Drawing.Size(261, 25);
            this.TPhone.TabIndex = 8;
            // 
            // LPhone
            // 
            this.LPhone.AutoSize = true;
            this.LPhone.Location = new System.Drawing.Point(11, 93);
            this.LPhone.Name = "LPhone";
            this.LPhone.Size = new System.Drawing.Size(48, 18);
            this.LPhone.TabIndex = 7;
            this.LPhone.Text = "Phone";
            // 
            // TSalary
            // 
            this.TSalary.Location = new System.Drawing.Point(69, 127);
            this.TSalary.Name = "TSalary";
            this.TSalary.Size = new System.Drawing.Size(261, 25);
            this.TSalary.TabIndex = 10;
            this.TSalary.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LSalary
            // 
            this.LSalary.AutoSize = true;
            this.LSalary.Location = new System.Drawing.Point(11, 130);
            this.LSalary.Name = "LSalary";
            this.LSalary.Size = new System.Drawing.Size(47, 18);
            this.LSalary.TabIndex = 9;
            this.LSalary.Text = "Salary";
            this.LSalary.Click += new System.EventHandler(this.label2_Click);
            // 
            // TNotes
            // 
            this.TNotes.Location = new System.Drawing.Point(69, 164);
            this.TNotes.Multiline = true;
            this.TNotes.Name = "TNotes";
            this.TNotes.Size = new System.Drawing.Size(261, 68);
            this.TNotes.TabIndex = 12;
            // 
            // LNotes
            // 
            this.LNotes.AutoSize = true;
            this.LNotes.Location = new System.Drawing.Point(11, 167);
            this.LNotes.Name = "LNotes";
            this.LNotes.Size = new System.Drawing.Size(46, 18);
            this.LNotes.TabIndex = 11;
            this.LNotes.Text = "Notes";
            // 
            // FrmCardEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 330);
            this.Name = "FrmCardEmployee";
            this.RepName = "C:\\Users\\Geth\\AppData\\Local\\Microsoft\\VisualStudio\\14.0\\ProjectAssemblies\\hrfm_sh" +
    "f01\\CustRep\\CardPrint\\FrmCardEmployee.mrt";
            this.SearshTableName = "VwSearchRestEmployee";
            this.TableName = "RestEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.FrmCardEmployee_Load);
            this.SizeChanged += new System.EventHandler(this.FrmCardEmployee_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.PBack.ResumeLayout(false);
            this.PBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox TNotes;
        private System.Windows.Forms.Label LNotes;
        private System.Windows.Forms.TextBox TSalary;
        private System.Windows.Forms.Label LSalary;
        private System.Windows.Forms.TextBox TPhone;
        private System.Windows.Forms.Label LPhone;

    }
}