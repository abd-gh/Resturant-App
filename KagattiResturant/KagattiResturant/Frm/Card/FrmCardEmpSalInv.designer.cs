namespace KagattiResturant.Frm.Card
{
    partial class FrmCardEmpSalInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardEmpSalInv));
            this.Temployee = new GControls.UI.SearchEdit();
            this.LEmployee = new System.Windows.Forms.Label();
            this.LSalary = new System.Windows.Forms.Label();
            this.TSalary = new System.Windows.Forms.TextBox();
            this.TRemaining = new System.Windows.Forms.TextBox();
            this.LReman = new System.Windows.Forms.Label();
            this.Treceived = new System.Windows.Forms.TextBox();
            this.LReceiv = new System.Windows.Forms.Label();
            this.TDiscount = new System.Windows.Forms.TextBox();
            this.LDis = new System.Windows.Forms.Label();
            this.TPlus = new System.Windows.Forms.TextBox();
            this.Lpuls = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rec = new System.Windows.Forms.TextBox();
            this.dis = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.TextBox();
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
            this.PBack.Controls.Add(this.plus);
            this.PBack.Controls.Add(this.dis);
            this.PBack.Controls.Add(this.rec);
            this.PBack.Controls.Add(this.dateTimePicker1);
            this.PBack.Controls.Add(this.TPlus);
            this.PBack.Controls.Add(this.Lpuls);
            this.PBack.Controls.Add(this.TDiscount);
            this.PBack.Controls.Add(this.LDis);
            this.PBack.Controls.Add(this.Treceived);
            this.PBack.Controls.Add(this.LReceiv);
            this.PBack.Controls.Add(this.TRemaining);
            this.PBack.Controls.Add(this.LReman);
            this.PBack.Controls.Add(this.TSalary);
            this.PBack.Controls.Add(this.LSalary);
            this.PBack.Controls.Add(this.LEmployee);
            this.PBack.Controls.Add(this.Temployee);
            this.PBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PBack.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PBack.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PBack.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PBack.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PBack.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PBack.Style.GradientAngle = 90;
            this.PBack.Paint += new System.Windows.Forms.PaintEventHandler(this.PBack_Paint);
            this.PBack.Controls.SetChildIndex(this.Temployee, 0);
            this.PBack.Controls.SetChildIndex(this.LEmployee, 0);
            this.PBack.Controls.SetChildIndex(this.LSalary, 0);
            this.PBack.Controls.SetChildIndex(this.TSalary, 0);
            this.PBack.Controls.SetChildIndex(this.LReman, 0);
            this.PBack.Controls.SetChildIndex(this.TRemaining, 0);
            this.PBack.Controls.SetChildIndex(this.LReceiv, 0);
            this.PBack.Controls.SetChildIndex(this.Treceived, 0);
            this.PBack.Controls.SetChildIndex(this.LDis, 0);
            this.PBack.Controls.SetChildIndex(this.TDiscount, 0);
            this.PBack.Controls.SetChildIndex(this.Lpuls, 0);
            this.PBack.Controls.SetChildIndex(this.TPlus, 0);
            this.PBack.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.PBack.Controls.SetChildIndex(this.rec, 0);
            this.PBack.Controls.SetChildIndex(this.dis, 0);
            this.PBack.Controls.SetChildIndex(this.plus, 0);
            // 
            // Temployee
            // 
            this.Temployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Temployee.ButtonShow = true;
            this.Temployee.Condition = null;
            this.Temployee.ConnectionString = "";
            this.Temployee.DisplayText = "Name";
            this.Temployee.FormSearchText = null;
            this.Temployee.GenerateFelidSearch = false;
            this.Temployee.guid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.Temployee.ID = 0;
            this.Temployee.Location = new System.Drawing.Point(101, 76);
            this.Temployee.Margin = new System.Windows.Forms.Padding(6540, 19110, 6540, 19110);
            this.Temployee.More_Choices = false;
            this.Temployee.Name = "Temployee";
            this.Temployee.NForm = null;
            this.Temployee.PkFelid = "GUID";
            this.Temployee.Size = new System.Drawing.Size(228, 25);
            this.Temployee.TabIndex = 28;
            this.Temployee.TableName = "VwSearchRestEmployee";
            this.Temployee.Value = "";
            this.Temployee.ONSelected += new System.EventHandler(this.Temployee_ONSelected);
            // 
            // LEmployee
            // 
            this.LEmployee.AutoSize = true;
            this.LEmployee.Location = new System.Drawing.Point(20, 76);
            this.LEmployee.Name = "LEmployee";
            this.LEmployee.Size = new System.Drawing.Size(71, 18);
            this.LEmployee.TabIndex = 29;
            this.LEmployee.Text = "Employee";
            // 
            // LSalary
            // 
            this.LSalary.AutoSize = true;
            this.LSalary.Location = new System.Drawing.Point(20, 113);
            this.LSalary.Name = "LSalary";
            this.LSalary.Size = new System.Drawing.Size(47, 18);
            this.LSalary.TabIndex = 30;
            this.LSalary.Text = "Salary";
            // 
            // TSalary
            // 
            this.TSalary.Location = new System.Drawing.Point(100, 110);
            this.TSalary.Name = "TSalary";
            this.TSalary.Size = new System.Drawing.Size(229, 25);
            this.TSalary.TabIndex = 31;
            // 
            // TRemaining
            // 
            this.TRemaining.Location = new System.Drawing.Point(100, 141);
            this.TRemaining.Name = "TRemaining";
            this.TRemaining.Size = new System.Drawing.Size(229, 25);
            this.TRemaining.TabIndex = 33;
            // 
            // LReman
            // 
            this.LReman.AutoSize = true;
            this.LReman.Location = new System.Drawing.Point(20, 144);
            this.LReman.Name = "LReman";
            this.LReman.Size = new System.Drawing.Size(74, 18);
            this.LReman.TabIndex = 32;
            this.LReman.Text = "Remaining";
            this.LReman.Click += new System.EventHandler(this.label2_Click);
            // 
            // Treceived
            // 
            this.Treceived.Location = new System.Drawing.Point(217, 172);
            this.Treceived.Name = "Treceived";
            this.Treceived.ReadOnly = true;
            this.Treceived.Size = new System.Drawing.Size(112, 25);
            this.Treceived.TabIndex = 35;
            // 
            // LReceiv
            // 
            this.LReceiv.AutoSize = true;
            this.LReceiv.Location = new System.Drawing.Point(20, 175);
            this.LReceiv.Name = "LReceiv";
            this.LReceiv.Size = new System.Drawing.Size(62, 18);
            this.LReceiv.TabIndex = 34;
            this.LReceiv.Text = "received";
            // 
            // TDiscount
            // 
            this.TDiscount.Location = new System.Drawing.Point(217, 203);
            this.TDiscount.Name = "TDiscount";
            this.TDiscount.ReadOnly = true;
            this.TDiscount.Size = new System.Drawing.Size(112, 25);
            this.TDiscount.TabIndex = 37;
            // 
            // LDis
            // 
            this.LDis.AutoSize = true;
            this.LDis.Location = new System.Drawing.Point(20, 206);
            this.LDis.Name = "LDis";
            this.LDis.Size = new System.Drawing.Size(63, 18);
            this.LDis.TabIndex = 36;
            this.LDis.Text = "Discount";
            // 
            // TPlus
            // 
            this.TPlus.Location = new System.Drawing.Point(217, 234);
            this.TPlus.Name = "TPlus";
            this.TPlus.ReadOnly = true;
            this.TPlus.Size = new System.Drawing.Size(112, 25);
            this.TPlus.TabIndex = 39;
            // 
            // Lpuls
            // 
            this.Lpuls.AutoSize = true;
            this.Lpuls.Location = new System.Drawing.Point(20, 237);
            this.Lpuls.Name = "Lpuls";
            this.Lpuls.Size = new System.Drawing.Size(33, 18);
            this.Lpuls.TabIndex = 38;
            this.Lpuls.Text = "Plus";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 266);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 25);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // rec
            // 
            this.rec.Location = new System.Drawing.Point(100, 172);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(111, 25);
            this.rec.TabIndex = 41;
            this.rec.Text = "0";
            this.rec.TextChanged += new System.EventHandler(this.rec_TextChanged);
            // 
            // dis
            // 
            this.dis.Location = new System.Drawing.Point(101, 203);
            this.dis.Name = "dis";
            this.dis.Size = new System.Drawing.Size(111, 25);
            this.dis.TabIndex = 42;
            this.dis.Text = "0";
            this.dis.TextChanged += new System.EventHandler(this.dis_TextChanged);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(101, 234);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(111, 25);
            this.plus.TabIndex = 43;
            this.plus.Text = "0";
            this.plus.TextChanged += new System.EventHandler(this.plus_TextChanged);
            // 
            // FrmCardEmpSalInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 330);
            this.Name = "FrmCardEmpSalInv";
            this.RepName = "C:\\Users\\Geth\\AppData\\Local\\Microsoft\\VisualStudio\\14.0\\ProjectAssemblies\\hrfm_sh" +
    "f01\\CustRep\\CardPrint\\FrmCardEmpSalInv.mrt";
            this.SearshTableName = "VwSearchRestEmpSalInv";
            this.TableName = "RestEmpSalInv";
            this.Text = "Employee Invoces";
            this.Load += new System.EventHandler(this.FrmCardEmpSalInv_Load);
            this.SizeChanged += new System.EventHandler(this.FrmCardEmpSalInv_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.PBack.ResumeLayout(false);
            this.PBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LEmployee;
        private GControls.UI.SearchEdit Temployee;
        private System.Windows.Forms.TextBox TSalary;
        private System.Windows.Forms.Label LSalary;
        private System.Windows.Forms.TextBox TPlus;
        private System.Windows.Forms.Label Lpuls;
        private System.Windows.Forms.TextBox TDiscount;
        private System.Windows.Forms.Label LDis;
        private System.Windows.Forms.TextBox Treceived;
        private System.Windows.Forms.Label LReceiv;
        private System.Windows.Forms.TextBox TRemaining;
        private System.Windows.Forms.Label LReman;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox plus;
        private System.Windows.Forms.TextBox dis;
        private System.Windows.Forms.TextBox rec;


    }
}