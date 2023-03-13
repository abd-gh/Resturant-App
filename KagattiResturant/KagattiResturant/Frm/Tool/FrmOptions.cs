using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using GProjects.Class;
using System.Threading.Tasks;
using System.Windows.Forms;
using KagattiResturant.Class;
using GBase.Frm;
using System.Data.SqlClient;
using System.Collections;
using System.Management;
using Hard_Number;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;

namespace KagattiResturant.Frm.Tool
{
    public partial class FrmOptions : GProjects.Frm.FrmBase
    {
        string LastLang = "";
        public FrmOptions()
        {
            InitializeComponent();
        }

        public override void IntLanguage()
        {           
            string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (lng == "Ar")
            {
                
                ProjBase.CurrentLanguage.GetValue(LLanguage);
                ProjBase.CurrentLanguage.GetValue(LStyle);
                ProjBase.CurrentLanguage.GetValue(BtnClose);
                ProjBase.CurrentLanguage.GetValue(BtnSave);
                ProjBase.CurrentLanguage.GetValue(xButton1);
                ProjBase.CurrentLanguage.GetValue(xButton2);
                ProjBase.CurrentLanguage.GetValue(btnPrint);
                ProjBase.CurrentLanguage.GetValue(LCounter);
                ProjBase.CurrentLanguage.GetValue(LCompany);
                ProjBase.CurrentLanguage.GetValue(Lprinter);
                ProjBase.CurrentLanguage.GetValue(labelX1);
                ProjBase.CurrentLanguage.GetValue(LActivePrint2);
                groupBox1.Text = ProjBase.CurrentLanguage.GetValue(groupBox1.Text);
                xButton3.Text = ProjBase.CurrentLanguage.GetValue(xButton3.Text);
              
                TBase.Text = ProjBase.CurrentLanguage.GetValue(TBase.Text);
                PGBaseInfo.Text = ProjBase.CurrentLanguage.GetValue(PGBaseInfo.Text);               
                THotelOption.Text = ProjBase.CurrentLanguage.GetValue(THotelOption.Text);
                TSoftPhone.Text = ProjBase.CurrentLanguage.GetValue(TSoftPhone.Text);
                LCompany.Text = ProjBase.CurrentLanguage.GetValue(LCompany.Text);
            }
            base.IntLanguage();
        }

        public override void intControls()
        {
            foreach (var item in Enum.GetValues(typeof(Stimulsoft.Controls.Win.DotNetBar.eStyle)))
                CBStyle.Items.Add(item);

            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                combPrinter.Items.Add(printer);
            TLanguage.Items.Add("En");
            TLanguage.Items.Add("Ar");
            base.intControls();
        }
        public string RepName { get; set; }
        private void FrmOptions_Load(object sender, EventArgs e)
        {
            try
            {
                RepName = GControls.Class.CBaseClass.Getpath() + "\\CustRep\\RepPrint\\" + "MainF" + ".mrt";
                if (!File.Exists(RepName))
                    File.Copy(GControls.Class.CBaseClass.Getpath() + "\\Base Rep\\BRep.mrt", RepName);
                Rep.Load(RepName);
            }
            catch (Exception)
            {

            }

            GetData();
        }

        private void GetData()
        {
            GetDataBase();
           
        }
        private void GetDataBase()
        {
            CBStyle.Text = Options.GetOptionRegistry("Style", "CBStyle", Stimulsoft.Controls.Win.DotNetBar.eStyle.VisualStudio2010Blue.ToString()).ToString();
            CBStyle.SelectedText = Options.GetOptionRegistry("Style", "CBStyle", Stimulsoft.Controls.Win.DotNetBar.eStyle.VisualStudio2010Blue.ToString()).ToString();
            TLanguage.Text = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            combPrinter.Text = Options.GetOptionRegistry("PrinterName", "GetPrinterName", " ").ToString();
            TTax.Text = Options.GetOptionRegistry("Tax", "GetTax","0.8").ToString();
            LastLang = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            TCompany.Text = Options.GetOptionRegistry("CompanyName", "GetCompany", "Kagatti").ToString();
            CActivPrint2.Checked = bool.Parse(Options.GetOptionRegistry("ActPrinter2", "GetActPrinter2", false).ToString());
            //Timer.Checked=bool.Parse(Options.GetOptionRegistry("Timer", "GetTimer",false).ToString());
            //dateTimePicker1.Text = Options.GetOptionRegistry("Time", "GetTime", "12:00 PM").ToString();
            //Treturntax.Text = Options.GetOptionRegistry("ReturnTax", "GetReturnTax", "0.6").ToString();
            TCounter.Text = Options.GetOptionRegistry("Counter", "GetCounter", "0").ToString();
            string Active = Options.GetOptionRegistry("Active", "AMC", "123").ToString();
            string ActDate = Options.GetOptionRegistry("ActDate", "DFG", "BBFJRXDH").ToString();
            //string ActBill = Options.GetOptionRegistry("ActBill", "NOE", "1M ").ToString();
            //string NBill = Options.GetOptionRegistry("NBill", "QWZ", "1").ToString();
            //string NDate = Options.GetOptionRegistry("NDate", "YIP", "1").ToString();

        }
      
      

