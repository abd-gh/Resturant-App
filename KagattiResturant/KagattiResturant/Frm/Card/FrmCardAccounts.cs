using GProjects.Class;
using GProjects.Frm;
using SamaHotel.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamaHotel.Frm.Card
{
    public partial class FrmCardAccounts : GBase.FrmCard
    {
        private HotelAccounts Accounts;
        public FrmCardAccounts()
        {
            InitializeComponent();
        }
        public override void IntLanguage()
        {
           // ProjBase.CurrentLanguage.GetValue(LCode);
          //  ProjBase.CurrentLanguage.GetValue(LName);
         //   ProjBase.CurrentLanguage.GetValue(LBadsNumber);

           // ProjBase.CurrentLanguage.GetValue(LPrice);
           // ProjBase.CurrentLanguage.GetValue(LBedNumder);
          //  ProjBase.CurrentLanguage.GetValue(LLooking);
          //  ProjBase.CurrentLanguage.GetValue(LAccountsType);


           // ProjBase.CurrentLanguage.GetValue(LFloor);
           // ProjBase.CurrentLanguage.GetValue(LStatus);
          //  ProjBase.CurrentLanguage.GetValue(LNote);

            base.IntLanguage();
        }

        public override void intControls()
        {
            Accounts = new HotelAccounts();
           // SEditFloor.Connection.ConnectionString = ProjBase.ConnectionString;
           // SEditFloor.GenerateFelidSearch = true;

            base.intControls();
        }

        public override void GetDate()
        {
            Accounts = HotelAccounts.Load(GUID);
           /// TCode.Text = Accounts.Code;
           // TName.Text = Accounts.Name;
          //  TBadsNumber.Value = Accounts.BadsNumber;

          //  TPrice.Text = Accounts.Price;
         //   TBedNumber.Value = Accounts.BedNumder;
            //



          //  SEditFloor.guid = Accounts.FloorGUID;
          //  ComStatus.SelectedIndex = Accounts.Status;
          //  TNotes.Text = Accounts.Notes;
            base.GetDate();
        }

        public override bool SetDate()
        {
         //   Accounts.Code = TCode.Text;
         //   Accounts.Name = TName.Text;
        //    Accounts.BadsNumber =ValuesFix.GetValueInt(TBadsNumber.Value);
        //    Accounts.FloorGUID = SEditFloor.guid;
         //   Accounts.Status = ComStatus.SelectedIndex;
        //    Accounts.Notes = TNotes.Text;
            return base.SetDate();
        }

        public override void ClearData()
        {
          //  TCode.Text = TName.Text = TNotes.Text=TPrice.Text = "";
         //   SEditFloor.guid = Guid.Empty;
         //   TBadsNumber.Value =TBedNumber.Value= 0;
         //   ComStatus.SelectedIndex=TLooking.SelectedIndex= TAccountsType.SelectedIndex = -1;
            base.ClearData();
        }

        public override bool DoSave()
        {
            bool Result = false;
            Result = CheckData();
            if (Result)
            {
                if (GUID == Guid.Empty)
                    Accounts.Add();
                else
                    Accounts.Update();

            }
            return Result;
        }
        public override void DoDelee()
        {
            Accounts.Del();
            base.DoDelee();
        }

        public bool CheckData()
        {
            bool Result = false;
         //   Result = TName.Text != "" && TCode.Text != "";
            if (!Result)
            {
                FrmMSGErorr.ShowError(ProjBase.CurrentLanguage.GetValue("Name Or Code Is Empty"));
                return Result;
            }
         //   Result = SEditFloor.guid != Guid.Empty;
            if (!Result)
            {
                FrmMSGErorr.ShowError(ProjBase.CurrentLanguage.GetValue("Floar Is Empty"));
                return Result;
            }
            return Result;
        }

        private void FrmCardAccountss_Load(object sender, EventArgs e)
        {

        }

        private void SEditFloor_ONFormNew(object sender, EventArgs e)
        {

        }

        private void ComStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SEditFloor_Load(object sender, EventArgs e)
        {

        }

        private void TCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void TNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
