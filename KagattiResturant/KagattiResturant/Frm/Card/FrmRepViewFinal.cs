using GBase;
using GControls.Class;
using GProjects.Class;
using KagattiResturant.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KagattiResturant.Frm.Card
{
    public partial class FrmRepViewFinal : GProjects.Frm.FrmBase
    {
        public string RepName { get; set; }
        public string SqlQuery { get; set; }
        public string FromDate { get {return TFromDate.Text; } set {TFromDate.Text=value; } }
        public string ToDate { get { return TToDate.Text; } set { TToDate.Text = value; } }
        public CheckedListBox ListFileds { get; set; }
        public FrmRepViewFinal()
        {
            InitializeComponent();
        }
        public override void IntLanguage()
        {
            if (CBase.CurrentLanguage!=null)
            {
                CBase.CurrentLanguage.GetValue(BtnClose);
                CBase.CurrentLanguage.GetValue(BtnDesign);
                CBase.CurrentLanguage.GetValue(BtnPrint);
                CBase.CurrentLanguage.GetValue(BtnShow);
                CBase.CurrentLanguage.GetValue(LFromDate);
                CBase.CurrentLanguage.GetValue(LToDate);

                base.IntLanguage();
            }
           
        }
        private void FrmRepView_Load(object sender, EventArgs e)
        {
            
        }

        public override void intControls()
        {
            BtnClose.Image = ImageListBase24.Images["false"];
            BtnDesign.Image = ImageListBase24.Images["Card-Design"];
            BtnShow.Image = ImageListBase24.Images["Card-Show"];
            BtnPrint.Image = ImageListBase24.Images["print"];
            BtnRefresh.Image = ImageListBase24.Images["refresh"];
            IntRep();
           // if (CBase.IntPOSSecurity == true)
                intSecurity();
            if (Grd.PathSetting == "" || Grd.PathSetting == null)
                Grd.PathSetting = CBaseClass.AppPath + "\\GridSetting\\Rep\\" + this.Text;
            Grd.LoadXmlSerializer();
            base.intControls();
        }
        private void IntRep()
        {
            try
            {
                RepName = GControls.Class.CBaseClass.Getpath() + "\\CustRep\\RepPrint\\" + this.Text + ".mrt";
                if (!File.Exists(RepName))
                    File.Copy(GControls.Class.CBaseClass.Getpath() + "\\Base Rep\\BRep.mrt", RepName);
                Rep.Load(RepName);
            }
            catch (Exception)
            {

            }

        }

        public virtual void Rep_Click(object sender, EventArgs e)
        {
            Control b = (Control)sender;
            //Rep.Dictionary.Clear();
            Rep.RegData(dataSet);
            Rep.RegBusinessObject("FromDate", TFromDate);
            Rep.RegBusinessObject("ToDate", TToDate);
            Rep.Dictionary.Synchronize();
            if (b.Tag.ToString() == "2")
                Rep.Design();
            else
            {
                Rep.Render();
                if (b.Tag.ToString() == "0")
                    Rep.Show();
                else if (b.Tag.ToString() == "1")
                    Rep.Print();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public virtual void intDate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(SqlQuery, ProjBase.Conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet,"f");

            Grd.AutoGenerateColumns = true;
            Grd.DataSource = dataSet; // dataset
            GridFoter.DataSource = dataSet; // dataset

            Grd.DataMember = dataSet.Tables[0].TableName; // table name you need to show
            foreach (DataColumn item in dataSet.Tables[0].Columns)
                if (item.DataType == typeof(float) || item.DataType == typeof(double))
                    Grd.Columns[item.ColumnName].DefaultCellStyle.Format = "N" + POSOPtions.NumberDesimal.ToString();
            if (dataSet.Tables.Count > 1)
            {
                GridFoter.DataMember = dataSet.Tables[1].TableName; // table name you need to show.DataMember = dataSet.Tables[0].TableName; // table name you need to show
                foreach (DataColumn item in dataSet.Tables[1].Columns)
                    if (item.DataType == typeof(float)|| item.DataType == typeof(double))
                        GridFoter.Columns[item.ColumnName].DefaultCellStyle.Format = "N" + POSOPtions.NumberDesimal.ToString();
            }

            IntGrd();
        }
        public virtual void IntGrd()
        {
            Grd.LoadXmlSerializer();
            if (ListFileds == null)
                return;
            for (int i = 0; i < Grd.ColumnCount; i++)
            {
                Grd.Columns[i].HeaderText = GBase.CBase.GetLanguageText(Grd.Columns[i].HeaderText);
                Grd.Columns[i].Visible = ListFileds.GetItemChecked(i);
            }

        }

        private void intSecurity()
        {
            Grd.OpenSettingInMenu= GSecurity.GetGSecurity(SecurityType.Rep, this.Name, "Open Grid Setting");
            BtnDesign.Enabled = GSecurity.GetGSecurity(SecurityType.Rep, this.Name, "Design Rep");
            BtnShow.Enabled = GSecurity.GetGSecurity(SecurityType.Rep, this.Name, "Show Rep");
            BtnPrint.Enabled = GSecurity.GetGSecurity(SecurityType.Rep, this.Name, "Print Rep");
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            intDate();
        }
    }

}
