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
using System.Text;
using System.Windows.Forms;

namespace KagattiResturant.Frm.Card
{
    public partial class FrmCardEmpSalInv : GBase.FrmCard
    {

        private RestEmpSalInv empInv;
     
        public FrmCardEmpSalInv()
        {
            InitializeComponent();
        
        }
        public override void IntLanguage()
        {
            string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (lng == "Ar")
            {
                ProjBase.CurrentLanguage.GetValue(LEmployee);
                ProjBase.CurrentLanguage.GetValue(LSalary);
                ProjBase.CurrentLanguage.GetValue(LDis);
                ProjBase.CurrentLanguage.GetValue(Lpuls);
                ProjBase.CurrentLanguage.GetValue(LReceiv);
                ProjBase.CurrentLanguage.GetValue(LReman);
                base.IntLanguage();
            }
        }

        public override void intControls()
        {
            empInv = new RestEmpSalInv();
            Temployee.Connection.ConnectionString = ProjBase.ConnectionString;
            Temployee.GenerateFelidSearch = true;
            base.intControls();
        }

        public override void GetDate()
        {
            empInv = RestEmpSalInv.Load(GUID);
            Temployee.guid=empInv.GUID_Emp;
            TSalary.Text = empInv.Salary.ToString();
            TRemaining.Text =empInv.Salary_Remaining.ToString();
            rec.Text = empInv.Salary_received.ToString();
            dis.Text = empInv.Salary_Discount.ToString();
            plus.Text = empInv.Salary_Plus.ToString();
            dateTimePicker1.Text=empInv.Date.ToString();
        
            base.GetDate();
        }

        public override bool SetDate()
        {
            int Monthe = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string date = year + "/" + Monthe;
            empInv.Month = date;
            empInv.Users = CSamaHotel.CurrUser.guid;
            empInv.GUID_Emp = Temployee.guid;
            empInv.Salary =Convert.ToDouble (TSalary.Text);
            empInv.Salary_Remaining = Convert.ToDouble (TSalary.Text)-Convert.ToDouble (Treceived.Text) -Convert.ToDouble (TDiscount.Text)+ Convert.ToDouble( TPlus.Text);
            empInv.Salary_received =Convert.ToDouble (rec.Text);
            empInv.Salary_Discount = Convert.ToDouble (dis.Text);
            empInv.Salary_Plus =Convert.ToDouble( plus.Text);
            empInv.Date = DateTime.Now;
            SqlDataReader Drr;
            SqlCommand Commm = ProjBase.Conn.CreateCommand();
            Commm.CommandText = " Select * from RestEmpSal where (GUID_Emp='" + Temployee.guid.ToString() + "') and (Month='" + date.ToString() + "' )";
            Drr = Commm.ExecuteReader();
            Drr.Read();
            empInv.GUID_EmpSal = ValuesFix.GetValueGUID(Drr["Guid"]);
            Drr.Close();
            return base.SetDate();
        }
   
        public override bool DoSave()
        {
            int Monthe = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string date = year + "/" + Monthe;
            RestEmpSal empSal = new RestEmpSal();
            empSal.GUID_Emp = empInv.GUID_Emp;
            SqlDataReader Drr;
            SqlCommand Commm = ProjBase.Conn.CreateCommand();
            Commm.CommandText = " Select * from RestEmpSal where (GUID_Emp='" +empSal.GUID_Emp.ToString() + "') and (Month='" + date.ToString() + "' )";
            Drr = Commm.ExecuteReader();
            Drr.Read();
            empSal.GUID = ValuesFix.GetValueGUID(Drr["GUID"]);
            Drr.Close();
            empSal.Salary = empInv.Salary;
            empSal.Salary_Discount = Convert.ToDouble(TDiscount.Text);
            empSal.Salary_Plus = Convert.ToDouble(TPlus.Text);
            empSal.Salary_received =Convert.ToDouble( Treceived.Text);
            empSal.Salary_Remaining = Convert.ToDouble(TSalary.Text) - Convert.ToDouble(Treceived.Text) - Convert.ToDouble(TDiscount.Text) + Convert.ToDouble(TPlus.Text); ;
            empSal.Month = date;
           
            bool Result = false;
            Result = CheckData();
            if (Result)
            {
                if (GUID == Guid.Empty)
                {
                    empInv.Add();
                    empSal.Update();
                }
                else
                    empInv.Update();
            }

            return Result;
        }
        public override void ClearData()
        {
            TSalary.Text =TRemaining.Text = "";
            Treceived.Text = TDiscount.Text = TPlus.Text = plus.Text = dis.Text = rec.Text = "0";
            Temployee.guid = Guid.Empty;
            base.ClearData();
        }

