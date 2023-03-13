  using GBase;
using GProjects.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KagattiResturant.Frm ;
using KagattiResturant.Class;
namespace KagattiResturant.Frm.Card
{
    public partial class FrmRepRestItem : GProjects.Frm.FrmBaseRep
    {
        private string _RepName;
        public string RepName
        {

            get { return _RepName; }

            set { _RepName = value; this.Text = _RepName; }
        }

        public FrmRepRestItem()
        {
            InitializeComponent();
        }
        private void FrmRepRestItem_Load(object sender, EventArgs e)
        {
            //User Is Admin ?
            if (!CSamaHotel.CurrUser.IsAdmin)
            {
                this.Close();
                string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
                if (lng == "Ar")
                {
                    MessageBox.Show(ProjBase.CurrentLanguage.GetValue("Sory.. but you don't have permission "));
                }
                else
                {
                    MessageBox.Show("Sory.. but you don't have permission ");
                }

            }
            //End User Is Admin
        }
        public override void ShowRep()
        {
            FrmRepViewItem f = new FrmRepViewItem();
            f.FromDate = TFromeDate.Value.ToShortDateString(); //PFromDate.Value.ToShortDateString();
            f.ToDate = TToDate.Value.ToShortDateString();
            f.SqlQuery = GetSql();
            f.ListFileds = ListField;
            f.intDate();
            f.Show();
            base.ShowRep();
        }
        public override void IntLanguage()
        {
            string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (lng == "Ar")
            {
                ProjBase.CurrentLanguage.GetValue(LItem);
                ProjBase.CurrentLanguage.GetValue(LFromDate);
                ProjBase.CurrentLanguage.GetValue(LToDate);


                base.IntLanguage();
            }
        }
        public override void intControls()
        {
            TItem.Connection.ConnectionString = ProjBase.ConnectionString;
            TItem.GenerateFelidSearch = true;   
            base.intControls();
     
        }
        public override string GetSql()
        {
            Guid G = TItem.guid;
            DateTime FDate = TFromeDate.Value;
            string year = FDate.Year.ToString();
            string month = FDate.Month.ToString();
            string day = FDate.Day.ToString();
            if (month.Length == 1)
            {
                month = "0" + month;
            }
            if (day.Length == 1)
            {
                day = "0" + day;
            }
            string Fdate = year + '/' + month + '/' + day;

            DateTime TDate = TToDate.Value;
            string Tyear = TDate.Year.ToString();
            string Tmonth = TDate.Month.ToString();
            string Tday = TDate.Day.ToString();
            if (Tmonth.Length == 1)
            {
                Tmonth = "0" + Tmonth;
            }
            if (Tday.Length == 1)
            {
                Tday = "0" + Tday;
            }
            string Tdate = Tyear + '/' + Tmonth + '/' + Tday;
            return "RepRestItem '" + Fdate + "','" + Tdate + "', '" + G.ToString() + "'";
        }
        private void FrmRepAgent_Load(object sender, EventArgs e)
        {
          
        }
        //public override void ShowRep()
        //{
       
        //    base.ShowRep();
           
        //}

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
      

        private void FrmBaseRep_SizeChanged(object sender, EventArgs e)
        {
            if (ProjBase.MdiParent != null)
                this.MdiParent = ProjBase.MdiParent;
        }
        public virtual void intField()
        {
         
        }

        private void ListField_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void Pcontent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LFromDate_Click(object sender, EventArgs e)
        {

        }

        private void TCustomerName_Load(object sender, EventArgs e)
        {

        }

        
    }
}
