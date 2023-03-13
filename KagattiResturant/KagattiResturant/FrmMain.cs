using GBase;
using GProjects.Class;
using GProjects.Frm;
using KagattiResturant.Class;
using KagattiResturant.Frm;
using KagattiResturant.Frm.Card;
using KagattiResturant.Frm.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KagattiResturant
{
    
    public partial class FrmMain : GControls.Forms.FBase
    {
     //   private HotelPayment payment;
        public FrmMain()
        {
            InitializeComponent();
        }

        public override void IntLanguage()
        {
            //Tab
            RTabCard.Text = ProjBase.CurrentLanguage.GetValue(RTabCard.Text);
            RTabReport.Text = ProjBase.CurrentLanguage.GetValue(RTabReport.Text);
            RTabTools.Text = ProjBase.CurrentLanguage.GetValue(RTabTools.Text);            

            //TabTools
            RToolOption.Text = ProjBase.CurrentLanguage.GetValue(RToolOption.Text);
            RToolChangeName.Text = ProjBase.CurrentLanguage.GetValue(RToolChangeName.Text);
            RToolExpression.Text = ProjBase.CurrentLanguage.GetValue(RToolExpression.Text);

            //Menu
            RMenu_New.Text = ProjBase.CurrentLanguage.GetValue(RMenu_New.Text);
            RMenu_Open.Text = ProjBase.CurrentLanguage.GetValue(RMenu_Open.Text);
            RMenu_Close.Text = ProjBase.CurrentLanguage.GetValue(RMenu_Close.Text);
            RMenu_Exit.Text = ProjBase.CurrentLanguage.GetValue(RMenu_Exit.Text);

            //Report
            MnuRepAgent.Text = ProjBase.CurrentLanguage.GetValue(MnuRepAgent.Text);
            MnuRepItem.Text = ProjBase.CurrentLanguage.GetValue(MnuRepItem.Text);
            MnuTotalSec.Text = ProjBase.CurrentLanguage.GetValue(MnuTotalSec.Text);
            MnuTotalItem.Text = ProjBase.CurrentLanguage.GetValue(MnuTotalItem.Text);
            MnuTotalTop.Text = ProjBase.CurrentLanguage.GetValue(MnuTotalTop.Text);
            MnuRepInvoces.Text = ProjBase.CurrentLanguage.GetValue(MnuRepInvoces.Text);
            MnuRepFinal.Text = ProjBase.CurrentLanguage.GetValue(MnuRepFinal.Text);
            MnuRepDelivery.Text = ProjBase.CurrentLanguage.GetValue(MnuRepDelivery.Text);
            MnuRepDelivNon.Text = ProjBase.CurrentLanguage.GetValue(MnuRepDelivNon.Text);

            //CardTab  MnuCardPReservation FrmCalculationRentContracts
            MnuCardPUser.Text = ProjBase.CurrentLanguage.GetValue(MnuCardPUser.Text);                
            MnuChangePass.Text = ProjBase.CurrentLanguage.GetValue(MnuChangePass.Text);
            MnuSection.Text = ProjBase.CurrentLanguage.GetValue(MnuSection.Text);
            MnuItem.Text = ProjBase.CurrentLanguage.GetValue(MnuItem.Text);
            MnuInvoices.Text = ProjBase.CurrentLanguage.GetValue(MnuInvoices.Text);
            MnuEmployee.Text = ProjBase.CurrentLanguage.GetValue(MnuEmployee.Text);
           // MnuSalMonth.Text = ProjBase.CurrentLanguage.GetValue(MnuSalMonth.Text);
            MnuSalIn.Text = ProjBase.CurrentLanguage.GetValue(MnuSalIn.Text);
            MnuRepEmp.Text = ProjBase.CurrentLanguage.GetValue(MnuRepEmp.Text);
            base.IntLanguage();

        }

        public override void intControls()
        {
            base.intControls();
            RMenu_Exit.Image = ImageListBase32.Images["exit"];
            RMenu_Open.Image = ImageListBase32.Images["File_Open"];
            RMenu_Close.Image = ImageListBase32.Images["File_Close"];
            RMenu_New.Image = ImageListBase32.Images["Card-add"];
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GControls.Message.MSBox.ShowExitApp() != DialogResult.OK)
                e.Cancel = true;
        }

        private void ControlTabs(bool Enable)
        {
            foreach (RibbonTab itemTab in ribbon1.Tabs)
            {
                itemTab.Visible = Enable;
                foreach (RibbonPanel itemPanal in itemTab.Panels)
                {
                    itemPanal.Enabled = Enable;
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ControlTabs(false);
            OpenApp();
        }

        private void OpenApp()
        {
            
            FrmSelectConnection f = new FrmSelectConnection();
            switch (f.ShowDialog())
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    if (login(f.FileKeyPath))
                    {
                        ControlTabs(true);
                    }
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    NewFile();
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }

        }
        private void ExitApp()
        {
            Close();
        }
        private void CloseApp()
        {
            if (this.MdiChildren.Length > 0)
            {
                if (GControls.Message.MSBox.ShowCloseAllWindow() == DialogResult.OK)
                    foreach (Form frm in this.MdiChildren)
                    {
                        frm.Dispose();
                    }
                else
                    return;
            }
            ControlTabs(false);

            ProjBase.ChangeConnString("");
            ChangeStatus(0);
            ProjBase.MdiParent.Text = "Kagatti";
        }
        private void NewFile()
        {
            FrmExisitDB f = new FrmExisitDB();
            f.DefPath = "";
            f.Show();
            ChangeStatus(1);
        }
        private void Menu_Open_Click(object sender, EventArgs e)
        {
            OpenApp();
        }

        private void Menu_Close_Click(object sender, EventArgs e)
        {
            CloseApp();
        }

        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void Menu_New_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        public void ChangeStatus(int Type)
        {
            if (Type == 0)
            {
                TStatus_UserName.Text = "";
                TStatus_Server.Text = "";
                TStatus_DataBase.Text = "";
                TProgV.Text = "";
            }
            else
            {
                if (CSamaHotel.CurrUser!= null)
                {
                    TStatus_UserName.Text = CSamaHotel.CurrUser.LoginName;
                    TStatus_Server.Text = ProjBase.Conn.DataSource;
                    TStatus_DataBase.Text = ProjBase.Conn.Database;
                    TProgV.Text = ProjBase.Versions;

                    {
                        int Monthe = DateTime.Now.Month;
                        int year = DateTime.Now.Year;
                        string date = year + "/" + Monthe;
                        int EN;
                        SqlDataReader Drr;
                        SqlCommand Commm = ProjBase.Conn.CreateCommand();
                        Commm.CommandText = "select * from RestEmployee ";
                        Drr = Commm.ExecuteReader();
                        using (DataTable dtt = new DataTable())
                        {
                            dtt.Load(Drr);
                            Drr.Close();
                            EN = (dtt.Rows.Count);
                            if (EN > 0)
                            {
                                for (int i = 0; i < EN; i++)
                                {
                                   // SqlDataReader Dr;
                                    SqlCommand Comm = ProjBase.Conn.CreateCommand();
                                    Comm.CommandText = "select *  from RestEmpSal where GUID_Emp='" + dtt.Rows[i][0].ToString()+ "' and Month='" + date + "'";

                                    if (Comm.ExecuteScalar()!=null)
                                    {
                                        
                                    }
                                    else
                                    {                                    
                                        RestEmpSal empSal = new RestEmpSal();
                                        empSal.GUID_Emp = Guid.Parse(dtt.Rows[i][0].ToString());
                                        empSal.Salary = Convert.ToDouble(dtt.Rows[i][4].ToString());
                                        empSal.Salary_Discount = 0;
                                        empSal.Salary_Plus = 0;
                                        empSal.Salary_received = 0;
                                        empSal.Salary_Remaining = Convert.ToDouble(dtt.Rows[i][4].ToString());
                                        empSal.Month = date;
                                        empSal.Add();
                                    }

                                }
                                //MessageBox.Show("Sucssfull..");
                            }
                        }
                    }

                }
            }
        }

        public bool login(string KeyPath)
        {
            bool result = false;
            FrmLogin frm =new FrmLogin();
            frm.KeyPathFiles = KeyPath;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                result = true;
                ChangeStatus(1);
                intSecurityCard();
                ProjBase.MdiParent.Text = ProjBase.ProgramName + " - " + ProjBase.GetFileName();
            }
            return result;
        }

        private void RToolExpression_Click(object sender, EventArgs e)
        {
            FrmFieldsName frm = new FrmFieldsName();
            frm.FileName = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (frm.ShowDialog() == DialogResult.OK)
                ChangeLanguge();
        }

        public void ChangeLanguge()
        {
            //this.Controls.Clear();
            //InitializeComponent();
            //this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            IntLanguage();
            //intControls();
            //ChangeStatus(1);
        }

        private void RToolChangeName_Click(object sender, EventArgs e)
        {
            if (new FrmReName().ShowDialog() == DialogResult.OK)
                ProjBase.MdiParent.Text = ProjBase.ProgramName + " - " + ProjBase.GetFileName();
        }

        private void RToolOption_Click(object sender, EventArgs e)
        {
            new FrmOptions().ShowDialog();
        }
        private void intSecurityCard() //MnuReNew MnuRepPayment
        {
          
            MnuCardPUser.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmCardUser().Name, "Open");        
            MnuSection.Enabled =  GSecurity.GetGSecurity(SecurityType.Card, new FrmCardSection().Name, "Open");          
            MnuChangePass.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmChangePassword().Name, "Open");
            MnuItem.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmCardItem().Name, "Open");
            MnuRepAgent.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmRepRestAgent().Name, "Open");
            MnuRepItem.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmRepRestItem().Name, "Open");
            MnuTotalSec.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmRepCharSec().Name, "Open");
            MnuTotalItem.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmRepCharItem().Name, "Open");
            MnuTotalTop.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmRepCharTop().Name, "Open");
            MnuInvoices.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmCardInvoices().Name, "Open");
            MnuRepInvoces.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmRepRestInvoices().Name, "Open");
            MnuRepFinal.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmRepRestFinal().Name, "Open");
            MnuRepDelivery.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmRepRestDelivery().Name, "Open");
            MnuEmployee.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmCardEmployee().Name, "Open");
          //  MnuSalMonth.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmBaseSalInf().Name, "Open");
            MnuSalIn.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmCardEmpSalInv().Name, "Open");
            MnuRepEmp.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmRepRestEmp().Name, "Open");
            MnuRepDelivNon.Enabled = GSecurity.GetGSecurity(SecurityType.Card, new FrmRepRestDeliveryNon().Name, "Open");
        }
      
       
     
     
        private void MnuCardPUser_Click(object sender, EventArgs e)
        {

            new FrmCardUser().Show();
        }
       
       
      
     
    

        private void ribbon1_Click(object sender, EventArgs e)
        {

        }

        


        private void MnuChangePass_Click(object sender, EventArgs e)
        {
            new FrmChangePassword().Show();
        }

        private void MnuSection_Click(object sender, EventArgs e)
        {
            new FrmCardSection().Show();
        }

        private void MnuItem_Click(object sender, EventArgs e)
        {
            new FrmCardItem().Show();
        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {
            new MainF().Show();
           // this.Close();
        }

        private void MnuRepAgent_Click(object sender, EventArgs e)
        {
            new FrmRepRestAgent().Show();
        }

        private void MnuRepItem_Click(object sender, EventArgs e)
        {
            new FrmRepRestItem().Show();
        }

        private void MnuTotalSec_Click(object sender, EventArgs e)
        {
            new FrmRepCharSec().Show();
        }

        private void MnuTotalItem_DoubleClick(object sender, EventArgs e)
        {

        }

        private void MnuTotalItem_Click(object sender, EventArgs e)
        {
            new FrmRepCharItem().Show();
        }

        private void MnuTotalTop_Click(object sender, EventArgs e)
        {
            new FrmRepCharTop().Show();
        }

        private void MnuInvoices_Click(object sender, EventArgs e)
        {
            new FrmCardInvoices().Show();
        }

        private void MnuRepInvoces_Click(object sender, EventArgs e)
        {
            new FrmRepRestInvoices().Show();
        }

        private void MnuRepFinal_Click(object sender, EventArgs e)
        {
            new FrmRepRestFinal().Show();
        }

        private void MnuRepDelivery_Click(object sender, EventArgs e)
        {
            new FrmRepRestDelivery().Show();
        }

        private void MnuEmployee_Click(object sender, EventArgs e)
        {
            new FrmCardEmployee().Show();
        }

        private void MnuSalMonth_Click(object sender, EventArgs e)
        {
           // new FrmBaseSalInf().Show();
        }

        private void MnuSalIn_ButtonMoreClick(object sender, EventArgs e)
        {

        }

        private void MnuSalIn_Click(object sender, EventArgs e)
        {
            new FrmCardEmpSalInv().Show();
        }

        private void MnuRepEmp_Click(object sender, EventArgs e)
        {
            new FrmRepRestEmp().Show();
        }

        private void MnuRepDelivNon_Click(object sender, EventArgs e)
        {
            new FrmRepRestDeliveryNon().Show();
        }

         
    }
}

