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
    public partial class FrmCardItem : GBase.FrmCard
    {

        private RestItem Item;

        public FrmCardItem()
        {
            InitializeComponent();

        }
        public override void IntLanguage()
        {
            string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (lng == "Ar")
            {
                ProjBase.CurrentLanguage.GetValue(LName);
                ProjBase.CurrentLanguage.GetValue(LPrice);
                ProjBase.CurrentLanguage.GetValue(LSection);
                ProjBase.CurrentLanguage.GetValue(LQuantity);
                base.IntLanguage();
            }
        }

        public override void intControls()
        {
            Item = new RestItem();
            TSection.Connection.ConnectionString = ProjBase.ConnectionString;
            TSection.GenerateFelidSearch = true;
            base.intControls();
        }

        public override void GetDate()
        {
            Item = RestItem.Load(GUID);
            TName.Text = Item.Name;
            Tprice.Text = (Item.Price).ToString();
            TSection.guid = Item.Section_Name;
            TQuantity.Text = Item.Quantity.ToString();
            base.GetDate();
        }

        public override bool SetDate()
        {
            Item.Name = TName.Text;
            Item.Price = double.Parse(Tprice.Text);
            Item.Section_Name = TSection.guid;
            Item.Quantity = int.Parse(TQuantity.Text);
            return base.SetDate();
        }
        public override void ClearData()
        {
            TName.Text = Tprice.Text = "";
            TSection.guid = Guid.Empty;
            TQuantity.Text = "0";
            base.ClearData();
        }

        public override bool DoSave()
        {
            bool Result = false;
            Result = CheckData();
            if (Result)
            {
                if (GUID == Guid.Empty)
                    Item.Add();
                else
                    Item.Update();
            }
            return Result;
        }
        public override void DoDelee()
        {
            Item.Del();
            base.DoDelee();
        }

        public bool CheckData()
        {
            bool Result = false;

            SqlDataReader Dr;
            SqlCommand Comm = ProjBase.Conn.CreateCommand();
            Comm.CommandText = " Select * from RestSection where GUID='" + TSection.guid + "'";
            Dr = Comm.ExecuteReader();
            Dr.Read();
            bool isProduct = ValuesFix.GetValuebool(Dr["IsProduct"]);
            Dr.Close();
            int quantity = int.Parse(TQuantity.Text);
            if (isProduct)
            {
                if (quantity > 0)
                {
                    Result = true;
                }
                else
                {
                    FrmMSGErorr.ShowError(ProjBase.CurrentLanguage.GetValue("you can't add zero quantity for product"));
                    return Result;
                }
            }

            Result = TName.Text != "" && Tprice.Text != "";
            if (!Result)
            {
                FrmMSGErorr.ShowError(ProjBase.CurrentLanguage.GetValue("Name Or Price Is Empty"));
                return Result;
            }
            Result = TSection.guid != Guid.Empty;
            if (!Result)
            {
                FrmMSGErorr.ShowError(ProjBase.CurrentLanguage.GetValue("Section Is Empty"));
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

        private void FrmCardItem_Load(object sender, EventArgs e)
        {

        }

        private void FrmCardItem_SizeChanged(object sender, EventArgs e)
        {
            //if (ProjBase.MdiParent != null)
            //    this.MdiParent = ProjBase.MdiParent;
            //if (ProjBase.MdiParent != null && (ShowDialog == false))
            //    this.MdiParent = ProjBase.MdiParent;
        }

        private void PBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
