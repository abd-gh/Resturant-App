using GProjects.Class;
using KagattiResturant.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GBase
{
    public partial class FrmCard : GProjects.Frm.FrmCardGUID
    {
     
        public FrmCard()
        {
            InitializeComponent();
        
        }
        public override void intSecurity()
        {
            if (CSamaHotel.ListGSecurity == null)
                return;
            if (Name=="FrmCard")
                return;
            BtnNew.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "New");
            BtnSave.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "Save");
            BtnDel.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "Del");
            BtnDesign.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "Design Rep");
            BtnShow.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "Show Rep");
            BtnPrint.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "Print Rep");
            BtnSearch.Enabled = GSecurity.GetGSecurity(SecurityType.Card, this.Name, "Search");
        }

        private void FrmCard_Load(object sender, EventArgs e)
        {

        }

        private void FrmCard_SizeChanged(object sender, EventArgs e)
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
        
                base.IntLanguage();
            }
        }
    }
}
