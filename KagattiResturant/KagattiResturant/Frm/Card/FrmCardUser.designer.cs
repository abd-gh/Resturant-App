//using System;

namespace KagattiResturant.Frm.Card
{
    partial class FrmCardUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TBase = new System.Windows.Forms.TabPage();
            this.SEditParentUser = new GControls.UI.SearchEdit();
            this.LParentUser = new System.Windows.Forms.Label();
            this.TCard = new System.Windows.Forms.TabPage();
            this.GridCard = new GControls.UI.Grid.GGrid();
            this.TRep = new System.Windows.Forms.TabPage();
            this.GridRep = new GControls.UI.Grid.GGrid();
            this.TCommand = new System.Windows.Forms.TabPage();
            this.GridCommand = new GControls.UI.Grid.GGrid();
            this.PBaseTop = new System.Windows.Forms.Panel();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.LPassword = new System.Windows.Forms.Label();
            this.ChkISAdmin = new System.Windows.Forms.CheckBox();
            this.TLoginName = new System.Windows.Forms.TextBox();
            this.LLoginName = new System.Windows.Forms.Label();
            this.dataSetCard = new System.Data.DataSet();
            this.datasetRep = new System.Data.DataSet();
            this.datasetCommand = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.PBack.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TBase.SuspendLayout();
            this.TCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCard)).BeginInit();
            this.TRep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRep)).BeginInit();
            this.TCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCommand)).BeginInit();
            this.PBaseTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetCommand)).BeginInit();
            this.SuspendLayout();
            // 
            // TNumber
            // 
            this.TNumber.Margin = new System.Windows.Forms.Padding(4);
            // 
            // BtnDesign
            // 
            this.BtnDesign.Image = ((System.Drawing.Image)(resources.GetObject("BtnDesign.Image")));
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(7, 1079);
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
            this.PBack.Controls.Add(this.tabControl1);
            this.PBack.Controls.Add(this.PBaseTop);
            this.PBack.Size = new System.Drawing.Size(596, 395);
            this.PBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PBack.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground;
            this.PBack.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PBack.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            this.PBack.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder;
            this.PBack.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText;
            this.PBack.Style.GradientAngle = 90;
            this.PBack.Controls.SetChildIndex(this.PBaseTop, 0);
            this.PBack.Controls.SetChildIndex(this.tabControl1, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TBase);
            this.tabControl1.Controls.Add(this.TCard);
            this.tabControl1.Controls.Add(this.TRep);
            this.tabControl1.Controls.Add(this.TCommand);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 148);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 247);
            this.tabControl1.TabIndex = 6;
            // 
            // TBase
            // 
            this.TBase.BackColor = System.Drawing.SystemColors.Control;
            this.TBase.Controls.Add(this.SEditParentUser);
            this.TBase.Controls.Add(this.LParentUser);
            this.TBase.Location = new System.Drawing.Point(4, 27);
            this.TBase.Name = "TBase";
            this.TBase.Padding = new System.Windows.Forms.Padding(3);
            this.TBase.Size = new System.Drawing.Size(459, 216);
            this.TBase.TabIndex = 0;
            this.TBase.Text = "Base Info";
            this.TBase.Click += new System.EventHandler(this.TBase_Click);
            // 
            // SEditParentUser
            // 
            this.SEditParentUser.ButtonShow = false;
            this.SEditParentUser.Condition = null;
            this.SEditParentUser.ConnectionString = "";
            this.SEditParentUser.DisplayText = "LoginName";
            this.SEditParentUser.FormSearchText = null;
            this.SEditParentUser.GenerateFelidSearch = false;
            this.SEditParentUser.guid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.SEditParentUser.ID = 0;
            this.SEditParentUser.Location = new System.Drawing.Point(98, 9);
            this.SEditParentUser.Margin = new System.Windows.Forms.Padding(4);
            this.SEditParentUser.More_Choices = false;
            this.SEditParentUser.Name = "SEditParentUser";
            this.SEditParentUser.NForm = null;
            this.SEditParentUser.PkFelid = "GUID";
            this.SEditParentUser.Size = new System.Drawing.Size(354, 25);
            this.SEditParentUser.TabIndex = 7;
            this.SEditParentUser.TableName = "VwSearchRestUsers";
            this.SEditParentUser.Value = "";
            // 
            // LParentUser
            // 
            this.LParentUser.AutoSize = true;
            this.LParentUser.Location = new System.Drawing.Point(6, 12);
            this.LParentUser.Name = "LParentUser";
            this.LParentUser.Size = new System.Drawing.Size(0, 18);
            this.LParentUser.TabIndex = 6;
            // 
            // TCard
            // 
            this.TCard.BackColor = System.Drawing.SystemColors.Control;
            this.TCard.Controls.Add(this.GridCard);
            this.TCard.Location = new System.Drawing.Point(4, 27);
            this.TCard.Name = "TCard";
            this.TCard.Padding = new System.Windows.Forms.Padding(3);
            this.TCard.Size = new System.Drawing.Size(339, 151);
            this.TCard.TabIndex = 1;
            this.TCard.Text = "Card Security";
            // 
            // GridCard
            // 
            this.GridCard.AllowUserToAddRows = false;
            this.GridCard.AllowUserToDeleteRows = false;
            this.GridCard.AllowUserToResizeColumns = false;
            this.GridCard.AllowUserToResizeRows = false;
            this.GridCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCard.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCard.FirstColor = System.Drawing.Color.White;
            this.GridCard.Location = new System.Drawing.Point(3, 3);
            this.GridCard.MultiSelect = false;
            this.GridCard.Name = "GridCard";
            this.GridCard.OpenSettingInMenu = true;
            this.GridCard.RCount = -1;
            this.GridCard.SearshText = null;
            this.GridCard.SecoundColor = System.Drawing.Color.Gray;
            this.GridCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridCard.Size = new System.Drawing.Size(333, 145);
            this.GridCard.TabIndex = 4;
            this.GridCard.Tag = "Card";
            this.GridCard.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_CellMouseDown);
            // 
            // TRep
            // 
            this.TRep.BackColor = System.Drawing.SystemColors.Control;
            this.TRep.Controls.Add(this.GridRep);
            this.TRep.Location = new System.Drawing.Point(4, 27);
            this.TRep.Name = "TRep";
            this.TRep.Size = new System.Drawing.Size(339, 151);
            this.TRep.TabIndex = 2;
            this.TRep.Text = "Rep Security";
            // 
            // GridRep
            // 
            this.GridRep.AllowUserToAddRows = false;
            this.GridRep.AllowUserToDeleteRows = false;
            this.GridRep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridRep.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridRep.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridRep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridRep.FirstColor = System.Drawing.Color.White;
            this.GridRep.Location = new System.Drawing.Point(0, 0);
            this.GridRep.MultiSelect = false;
            this.GridRep.Name = "GridRep";
            this.GridRep.OpenSettingInMenu = true;
            this.GridRep.RCount = -1;
            this.GridRep.SearshText = null;
            this.GridRep.SecoundColor = System.Drawing.Color.Gray;
            this.GridRep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridRep.Size = new System.Drawing.Size(339, 151);
            this.GridRep.TabIndex = 5;
            this.GridRep.Tag = "Rep";
            this.GridRep.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_CellMouseDown);
            // 
            // TCommand
            // 
            this.TCommand.BackColor = System.Drawing.SystemColors.Control;
            this.TCommand.Controls.Add(this.GridCommand);
            this.TCommand.Location = new System.Drawing.Point(4, 27);
            this.TCommand.Name = "TCommand";
            this.TCommand.Size = new System.Drawing.Size(339, 151);
            this.TCommand.TabIndex = 3;
            this.TCommand.Text = "Command Security";
            // 
            // GridCommand
            // 
            this.GridCommand.AllowUserToAddRows = false;
            this.GridCommand.AllowUserToDeleteRows = false;
            this.GridCommand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCommand.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridCommand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCommand.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCommand.FirstColor = System.Drawing.Color.White;
            this.GridCommand.Location = new System.Drawing.Point(0, 0);
            this.GridCommand.MultiSelect = false;
            this.GridCommand.Name = "GridCommand";
            this.GridCommand.OpenSettingInMenu = true;
            this.GridCommand.RCount = -1;
            this.GridCommand.SearshText = null;
            this.GridCommand.SecoundColor = System.Drawing.Color.Gray;
            this.GridCommand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridCommand.Size = new System.Drawing.Size(339, 151);
            this.GridCommand.TabIndex = 6;
            this.GridCommand.Tag = "Command";
            this.GridCommand.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_CellMouseDown);
            // 
            // PBaseTop
            // 
            this.PBaseTop.Controls.Add(this.TPassword);
            this.PBaseTop.Controls.Add(this.LPassword);
            this.PBaseTop.Controls.Add(this.ChkISAdmin);
            this.PBaseTop.Controls.Add(this.TLoginName);
            this.PBaseTop.Controls.Add(this.LLoginName);
            this.PBaseTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBaseTop.Location = new System.Drawing.Point(0, 44);
            this.PBaseTop.Name = "PBaseTop";
            this.PBaseTop.Size = new System.Drawing.Size(467, 104);
            this.PBaseTop.TabIndex = 5;
            this.PBaseTop.Paint += new System.Windows.Forms.PaintEventHandler(this.PBaseTop_Paint);
            // 
            // TPassword
            // 
            this.TPassword.Location = new System.Drawing.Point(122, 49);
            this.TPassword.Name = "TPassword";
            this.TPassword.PasswordChar = '*';
            this.TPassword.Size = new System.Drawing.Size(245, 25);
            this.TPassword.TabIndex = 10;
            this.TPassword.TextChanged += new System.EventHandler(this.TPassword_TextChanged);
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(8, 52);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(69, 18);
            this.LPassword.TabIndex = 9;
            this.LPassword.Text = "Password";
            // 
            // ChkISAdmin
            // 
            this.ChkISAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkISAdmin.AutoSize = true;
            this.ChkISAdmin.Location = new System.Drawing.Point(375, 14);
            this.ChkISAdmin.Name = "ChkISAdmin";
            this.ChkISAdmin.Size = new System.Drawing.Size(86, 22);
            this.ChkISAdmin.TabIndex = 8;
            this.ChkISAdmin.Text = "IS Admin";
            this.ChkISAdmin.UseVisualStyleBackColor = true;
            // 
            // TLoginName
            // 
            this.TLoginName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLoginName.Location = new System.Drawing.Point(122, 12);
            this.TLoginName.Name = "TLoginName";
            this.TLoginName.Size = new System.Drawing.Size(245, 25);
            this.TLoginName.TabIndex = 6;
            // 
            // LLoginName
            // 
            this.LLoginName.AutoSize = true;
            this.LLoginName.Location = new System.Drawing.Point(6, 15);
            this.LLoginName.Name = "LLoginName";
            this.LLoginName.Size = new System.Drawing.Size(80, 18);
            this.LLoginName.TabIndex = 5;
            this.LLoginName.Text = "LoginName";
            // 
            // dataSetCard
            // 
            this.dataSetCard.DataSetName = "NewDataSet";
            // 
            // datasetRep
            // 
            this.datasetRep.DataSetName = "NewDataSet";
            // 
            // datasetCommand
            // 
            this.datasetCommand.DataSetName = "NewDataSet";
            // 
            // FrmCardUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 395);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmCardUser";
            this.RepName = "C:\\Users\\Geth\\AppData\\Local\\Microsoft\\VisualStudio\\14.0\\ProjectAssemblies\\aoidub4" +
    "u01\\CustRep\\CardPrint\\FrmCard.mrt";
            this.SearshTableName = "VwSearchGUsers";
            this.TableName = "GUsers";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.FrmGUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.PBack.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TBase.ResumeLayout(false);
            this.TBase.PerformLayout();
            this.TCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCard)).EndInit();
            this.TRep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridRep)).EndInit();
            this.TCommand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCommand)).EndInit();
            this.PBaseTop.ResumeLayout(false);
            this.PBaseTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetCommand)).EndInit();
            this.ResumeLayout(false);

        }

        //internal void Show()
        //{
        //    throw new NotImplementedException();
        //   // InitializeComponent();
        //}

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TCard;
        public GControls.UI.Grid.GGrid GridCard;
        private System.Windows.Forms.TabPage TRep;
        public GControls.UI.Grid.GGrid GridRep;
        private System.Windows.Forms.TabPage TCommand;
        public GControls.UI.Grid.GGrid GridCommand;
        private System.Windows.Forms.Panel PBaseTop;
        private System.Windows.Forms.TextBox TLoginName;
        private System.Windows.Forms.Label LLoginName;
        public System.Data.DataSet dataSetCard;
        public System.Data.DataSet datasetRep;
        public System.Data.DataSet datasetCommand;
        private System.Windows.Forms.CheckBox ChkISAdmin;
        internal string Name;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.TabPage TBase;
        private GControls.UI.SearchEdit SEditParentUser;
        private System.Windows.Forms.Label LParentUser;
    }
}