        public override void DoDelee()
        {
            empInv.Del();
            base.DoDelee();
        }

        public bool CheckData()
        {
            bool Result = false;
            Result = Temployee.Text!="" ;
            if (!Result)
            {
                FrmMSGErorr.ShowError(ProjBase.CurrentLanguage.GetValue("Name Is Empty"));
                return Result;
            }
            return Result;
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

        private void FrmCardEmpSalInv_Load(object sender, EventArgs e)
        {
            // dateTimePicker1 = DateTime.Now();
            rec.Text = dis.Text = plus.Text="0";
         
        }

        private void FrmCardEmpSalInv_SizeChanged(object sender, EventArgs e)
        {
            //if (ProjBase.MdiParent != null)
            //    this.MdiParent = ProjBase.MdiParent;
            //if (ProjBase.MdiParent != null && (ShowDialog == false))
            //    this.MdiParent = ProjBase.MdiParent;
        }

        private void PBack_Paint(object sender, PaintEventArgs e)
        {

        }
        private static double ress,diss,pluss;
        private void Temployee_ONSelected(object sender, EventArgs e)
        {
            int Monthe = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string date = year + "/" + Monthe;
            Guid G_emp = Temployee.guid;
            SqlDataReader Drr;
            SqlCommand Commm = ProjBase.Conn.CreateCommand();
            Commm.CommandText = " Select * from RestEmpSal where (GUID_Emp='" + G_emp.ToString() + "') and (Month='"+date.ToString()+"' )";
            Drr = Commm.ExecuteReader();
            Drr.Read();
            ress = ValuesFix.GetValueDouble(Drr["Salary_received"]);
            diss = ValuesFix.GetValueDouble(Drr["Salary_Discount"]);
            pluss = ValuesFix.GetValueDouble(Drr["Salary_Plus"]);
            TSalary.Text = ValuesFix.GetValueDouble(Drr["Salary"]).ToString();
            TRemaining.Text = ValuesFix.GetValueDouble(Drr["Salary_Remaining"]).ToString();
            Treceived.Text = ValuesFix.GetValueDouble(Drr["Salary_received"]).ToString();
            TDiscount.Text = ValuesFix.GetValueDouble(Drr["Salary_Discount"]).ToString();
            TPlus.Text = ValuesFix.GetValueDouble(Drr["Salary_Plus"]).ToString();
            Drr.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rec_TextChanged(object sender, EventArgs e)
        {
            if(Treceived.Text!="")
            {
                double x = ress;
                double y = Convert.ToDouble(rec.Text);
                double z = x + y;
                Treceived.Text = z.ToString();
            }
                     
        }

        private void dis_TextChanged(object sender, EventArgs e)
        {
           if (TDiscount.Text != "")
            {
                double x = diss;
                double y = Convert.ToDouble(dis.Text);
                double z = x + y;
                TDiscount.Text = z.ToString();
            }
        }

        private void plus_TextChanged(object sender, EventArgs e)
        {
            if (plus.Text != "")
            {
                double x = pluss;
                double y = Convert.ToDouble(plus.Text);
                double z = x + y;
                TPlus.Text = z.ToString();
            }
        }

    }
}
