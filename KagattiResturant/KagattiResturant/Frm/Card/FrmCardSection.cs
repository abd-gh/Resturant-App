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
    public partial class FrmCardSection : GBase.FrmCard
    {

        private RestSection Section;
     
        public FrmCardSection()
        {
            InitializeComponent();
        
        }
        public override void IntLanguage()
        {
            string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (lng == "Ar")
            {
                ProjBase.CurrentLanguage.GetValue(LName);
                ProjBase.CurrentLanguage.GetValue(LPrinter);
                ProjBase.CurrentLanguage.GetValue(LIsProduct);
                base.IntLanguage();
            }
        }

        public override void intControls()
        {
            Section = new RestSection();
            //SEditFloor.Connection.ConnectionString = ProjBase.ConnectionString;
            //SEditFloor.GenerateFelidSearch = true;
            base.intControls();
        }

        public override void GetDate()
        {
            Section = RestSection.Load(GUID);
            TName.Text = Section.Name;
            combPrinter.Text = Section.Printer;
            CIsProduct.Checked = Section.IsProduct;
            base.GetDate();
        }

        public override bool SetDate()
        {
            Section.Name = TName.Text;
            Section.Printer = combPrinter.Text;
            Section.IsProduct = CIsProduct.Checked;
            return base.SetDate();
        }
        public override void ClearData()
        {
            TName.Text = "";
            combPrinter.SelectedIndex = -1;
            CIsProduct.Checked = false;
            base.ClearData();
        }

        public override bool DoSave()
        {
            bool Result = false;
            Result = CheckData();
            if (Result)
            {
                if (GUID == Guid.Empty)
                    Section.Add();
                else
                    Section.Update();

            }

            this.Close();
            return Result;
        }
        public override void DoDelee()
        {
            Section.Del();
            base.DoDelee();
        }

        public bool CheckData()
        {
            bool Result = false;
            Result = TName.Text!="" && combPrinter.Text != "" ;
            if (!Result)
            {
                FrmMSGErorr.ShowError(ProjBase.CurrentLanguage.GetValue("Name and Printer are required"));
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

        private void FrmCardSection_Load(object sender, EventArgs e)
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                combPrinter.Items.Add(printer);
        }

        private void FrmCardSection_SizeChanged(object sender, EventArgs e)
        {

        }

        private void PBack_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