        private void SetData()
        {
           
            SetDataBase();
          
        }
        private void SetDataBase()
        {
            //OPtionForAll
            if (CBStyle.SelectedItem != null)
                Options.SetOptionRegistry("Style", "CBStyle", CBStyle.SelectedItem.ToString());
            if (TLanguage.SelectedItem != null)
                Options.SetOptionRegistry("Language", "CurentLanguage", TLanguage.SelectedItem);
            if (TTax.Text != null)
                Options.SetOptionRegistry("Tax","GetTax", TTax.Text);
            if (combPrinter.Text != null)
                Options.SetOptionRegistry("PrinterName", "GetPrinterName",combPrinter.SelectedItem);
          //  if (Timer.Checked)
            //    Options.SetOptionRegistry("Timer", "GetTimer", Timer.Checked);
         //   Options.SetOptionRegistry("Time", "GetTime", dateTimePicker1.Text);
            if (TCounter.Text != null)
                Options.SetOptionRegistry("Counter", "GetCounter", TCounter.Text);
            if (LastLang != TLanguage.SelectedItem.ToString())
                CSamaHotel.ChangeLanguge();
            Options.SetOptionRegistry("CompanyName", "GetCompany", TCompany.Text);

            Options.SetOptionRegistry("ActPrinter2", "GetActPrinter2", CActivPrint2.Checked);

            
        }
      
  


        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("عزيزي العميل هناك بعض التعديلات تحتاج اغلاق البرنامج و اعادة تشغيله لكي تعمل ");
            SetData();
            
        }

        private void CBStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            CSamaHotel.styleManager.ManagerStyle = (Stimulsoft.Controls.Win.DotNetBar.eStyle)Enum.Parse(typeof(Stimulsoft.Controls.Win.DotNetBar.eStyle), CBStyle.SelectedItem.ToString());
        }

        private void TabOption_Click(object sender, EventArgs e)
        {

        }

        private void PGBaseInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBCPBase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LLanguage_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //HardDrive hd = new HardDrive();      
            //ArrayList hardDriveDetails = new ArrayList();
            //string hash = "";
            //ManagementObjectSearcher moSearcher = new
            //ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            //foreach (ManagementObject wmi_HD in moSearcher.Get())
            //{
            //    hd.Model = wmi_HD["Model"].ToString();
            //    hd.Type = wmi_HD["InterfaceType"].ToString();
            //    hd.SerialNo = wmi_HD["SerialNumber"].ToString();
            //    hardDriveDetails.Add(hd);
            //    hash = hd.SerialNo;
            //   // HardNumber = hd.SerialNo;
            //}
            //hash = hd.CalculateMD5Hash(hash);
            //if (Options.GetOptionRegistry("Active", "AMC", "123").ToString() == hash)
            //{

            //    //FrmActe fm = new FrmActe();
            //    //fm.ac(1);
            //    //fm.Show();
            //    FrmBasee b = new FrmBasee();
            //    b.ss(1);
            //    b.Show();
                           
            //}
            //else
            //{
               
               
            //}
        }

        private void Timer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string date = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            string x = exePath + "\\" + date + ".bak";
            Server dbServer=new Server(new ServerConnection( ProjBase.Conn.DataSource));
            Backup dbBackup = new Backup() { Action = BackupActionType.Database,Database = ProjBase.Conn.Database };
            dbBackup.Devices.AddDevice(x, DeviceType.File);
            dbBackup.Initialize = true;
           // dbBackup.PercentComplete += DbBackup_PercentComplete;
          //  dbBackup.Complete += DbBackup_Complete;
            dbBackup.SqlBackupAsync(dbServer);
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string q = "select ri.Name Name,ro.Single_Price price,ro.Count Count, ro.Total_Price Total,rb.Date time ,rb.Num Number,rb.Type Type  from RestOrder as ro inner join RestBill rb on rb.GUID=ro.Guid_RestBill inner join RestItem ri on ri.GUID=ro.Item_Name where ro.Guid_RestBill='" + CSamaHotel.CurrUser.guid.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(q, ProjBase.Conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "f");
            Rep.RegData(dataSet);
            Rep.Dictionary.Synchronize();    
            Rep.Design();
        }

        private void TTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            FrmAct f = new FrmAct();
            f.Show();
        }

        private void combPrinter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void xButton3_Click(object sender, EventArgs e)
        {
            try
            {
                RepName = GControls.Class.CBaseClass.Getpath() + "\\CustRep\\RepPrint\\" + "E_Pos" + ".mrt";
                if (!File.Exists(RepName))
                    File.Copy(GControls.Class.CBaseClass.Getpath() + "\\Base Rep\\BRep.mrt", RepName);
                Rep.Load(RepName);
                //
                string qe = "select ri.Name Name,ro.Single_Price price,ro.Count Count, rb.Total_Price Total," +
                                                " rb.Date time ,rb.Num Number,rb.Type Type " +
                                                "   from RestOrder as ro  " +
                                                "   inner join RestBill rb on rb.GUID=ro.Guid_RestBill " +
                                                "   inner join RestItem ri on ri.GUID=ro.Item_Name  " +
                                                "   inner join RestSection rs on rs.GUID=ri.Section_Name " ;
                                             //   "  where (ro.Guid_RestBill='" + GP.ToString() + "') " +
                                            //    "   and (rs.Printer='" + pn2 + "') ";

                SqlDataAdapter adapter = new SqlDataAdapter(qe, ProjBase.Conn);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "f");
                Rep.RegData(dataSet);
                Rep.Dictionary.Synchronize();
                Rep.Design();
            }
            catch (Exception)
            {

            }
        }
    }
}
