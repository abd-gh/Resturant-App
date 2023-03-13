using GProjects.Class;
using GProjects.Frm;
using KagattiResturant.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KagattiResturant.Frm.Card
{
    public partial class FrmCardEmployee : GBase.FrmCard
    {

        private RestEmployee employ;
     
        public FrmCardEmployee()
        {
            InitializeComponent();
        
        }
        public override void IntLanguage()
        {
            string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (lng == "Ar")
            {
                ProjBase.CurrentLanguage.GetValue(LName);
                ProjBase.CurrentLanguage.GetValue(LPhone);
                ProjBase.CurrentLanguage.GetValue(LSalary);
                ProjBase.CurrentLanguage.GetValue(LNotes);
                base.IntLanguage();
            }
        }

        public override void intControls()
        {
            employ = new RestEmployee();
            //SEditFloor.Connection.ConnectionString = ProjBase.ConnectionString;
            //SEditFloor.GenerateFelidSearch = true;
            base.intControls();
        }

        public override void GetDate()
        {
            employ = RestEmployee.Load(GUID);
            TName.Text = employ.Name;
            TPhone.Text = employ.Phone;
            TSalary.Text = employ.Salary.ToString();
            TNotes.Text = employ.Notes;
           
            base.GetDate();
        }

        public override bool SetDate()
        {
            employ.Name = TName.Text;
            employ.Phone = TPhone.Text;
            employ.Salary = double.Parse(TSalary.Text);
            employ.Notes = TNotes.Text;
            return base.SetDate();
        }
        public override void ClearData()
        {
            TName.Text = TPhone.Text = TSalary.Text = TNotes.Text = "";
            base.ClearData();
        }

        public override bool DoSave()
        {
            bool Result = false;
            Result = CheckData();
            if (Result)
            {
                if (GUID == Guid.Empty)
                {
                    bool x = employ.Add();
                    if(x)
                    {
                        int Monthe = DateTime.Now.Month;
                        int year = DateTime.Now.Year;
                        string date = year + "/" + Monthe;
                        RestEmpSal empSal = new RestEmpSal();
                        empSal.GUID_Emp = employ.GUID;
                        empSal.Salary = employ.Salary;
                        empSal.Salary_Discount = 0;
                        empSal.Salary_Plus = 0;
                        empSal.Salary_received = 0;
                        empSal.Salary_Remaining = employ.Salary;
                        empSal.Month = date;
                        empSal.Add();
                    }
                }
                else
                    employ.Update();

            }

            this.Close();
            return Result;
        }
        public override void DoDelee()
        {
            employ.Del();
            base.DoDelee();
        }

        public bool CheckData()
        {
            bool Result = false;
            Result = TName.Text != "" && TSalary.Text != "";
            if (!Result)
            {
                FrmMSGErorr.ShowError(ProjBase.CurrentLanguage.GetValue("Name or Salary Is Empty"));
                return Result;
            }
            //Result = SEditFloor.guid != Guid.Empty;
            //if (!Result)
            //{
            //    FrmMSGErorr.ShowError(ProjBase.CurrentLanguage.GetValue("Floar Is Empty"));
            //    return Result;

            //}
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

        private void FrmCardEmployee_Load(object sender, EventArgs e)
        {

        }

        private void FrmCardEmployee_SizeChanged(object sender, EventArgs e)
        {
            //if (ProjBase.MdiParent != null)
            //    this.MdiParent = ProjBase.MdiParent;
            //if (ProjBase.MdiParent != null && (ShowDialog == false))
            //    this.MdiParent = ProjBase.MdiParent;
        }

        private void PBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //public override void IntLanguage()
        //{
        //    string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
        //    if (lng == "Ar")
        //    {
        //        ProjBase.CurrentLanguage.GetValue(BtnClose);
        //        ProjBase.CurrentLanguage.GetValue(BtnDel);
        //        ProjBase.CurrentLanguage.GetValue(BtnDesign);
        //        ProjBase.CurrentLanguage.GetValue(BtnNew);
        //        ProjBase.CurrentLanguage.GetValue(BtnPrint);
        //        ProjBase.CurrentLanguage.GetValue(BtnSave);
        //        ProjBase.CurrentLanguage.GetValue(BtnSearch);
        //        ProjBase.CurrentLanguage.GetValue(BtnShow);
        
        //        base.IntLanguage();
        //    }
        //}
    }
}
