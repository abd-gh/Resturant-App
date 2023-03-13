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
    public partial class FrmCardInvoices : GBase.FrmCard
    {

        RestInvoices invoices;
        public FrmCardInvoices()
        {
            InitializeComponent();
        
        }
        public override void intControls()
        {
            invoices = new RestInvoices();
            TUsers.Connection.ConnectionString = ProjBase.ConnectionString;
            TUsers.GenerateFelidSearch = true;
            base.intControls();
        }

        public override void GetDate()
        {
            invoices = RestInvoices.Load(GUID);
            TTitle.Text = invoices.Title;
            TPrice.Text = (invoices.Price).ToString();
            TNotes.Text = invoices.Notes;
            TUsers.guid = invoices.Users;
            label1.Text = invoices.Date.ToString();
            base.GetDate();
        }

        public override bool SetDate()
        {
            invoices.Title = TTitle.Text;
            invoices.Price = double.Parse(TPrice.Text);
            invoices.Users =CSamaHotel.CurrUser.guid;
            invoices.Date = DateTime.UtcNow;
            invoices.Notes = TNotes.Text;
            
            return base.SetDate();
        }
        public override void ClearData()
        {
            TTitle.Text = TPrice.Text =TNotes.Text= "";
          //  Users.guid = Guid.Empty;
            label1.Text = DateTime.Now.ToString();
            base.ClearData();
        }

        public override bool DoSave()
        {
            bool Result = false;
            Result = CheckData();
            if (Result)
            {
                if (GUID == Guid.Empty)
                    invoices.Add();
                else
                    invoices.Update();

            }

            this.Close();
            return Result;
        }
        public override void DoDelee()
        {
            invoices.Del();
            base.DoDelee();
        }

        public bool CheckData()
        {
            bool Result = false;
            Result = TTitle.Text != "" && TPrice.Text != "";
            if (!Result)
            {
                FrmMSGErorr.ShowError(ProjBase.CurrentLanguage.GetValue("Name Or Price Is Empty"));
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

        private void FrmCardInvoices_Load(object sender, EventArgs e)
        {
            TUsers.guid = CSamaHotel.CurrUser.guid;
            label1.Text = DateTime.UtcNow.ToShortDateString();
        }

        private void FrmCardInvoices_SizeChanged(object sender, EventArgs e)
        {
            //if (ProjBase.MdiParent != null)
            //    this.MdiParent = ProjBase.MdiParent;
            //if (ProjBase.MdiParent != null && (ShowDialog == false))
            //    this.MdiParent = ProjBase.MdiParent;
        }

        private void PBack_Paint(object sender, PaintEventArgs e)
        {

        }
        public override void IntLanguage()
        {
            string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (lng == "Ar")
            {

                ProjBase.CurrentLanguage.GetValue(BtnClose);
                ProjBase.CurrentLanguage.GetValue(BtnDel);
                ProjBase.CurrentLanguage.GetValue(BtnDesign);
                ProjBase.CurrentLanguage.GetValue(BtnNew);
                ProjBase.CurrentLanguage.GetValue(BtnPrint);
                ProjBase.CurrentLanguage.GetValue(BtnSave);
                ProjBase.CurrentLanguage.GetValue(BtnSearch);
                ProjBase.CurrentLanguage.GetValue(BtnShow);

                ProjBase.CurrentLanguage.GetValue(LTitle);
                ProjBase.CurrentLanguage.GetValue(LPrice);
                ProjBase.CurrentLanguage.GetValue(LNotes);
                ProjBase.CurrentLanguage.GetValue(LUsers);
                ProjBase.CurrentLanguage.GetValue(LDate);
        
                base.IntLanguage();
            }
        }
    }
}
