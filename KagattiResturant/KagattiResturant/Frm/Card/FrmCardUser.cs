using GControls.UI.Grid;
using GProjects.Class;
using GProjects.Frm;
using KagattiResturant.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace KagattiResturant.Frm.Card
{
    public partial class FrmCardUser : GBase.FrmCard
    {
        private GUsers TUser;
        public FrmCardUser()
        {
            InitializeComponent();
        }
        public override void intSecurity()
        {
            if (CSamaHotel.ListGSecurity == null)
                return;
            if (Name == "FrmCard")
                return;
            BtnNew.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "New");
            BtnSave.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "Save");
            BtnDel.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "Del");
            BtnDesign.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "Design Rep");
            BtnShow.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "Show Rep");
            BtnPrint.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "Print Rep");
            BtnSearch.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "Search");
        }
        public override void IntLanguage()
        {
            string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (lng == "Ar")
            {
                ProjBase.CurrentLanguage.GetValue(LLoginName);
                ProjBase.CurrentLanguage.GetValue(ChkISAdmin);
                ProjBase.CurrentLanguage.GetValue(LParentUser);
                ProjBase.CurrentLanguage.GetValue(LPassword);

                TBase.Text = ProjBase.CurrentLanguage.GetValue(TBase.Text);
                TRep.Text = ProjBase.CurrentLanguage.GetValue(TRep.Text);
                TCard.Text = ProjBase.CurrentLanguage.GetValue(TCard.Text);
                TCommand.Text = ProjBase.CurrentLanguage.GetValue(TCommand.Text);

                base.IntLanguage();
            }
        }

        public override void intControls()
        {
            TUser = new GUsers();

            if (GridCard.PathSetting == "" || GridCard.PathSetting == null)
                GridCard.PathSetting = ProjBase.AppPath + "\\GridSetting\\" + this.Name + "GridCard";
            if (GridRep.PathSetting == "" || GridRep.PathSetting == null)
                GridRep.PathSetting = ProjBase.AppPath + "\\GridSetting\\" + this.Name + "GridRep";
            if (GridCommand.PathSetting == "" || GridCommand.PathSetting == null)
                GridCommand.PathSetting = ProjBase.AppPath + "\\GridSetting\\" + this.Name + "GridCommand";

            SEditParentUser.Connection.ConnectionString = ProjBase.ConnectionString;
            SEditParentUser.GenerateFelidSearch = true;
            base.intControls();
        }

        public override void GetDate()
           {
            TUser = GUsers.Load(GUID);
            IntGrid();
            intBaseinfo();
        }

        private void IntGrid()
        {
            
       
            string SQl = "exec Prc_GetGSecurity 'Card','" + GUID.ToString() + "'," + false.ToString() + "";
            SqlDataAdapter adaptercard = new SqlDataAdapter(SQl, ProjBase.Conn);
            SQl = "exec Prc_GetGSecurity 'Rep','" + GUID.ToString() + "'," + false.ToString() + "";
            SqlDataAdapter adapterRep = new SqlDataAdapter(SQl, ProjBase.Conn);
            SQl = "exec Prc_GetGSecurity 'Command','" + GUID.ToString() + "'," + false.ToString() + "";
            SqlDataAdapter adapterCommand = new SqlDataAdapter(SQl, ProjBase.Conn);

            dataSetCard = new DataSet();
            datasetRep = new DataSet();
            datasetCommand = new DataSet();
          
            adaptercard.Fill(dataSetCard);
            adapterRep.Fill(datasetRep);
            adapterCommand.Fill(datasetCommand);

            GridCard.AutoGenerateColumns = false;
            GridCard.DataSource = dataSetCard; // dataset

            GridRep.AutoGenerateColumns = false;
            GridRep.DataSource = datasetRep; // dataset

            GridCommand.AutoGenerateColumns = false;
            GridCommand.DataSource = datasetCommand; // dataset


            GenerateGrid(dataSetCard, GridCard);
            GenerateGrid(datasetRep, GridRep);
            GenerateGrid(datasetCommand, GridCommand);
            GridCard.LoadXmlSerializer();
            GridCommand.LoadXmlSerializer();
            GridRep.LoadXmlSerializer();

        }

        private void intBaseinfo()
        {
            TLoginName.Text = TUser.LoginName;
            TPassword.Text = TUser.Password;
          
            ChkISAdmin.Checked = TUser.IsAdmin;
         
            SEditParentUser.Value = TUser.ParentUser.ToString();

        }
       
      
        private void GenerateGrid(DataSet Ds, GGrid g)
        {
            g.Columns.Clear();

            if (Ds.Tables.Count > 0)
            {
                g.DataMember = Ds.Tables[0].TableName;
                foreach (DataColumn item in Ds.Tables[0].Columns)
                {
                    if (item.ColumnName == "Name")
                    {
                        DataGridViewTextBoxColumn Temp = new DataGridViewTextBoxColumn();
                        Temp.Name = item.ColumnName;
                        Temp.ReadOnly = true;
                        Temp.SortMode = DataGridViewColumnSortMode.NotSortable;
                        Temp.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        Temp.DataPropertyName = item.ColumnName;
                        Temp.HeaderText = item.ColumnName;
                        g.Columns.Add(Temp);
                    }
                    else
                    {
                        DataGridViewCheckBoxColumn Temp = new DataGridViewCheckBoxColumn();
                        Temp.Name = item.ColumnName;
                        Temp.ReadOnly = false;
                        Temp.ThreeState = false;
                        Temp.SortMode = DataGridViewColumnSortMode.NotSortable;
                        Temp.DataPropertyName = item.ColumnName;
                        Temp.HeaderText = item.ColumnName;
                        g.Columns.Add(Temp);
                    }
                }
                g.LoadXmlSerializer();
            }
        }
        public override bool SetDate()
        {
            GetUserBaseinfo();
            return true;
            base.SetDate();
        }

        public override void DoNew()
        {
            IntGrid();
            base.DoNew();
        }
        public override bool DoSave()
        {
            bool Result = false;
            Result = CheckData();
            if (Result)
            {
                if (GUID == Guid.Empty)
                    TUser.Add();
                else
                    TUser.Update();

                SaveGSecurety();
            }
            return Result;
        }

        public bool CheckData()
        {
            bool Result = false;
            bool Result1 = false;
            Result = TLoginName.Text != "";
            Result1 = TPassword.Text != "";
            if (!Result)
                FrmMSGErorr.ShowError(ProjBase.CurrentLanguage.GetValue("LogInName Is Empty"));
           else  if (!Result1)
                FrmMSGErorr.ShowError(ProjBase.CurrentLanguage.GetValue("Password Is Empty"));
            return Result;
        }
        private void SaveGSecurety()
        {
            GSecurity.DeleteGSecurityByUser(GUID);
            SetGSecurety(GridCard);
            SetGSecurety(GridRep);
            SetGSecurety(GridCommand);
        }

        private void SetGSecurety(GGrid G)
        {
            SecurityType ST = (SecurityType)Enum.Parse(typeof(SecurityType), G.Tag.ToString());
            foreach (DataGridViewRow itemRow in G.Rows)
            {
                GSecurity PS = new GSecurity();
                PS.Name = G.Rows[itemRow.Index].Cells["Name"].Value.ToString();
                PS.SecurityType = ST;
                PS.UserGUID = GUID;
                foreach (DataGridViewColumn itemCol in G.Columns)
                {
                    if (itemCol.Name != "Name")
                    {
                        PS.Command = itemCol.Name;
                        PS.Permission = ValuesFix.GetValuebool(G.Rows[itemRow.Index].Cells[itemCol.Name].Value);
                        PS.Add();
                    }
                }

            }
        }

        public override void DoDelee()
        {
            TUser.Del();
            base.DoDelee();
        }

        public override void ClearData()
        {
            TLoginName.Text = "";
            TPassword.Text = "";
            ChkISAdmin.Checked = false;
          
            base.ClearData();
        }



        private void FrmGUser_Load(object sender, EventArgs e)
        {
            IntGrid();
        }

        private void Grid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            GGrid G = ((GGrid)sender);
            if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.LeftCtrl))
                G.EndEdit();
            object B = G.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (Keyboard.IsKeyDown(Key.LeftShift))
            {
                foreach (DataGridViewColumn item in G.Columns)
                {
                    if (item.Name != "Name")
                        G.Rows[e.RowIndex].Cells[item.Name].Value = B;
                }
            }
            else if (Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.A))
            {
                foreach (DataGridViewRow itemRow in G.Rows)
                {
                    foreach (DataGridViewColumn itemCol in G.Columns)
                    {
                        if (itemCol.Name != "Name")
                            G.Rows[itemRow.Index].Cells[itemCol.Name].Value = B;
                    }
                }
            }
            else if (Keyboard.IsKeyDown(Key.LeftCtrl))
            {
                foreach (DataGridViewRow item in G.Rows)
                {
                    G.Rows[item.Index].Cells[e.ColumnIndex].Value = B;
                }
            }

        }

        private void GetUserBaseinfo()
        {
            TUser.LoginName = TLoginName.Text;
            TUser.IsAdmin = ChkISAdmin.Checked;
            TUser.Password = TPassword.Text;
        
            TUser.ParentUser = SEditParentUser.guid;
        }

        private void TBase_Click(object sender, EventArgs e)
        {

        }

        private void PBaseTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
