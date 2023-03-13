namespace GBase.Frm.Base
{
    partial class FrmRepView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            GControls.Class.Tags tags2 = new GControls.Class.Tags();
            this.PTop = new Stimulsoft.Controls.Win.DotNetBar.PanelEx();
            this.PDate = new System.Windows.Forms.Panel();
            this.TToDate = new System.Windows.Forms.Label();
            this.TFromDate = new System.Windows.Forms.Label();
            this.LToDate = new System.Windows.Forms.Label();
            this.LFromDate = new System.Windows.Forms.Label();
            this.BtnClose = new Stimulsoft.Controls.Win.DotNetBar.ButtonX();
            this.BtnDesign = new Stimulsoft.Controls.Win.DotNetBar.ButtonX();
            this.BtnPrint = new Stimulsoft.Controls.Win.DotNetBar.ButtonX();
            this.BtnShow = new Stimulsoft.Controls.Win.DotNetBar.ButtonX();
            this.PFooter = new Stimulsoft.Controls.Win.DotNetBar.PanelEx();
            this.GridFoter = new System.Windows.Forms.DataGridView();
            this.PContent = new Stimulsoft.Controls.Win.DotNetBar.PanelEx();
            this.Grd = new GControls.UI.Grid.GGrid();
            this.dataSet = new System.Data.DataSet();
            this.Rep = new Stimulsoft.Report.StiReport();
            this.BtnRefresh = new Stimulsoft.Controls.Win.DotNetBar.ButtonX();
            this.PBack.SuspendLayout();
            this.PTop.SuspendLayout();
            this.PDate.SuspendLayout();
            this.PFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFoter)).BeginInit();
            this.PContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PBack
            // 
            this.PBack.Controls.Add(this.PContent);
            this.PBack.Controls.Add(this.PFooter);
            this.PBack.Controls.Add(this.PTop);
            this.PBack.Size = new System.Drawing.Size(831, 330);
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
            // PTop
            // 
            this.PTop.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007;
            this.PTop.Controls.Add(this.BtnRefresh);
            this.PTop.Controls.Add(this.PDate);
            this.PTop.Controls.Add(this.BtnClose);
            this.PTop.Controls.Add(this.BtnDesign);
            this.PTop.Controls.Add(this.BtnPrint);
            this.PTop.Controls.Add(this.BtnShow);
            this.PTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PTop.Location = new System.Drawing.Point(0, 0);
            this.PTop.Name = "PTop";
            this.PTop.Size = new System.Drawing.Size(831, 79);
            this.PTop.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PTop.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PTop.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PTop.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PTop.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PTop.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PTop.Style.GradientAngle = 90;
            this.PTop.TabIndex = 0;
            // 
            // PDate
            // 
            this.PDate.Controls.Add(this.TToDate);
            this.PDate.Controls.Add(this.TFromDate);
            this.PDate.Controls.Add(this.LToDate);
            this.PDate.Controls.Add(this.LFromDate);
            this.PDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.PDate.Location = new System.Drawing.Point(596, 0);
            this.PDate.Name = "PDate";
            this.PDate.Size = new System.Drawing.Size(235, 79);
            this.PDate.TabIndex = 19;
            // 
            // TToDate
            // 
            this.TToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TToDate.Location = new System.Drawing.Point(9, 33);
            this.TToDate.Name = "TToDate";
            this.TToDate.Size = new System.Drawing.Size(140, 23);
            this.TToDate.TabIndex = 7;
            this.TToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TFromDate
            // 
            this.TFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TFromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TFromDate.Location = new System.Drawing.Point(9, 11);
            this.TFromDate.Name = "TFromDate";
            this.TFromDate.Size = new System.Drawing.Size(140, 23);
            this.TFromDate.TabIndex = 6;
            this.TFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LToDate
            // 
            this.LToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LToDate.Location = new System.Drawing.Point(148, 33);
            this.LToDate.Name = "LToDate";
            this.LToDate.Size = new System.Drawing.Size(75, 23);
            this.LToDate.TabIndex = 5;
            this.LToDate.Text = "ToDate";
            this.LToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LFromDate
            // 
            this.LFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LFromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LFromDate.Location = new System.Drawing.Point(148, 11);
            this.LFromDate.Name = "LFromDate";
            this.LFromDate.Size = new System.Drawing.Size(75, 23);
            this.LFromDate.TabIndex = 4;
            this.LFromDate.Text = "FromDate";
            this.LFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Is20Button = false;
            this.BtnClose.Location = new System.Drawing.Point(110, 44);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Padding = new System.Windows.Forms.Padding(2);
            this.BtnClose.Size = new System.Drawing.Size(92, 32);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Tag = "0";
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDesign
            // 
            this.BtnDesign.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnDesign.Is20Button = false;
            this.BtnDesign.Location = new System.Drawing.Point(110, 6);
            this.BtnDesign.Name = "BtnDesign";
            this.BtnDesign.Padding = new System.Windows.Forms.Padding(2);
            this.BtnDesign.Size = new System.Drawing.Size(92, 32);
            this.BtnDesign.TabIndex = 18;
            this.BtnDesign.Tag = "2";
            this.BtnDesign.Text = "Design";
            this.BtnDesign.Click += new System.EventHandler(this.Rep_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnPrint.Is20Button = false;
            this.BtnPrint.Location = new System.Drawing.Point(12, 44);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Padding = new System.Windows.Forms.Padding(2);
            this.BtnPrint.Size = new System.Drawing.Size(92, 32);
            this.BtnPrint.TabIndex = 17;
            this.BtnPrint.Tag = "1";
            this.BtnPrint.Text = "Print";
            this.BtnPrint.Click += new System.EventHandler(this.Rep_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnShow.Is20Button = false;
            this.BtnShow.Location = new System.Drawing.Point(12, 6);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Padding = new System.Windows.Forms.Padding(2);
            this.BtnShow.Size = new System.Drawing.Size(92, 32);
            this.BtnShow.TabIndex = 16;
            this.BtnShow.Tag = "0";
            this.BtnShow.Text = "Show";
            this.BtnShow.Click += new System.EventHandler(this.Rep_Click);
            // 
            // PFooter
            // 
            this.PFooter.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Windows7;
            this.PFooter.Controls.Add(this.GridFoter);
            this.PFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PFooter.Location = new System.Drawing.Point(0, 256);
            this.PFooter.Name = "PFooter";
            this.PFooter.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.PFooter.Size = new System.Drawing.Size(831, 74);
            this.PFooter.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PFooter.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PFooter.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PFooter.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PFooter.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PFooter.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PFooter.Style.GradientAngle = 90;
            this.PFooter.TabIndex = 1;
            // 
            // GridFoter
            // 
            this.GridFoter.AllowUserToAddRows = false;
            this.GridFoter.AllowUserToDeleteRows = false;
            this.GridFoter.AllowUserToResizeColumns = false;
            this.GridFoter.AllowUserToResizeRows = false;
            this.GridFoter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridFoter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFoter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridFoter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFoter.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridFoter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridFoter.Location = new System.Drawing.Point(0, 5);
            this.GridFoter.Name = "GridFoter";
            this.GridFoter.ReadOnly = true;
            this.GridFoter.Size = new System.Drawing.Size(831, 64);
            this.GridFoter.TabIndex = 0;
            // 
            // PContent
            // 
            this.PContent.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007;
            this.PContent.Controls.Add(this.Grd);
            this.PContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContent.Location = new System.Drawing.Point(0, 79);
            this.PContent.Name = "PContent";
            this.PContent.Size = new System.Drawing.Size(831, 177);
            this.PContent.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PContent.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PContent.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PContent.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PContent.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PContent.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PContent.Style.GradientAngle = 90;
            this.PContent.TabIndex = 2;
            // 
            // Grd
            // 
            this.Grd.AllowUserToAddRows = false;
            this.Grd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grd.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd.FirstColor = System.Drawing.Color.White;
            this.Grd.Location = new System.Drawing.Point(0, 0);
            this.Grd.Name = "Grd";
            this.Grd.OpenSettingInMenu = true;
            this.Grd.ReadOnly = true;
            this.Grd.Size = new System.Drawing.Size(831, 177);
            this.Grd.TabIndex = 0;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            // 
            // Rep
            // 
            this.Rep.CookieContainer = null;
            this.Rep.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.Rep.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.Rep.ReportAlias = "Report";
            this.Rep.ReportGuid = "43f6089cbce740d6913ad01e38f197f2";
            this.Rep.ReportName = "Report";
            this.Rep.ReportSource = null;
            this.Rep.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.Rep.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.Rep.UseProgressInThread = false;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnRefresh.Is20Button = false;
            this.BtnRefresh.Location = new System.Drawing.Point(208, 6);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Padding = new System.Windows.Forms.Padding(2);
            this.BtnRefresh.Size = new System.Drawing.Size(92, 32);
            this.BtnRefresh.TabIndex = 21;
            this.BtnRefresh.Tag = "2";
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // FrmRepView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(831, 330);
            this.MaximizeBox = true;
            this.Name = "FrmRepView";
            tags2.OrgenalName = "FrmBase";
            tags2.Tag = null;
            this.Tag = tags2;
            this.Text = "RepView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRepView_Load);
            this.PBack.ResumeLayout(false);
            this.PTop.ResumeLayout(false);
            this.PDate.ResumeLayout(false);
            this.PFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridFoter)).EndInit();
            this.PContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Stimulsoft.Controls.Win.DotNetBar.PanelEx PTop;
        Stimulsoft.Controls.Win.DotNetBar.ButtonX BtnDesign;
        Stimulsoft.Controls.Win.DotNetBar.ButtonX BtnPrint;
        Stimulsoft.Controls.Win.DotNetBar.ButtonX BtnShow;
        public Stimulsoft.Controls.Win.DotNetBar.PanelEx PFooter;
        private Stimulsoft.Controls.Win.DotNetBar.PanelEx PContent;
        Stimulsoft.Controls.Win.DotNetBar.ButtonX BtnClose;
        public System.Data.DataSet dataSet;
        public Stimulsoft.Report.StiReport Rep;
        public GControls.UI.Grid.GGrid Grd;
        private System.Windows.Forms.DataGridView GridFoter;
        private System.Windows.Forms.Panel PDate;
        private System.Windows.Forms.Label TToDate;
        private System.Windows.Forms.Label TFromDate;
        private System.Windows.Forms.Label LToDate;
        private System.Windows.Forms.Label LFromDate;
        private Stimulsoft.Controls.Win.DotNetBar.ButtonX BtnRefresh;
    }
}
