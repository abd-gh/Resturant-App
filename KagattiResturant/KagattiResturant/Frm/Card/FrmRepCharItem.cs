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
using GProjects.Frm;

namespace KagattiResturant.Frm.Card
{
    public partial class FrmRepCharItem : GControls.Forms.FBase
    {
        public bool ShowDialog { get; set; }
        public FrmRepCharItem()
        {
            InitializeComponent();
            ShowDialog = false;
        }
        public override void intControls()
        {
         
            TItem.Connection.ConnectionString = ProjBase.ConnectionString;
            TItem.GenerateFelidSearch = true;
            base.intControls();
        }


        private void FrmRepCharItem_Load(object sender, EventArgs e)
        {
          //  if (CBase.CurrentLanguage != null)
         //       Language = CBase.CurrentLanguage;
            //User Is Admin ?
            /*Guid User_Guid = CSamaHotel.CurrUser.guid;
            /* SqlDataReader DrU;
             SqlCommand CommU = ProjBase.Conn.CreateCommand();
             CommU.CommandText = " Select Isadmin from GUsers where Guid='" + User_Guid.ToString() + "' ";
             DrU = CommU.ExecuteReader();
             DrU.Read();
              bool  User_IsAdmin = ValuesFix.GetValuebool(DrU["Isadmin"].ToString());
             DrU.Close();
             if (User_IsAdmin==false)*/
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
                    FrmMSGErorr.ShowError("Sory.. but you don't have permission ");                
                }
                        
            }
            //End User Is Admin
        }

        private void FrmRepCharItem_MinimumSizeChanged(object sender, EventArgs e)
        {
            if (ProjBase.MdiParent != null && (ShowDialog == false))
                this.MdiParent = ProjBase.MdiParent;
        }

        public override void IntLanguage()
        {
            //if (ProjBase.CurrentLanguage != null)
            //    this.Text= ProjBase.CurrentLanguage.GetValue(this.Text);
             string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
             if (lng == "Ar")
             {
                 ProjBase.CurrentLanguage.GetValue(Lsection.Text);
                 ProjBase.CurrentLanguage.GetValue(LFromDate.Text);
                 ProjBase.CurrentLanguage.GetValue(LToDate.Text);
             }
            base.IntLanguage();
        }

        private void PBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            Guid g=TItem.guid;
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
            string datefrom = Fdate;
            string dateto = Tdate;
            string name;
            double  count;
            SqlDataReader Dr;
            SqlCommand Comm = ProjBase.Conn.CreateCommand();
            Comm.CommandText = "select  i.name as namee ,SUM(o.count) as counts" +
                               " from RestItem i" +                             
                               " inner join RestOrder o on o.Item_Name=i.GUID" +
                               " inner join RestBill b on b.GUID=o.Guid_RestBill" +
                               " where cast(convert(datetime,b.Date )as date) >= cast(convert(datetime,'" + datefrom + "' )as date)and" +
                               " cast(convert(datetime,b.Date ) as date) <= cast(convert(datetime,'" + dateto + "' ) as date)and " +
                               "(i.Section_Name='" + g.ToString() + "')  and (b.Checks=1)" +
                               " group by i.name ";
            Dr = Comm.ExecuteReader();
            while(Dr.Read())
            {
                name = ValuesFix.GetValueString(Dr["namee"].ToString());
                count = ValuesFix.GetValueDouble(Dr["counts"]);
                //chart1.Series["total"].XValueMember = "Age";
                //chart1.Series["total"].XValueMember = "total";
                chart1.Series["total"].Points.AddXY(name,count);
            }
            Dr.Close();
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
