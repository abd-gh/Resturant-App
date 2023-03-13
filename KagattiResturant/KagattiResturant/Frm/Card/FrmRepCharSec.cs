using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GProjects.Class;
using System.Data.SqlClient;
using KagattiResturant.Class;

namespace KagattiResturant.Frm.Card
{
    public partial class FrmRepCharSec : GControls.Forms.FBase
    {
        public bool ShowDialog { get; set; }
        public FrmRepCharSec()
        {
            InitializeComponent();
            ShowDialog = false;
        }

        private void FrmRepCharSec_Load(object sender, EventArgs e)
        {

            //User Is Admin ?
           /*Guid userGuid = CSamaHotel.CurrUser.guid;
           /* SqlDataReader dr;
            SqlCommand com = ProjBase.Conn.CreateCommand();
            com.CommandText = " Select Isadmin from GUsers where Guid='" + userGuid.ToString() + "' ";
            dr = com.ExecuteReader();
            dr.Read();
            bool userIsAdmin = ValuesFix.GetValuebool(dr["Isadmin"].ToString());
            dr.Close();
            if (userIsAdmin == false)*/
           if(!CSamaHotel.CurrUser.IsAdmin)
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
        }

        private void FrmRepCharSec_MinimumSizeChanged(object sender, EventArgs e)
        {
            if (ProjBase.MdiParent != null && (ShowDialog == false))
                this.MdiParent = ProjBase.MdiParent;
        }

        public override void IntLanguage()
        {
            string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (lng == "Ar")
            {
                //ProjBase.CurrentLanguage.GetValue(Lsection.Text);
                ProjBase.CurrentLanguage.GetValue(LFromDate.Text);
                ProjBase.CurrentLanguage.GetValue(LToDate.Text);
            }
            base.IntLanguage();
        }

        private void PBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            /*  DateTime fromDate = TFromeDate.Value;
              string year = fromDate.Year.ToString();
              string month = fromDate.Month.ToString();
              string day = fromDate.Day.ToString();
              if (month.Length == 1)
              {
                  month = "0" + month;
              }
              if (day.Length == 1)
              {
                  day = "0" + day;
              }
              string Fdate = year + '/' + month + '/' + day;

              DateTime toDate = TToDate.Value;
              string Tyear = toDate.Year.ToString();
              string Tmonth = toDate.Month.ToString();
              string Tday = toDate.Day.ToString();
              if (Tmonth.Length == 1)
              {
                  Tmonth = "0" + Tmonth;
              }
              if (Tday.Length == 1)
              {
                  Tday = "0" + Tday;
              }
              string Tdate = Tyear + '/' + Tmonth + '/' + Tday;
              string datefrom = Fdate;
              string dateto = Tdate;*/
            string fromDate = (TFromeDate.Value).ToString("yyyy/MM/dd");
            string toDate = (TToDate.Value).ToString("yyyy/MM/dd");

            SqlDataReader dr;
            SqlCommand com = ProjBase.Conn.CreateCommand();
            com.CommandText = "select  s.name as namee ,SUM(o.count) as counts" +
                              "  from RestSection s" +
                               " inner join RestItem i on i.Section_Name=s.GUID" +
                               " inner join RestOrder o on o.Item_Name=i.GUID" +
                               " inner join RestBill b on b.GUID=o.Guid_RestBill" +
                               " where cast(convert(datetime,b.Date )as date) >= cast(convert(datetime,'" + fromDate + "' )as date)and" +
                                " cast(convert(datetime,b.Date ) as date) <= cast(convert(datetime,'" + toDate + "' ) as date) and (b.Checks=1)" +
                               " group by s.name ";
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                string nameOfSection = ValuesFix.GetValueString(dr["namee"].ToString());
                double count = ValuesFix.GetValueDouble(dr["counts"]);

                chart1.Series["total"].Points.AddXY(nameOfSection, count);
            }
            dr.Close();
        }

        //select  s.name as namee ,SUM(o.count) as counts
        //from RestSection s
        //inner join RestItem i on i.Section_Name=s.GUID
        //inner join RestOrder o on o.Item_Name=i.GUID
        //inner join RestBill b on b.GUID=o.Guid_RestBill
        //where cast(convert(datetime,b.Date )as date) >= cast(convert(datetime,'02-05-2019' )as date)and 
        //      cast(convert(datetime,b.Date ) as date) <= cast(convert(datetime,'02-05-2019' ) as date)
        //group by s.name
    }
}
