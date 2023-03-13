namespace GBase.Frm
{
    partial class FrmAct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAct));
            GControls.Class.Tags tags1 = new GControls.Class.Tags();
            this.PBack = new Stimulsoft.Controls.Win.DotNetBar.PanelEx();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnActiveWeb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LHardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBack
            // 
            this.PBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.PBack.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007;
            this.PBack.Controls.Add(this.label3);
            this.PBack.Controls.Add(this.button2);
            this.PBack.Controls.Add(this.BtnActiveWeb);
            this.PBack.Controls.Add(this.label2);
            this.PBack.Controls.Add(this.LHardNumber);
            this.PBack.Controls.Add(this.label1);
            this.PBack.Controls.Add(this.textBox1);
            this.PBack.Controls.Add(this.BtnSave);
            resources.ApplyResources(this.PBack, "PBack");
            this.PBack.Name = "PBack";
            this.PBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PBack.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PBack.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PBack.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PBack.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PBack.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PBack.Style.GradientAngle = 90;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnActiveWeb
            // 
            resources.ApplyResources(this.BtnActiveWeb, "BtnActiveWeb");
            this.BtnActiveWeb.Name = "BtnActiveWeb";
            this.BtnActiveWeb.UseVisualStyleBackColor = true;
            this.BtnActiveWeb.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // LHardNumber
            // 
            resources.ApplyResources(this.LHardNumber, "LHardNumber");
            this.LHardNumber.Name = "LHardNumber";
            this.LHardNumber.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // BtnSave
            // 
            resources.ApplyResources(this.BtnSave, "BtnSave");
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmAct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FrmAct";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            tags1.OrgenalName = "FrmBase";
            tags1.Tag = null;
            this.Tag = tags1;
            this.TopMost = true;
            this.MinimumSizeChanged += new System.EventHandler(this.FrmAct_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.FrmAct_Load);
            this.PBack.ResumeLayout(false);
            this.PBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox LHardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnActiveWeb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        protected Stimulsoft.Controls.Win.DotNetBar.PanelEx PBack;
    }
}