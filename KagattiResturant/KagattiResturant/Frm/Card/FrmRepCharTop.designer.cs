namespace KagattiResturant.Frm.Card
{
    partial class FrmRepCharTop
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepCharTop));
            GControls.Class.Tags tags1 = new GControls.Class.Tags();
            this.PBack = new Stimulsoft.Controls.Win.DotNetBar.PanelEx();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LFromDate = new System.Windows.Forms.Label();
            this.LToDate = new System.Windows.Forms.Label();
            this.TFromeDate = new System.Windows.Forms.DateTimePicker();
            this.TToDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBack
            // 
            this.PBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.PBack.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007;
            this.PBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBack.Location = new System.Drawing.Point(0, 0);
            this.PBack.Name = "PBack";
            this.PBack.Size = new System.Drawing.Size(676, 302);
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(239, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "total";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(434, 296);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 302);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.LFromDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LToDate, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TFromeDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TToDate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(236, 302);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // LFromDate
            // 
            this.LFromDate.AutoSize = true;
            this.LFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LFromDate.Location = new System.Drawing.Point(3, 75);
            this.LFromDate.Name = "LFromDate";
            this.LFromDate.Size = new System.Drawing.Size(64, 45);
            this.LFromDate.TabIndex = 87;
            this.LFromDate.Text = "From Date";
            // 
            // LToDate
            // 
            this.LToDate.AutoSize = true;
            this.LToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LToDate.Location = new System.Drawing.Point(3, 120);
            this.LToDate.Name = "LToDate";
            this.LToDate.Size = new System.Drawing.Size(64, 45);
            this.LToDate.TabIndex = 88;
            this.LToDate.Text = "To Date";
            // 
            // TFromeDate
            // 
            this.TFromeDate.CustomFormat = "";
            this.TFromeDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TFromeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TFromeDate.Location = new System.Drawing.Point(73, 78);
            this.TFromeDate.Name = "TFromeDate";
            this.TFromeDate.Size = new System.Drawing.Size(160, 25);
            this.TFromeDate.TabIndex = 89;
            // 
            // TToDate
            // 
            this.TToDate.CustomFormat = "";
            this.TToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TToDate.Location = new System.Drawing.Point(73, 123);
            this.TToDate.Name = "TToDate";
            this.TToDate.Size = new System.Drawing.Size(160, 25);
            this.TToDate.TabIndex = 90;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 77);
            this.button1.TabIndex = 91;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRepCharTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 302);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PBack);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRepCharTop";
            tags1.OrgenalName = "FBase";
            tags1.Tag = null;
            this.Tag = tags1;
            this.Text = "FrmRepCharTop";
            this.MinimumSizeChanged += new System.EventHandler(this.FrmRepCharTop_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.FrmRepCharTop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Stimulsoft.Controls.Win.DotNetBar.PanelEx PBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LFromDate;
        private System.Windows.Forms.Label LToDate;
        private System.Windows.Forms.DateTimePicker TFromeDate;
        private System.Windows.Forms.DateTimePicker TToDate;
        private System.Windows.Forms.Button button1;

    }
}