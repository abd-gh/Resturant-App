using GProjects.Class;
using GProjects.Frm;
using KagattiResturant.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Hard_Number;
using System.Globalization;
using System.Data.SqlClient;
using GBase.Frm;
using Microsoft.SqlServer.Management.Smo;

namespace KagattiResturant.Frm
{
    public partial class FrmLogin : FrmBase
    {
        public static string HardNumber;
        public static string UName;
        public string KeyPathFiles { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        public override void IntLanguage()
        {
            string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (lng == "Ar")
            {
                ProjBase.CurrentLanguage.GetValue(Btn_Cancel);
                ProjBase.CurrentLanguage.GetValue(Btn_OK);
                ProjBase.CurrentLanguage.GetValue(L_Login_info);
                ProjBase.CurrentLanguage.GetValue(L_Password);
                ProjBase.CurrentLanguage.GetValue(Btn_Cancel);
                base.IntLanguage();
            }
        }

        public override void intControls()
        {
            Btn_OK.Image = ImageListBase16.Images["true"];
            Btn_Cancel.Image = ImageListBase16.Images["Cancel"];
            base.intControls();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            int ProgramVersion = int.Parse(ProjBase.GetProgramVersion(ProjBase.ProgramName).Replace(".", ""));
            if (ProgramVersion == 0)
            {
                if (new FrmUpGradeDB().ShowDialog() == DialogResult.OK)
                { }
                else
                { DialogResult = DialogResult.Cancel; return; }
            }


            if (GUsers.GetCountUser() < 1)
            {
                L_Login_info.Text = "Create User Admin ";
            }
            TUserName.Text = CRegistry.RegistryGetValue(KeyPathFiles, "UserName");
            if (TUserName.Text != "")
            {
                TPassword.TabIndex = 0;
                TUserName.TabIndex = 1;
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {

            UName = TUserName.Text;
            if (GUsers.GetCountUser() == 0)
            {
                if (TUserName.Text == "")
                    GControls.Message.MSBox.Show("Enter UserName And Password", new Exception());
                else
                {
                    GUsers user = new Class.GUsers();
                    user.LoginName = TUserName.Text;
                    user.Password = TPassword.Text;
                    user.IsAdmin = true;

                    user.Add();
                }
            }

            //start active

            HardDrive hd = new HardDrive();
            string a = Options.GetOptionRegistry("ActDate", "DFG", "ASAEEACQ").ToString();
            DateTime Today = DateTime.Now;
            string year = Today.Year.ToString();
            string month = Today.Month.ToString();
            string day = Today.Day.ToString();
            if (month.Length == 1)
            {
                month = "0" + month;
            }
            if (day.Length == 1)
            {
                day = "0" + day;
            }
            // string today = day + '/' + month + '/' + year;
            //      Today = DateTime.ParseExact(today, "dd/mm/yyyy", CultureInfo.);
            //       today =DateTime.Parse(m);
            ArrayList hardDriveDetails = new ArrayList();
            string hash = "";


            ManagementObjectSearcher moSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject wmi_HD in moSearcher.Get())
            {
                hd.Model = wmi_HD["Model"].ToString();
                hd.Type = wmi_HD["InterfaceType"].ToString();
                hd.SerialNo = wmi_HD["SerialNumber"].ToString();
                hardDriveDetails.Add(hd);
                hash = hd.SerialNo;
                HardNumber = hd.SerialNo;
            }
            hash = hd.CalculateMD5Hash(hash);
            //SqlCommand Comm = ProjBase.Conn.CreateCommand();
            //Comm.CommandText = "Select Count(*) from HotelReservation ";
            //string Result = Comm.ExecuteScalar().ToString();
            string hrh = Options.GetOptionRegistry("Active", "AMC", "123").ToString();
            if (hrh == "123")
            {
                MessageBox.Show("you should activate your program");
                FrmAct fr = new FrmAct();
                fr.Show();
            }
            else if (Options.GetOptionRegistry("Active", "AMC", "123").ToString() != hash)
            {
                MessageBox.Show("sorry...but you changed your hard disk");
                FrmAct fr = new FrmAct();
                fr.Show();
            }
            else if (Options.GetOptionRegistry("Active", "AMC", "123").ToString() == hash)
            {
                if (a != "KAGTWMLI")
                {
                    a = hd.NonDate(a);
                    char[] z = a.ToCharArray();
                    string d = "", m = "", y = "";
                    for (int i = 0; i < z.Length; i++)
                    {
                        if (i < 2)
                        { d += (z[i]); }
                        if (i > 2 && i < 5)
                        { m += (z[i]); }
                        if (i > 5)
                        { y += (z[i]); }
                    }
                    //  DateTime dt = DateTime.ParseExact(a, "dd/mm/yyyy", CultureInfo.InvariantCulture);
                    //if (Convert.ToDateTime(a) <= Convert.ToDateTime(today))
                    //if (dt.Date < Today.Date)
                    if ((Convert.ToInt32(y) < Convert.ToInt32(year)) || (Convert.ToInt32(y) == Convert.ToInt32(year) && Convert.ToInt32(m) < Convert.ToInt32(year) && Convert.ToInt32(d) < Convert.ToInt32(day)) || (Convert.ToInt32(y) == Convert.ToInt32(year) && Convert.ToInt32(m) == Convert.ToInt32(year) && Convert.ToInt32(d) < Convert.ToInt32(day)))
                    {
                        MessageBox.Show("Sorry... but the program has expired");
                        FrmAct fr = new FrmAct();
                        fr.Show();
                    }
                    else if (GUsers.Login(TUserName.Text, TPassword.Text))
                    {
                        int Versions = int.Parse(ProjBase.Versions.Replace(".", ""));
                        int ProgramVersion = int.Parse(ProjBase.GetProgramVersion(ProjBase.ProgramName).Replace(".", ""));
                        if (Versions > ProgramVersion)
                        {
                            if (GControls.Message.MSBox.Show(ProjBase.CurrentLanguage.GetValue("The old database version should be updated"), ProjBase.CurrentLanguage.GetValue("UpGradeDB"), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                if (new FrmUpGradeDB().ShowDialog() == DialogResult.OK)
                                { DialogResult = DialogResult.OK; return; }
                                else
                                { DialogResult = DialogResult.Cancel; return; }

                            }
                            else
                            { DialogResult = DialogResult.Cancel; return; }
                        }
                        else if (Versions < ProgramVersion)
                        {
                            GControls.Message.MSBox.Show(ProjBase.CurrentLanguage.GetValue("The rule is related to the latest version Please check the copy version number ") + ProjBase.GetProgramVersion(), ProjBase.CurrentLanguage.GetValue("Error"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DialogResult = DialogResult.Cancel; return;
                        }
                        CRegistry.RegistrySetValue(KeyPathFiles, "UserName", TUserName.Text);
                        DialogResult = DialogResult.OK; return;
                    }
                    else
                    {
                        TPassword.Text = "";
                        TUserName.Focus();
                    }
                }

                else
                {
                    if (GUsers.Login(TUserName.Text, TPassword.Text))
                    {
                        int Versions = int.Parse(ProjBase.Versions.Replace(".", ""));
                        int ProgramVersion = int.Parse(ProjBase.GetProgramVersion(ProjBase.ProgramName).Replace(".", ""));
                        if (Versions > ProgramVersion)
                        {
                            if (GControls.Message.MSBox.Show(ProjBase.CurrentLanguage.GetValue("The old database version should be updated"), ProjBase.CurrentLanguage.GetValue("UpGradeDB"), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                if (new FrmUpGradeDB().ShowDialog() == DialogResult.OK)
                                { DialogResult = DialogResult.OK; return; }
                                else
                                { DialogResult = DialogResult.Cancel; return; }

                            }
                            else
                            { DialogResult = DialogResult.Cancel; return; }
                        }
                        else if (Versions < ProgramVersion)
                        {
                            GControls.Message.MSBox.Show(ProjBase.CurrentLanguage.GetValue("The rule is related to the latest version Please check the copy version number ") + ProjBase.GetProgramVersion(), ProjBase.CurrentLanguage.GetValue("Error"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DialogResult = DialogResult.Cancel; return;
                        }
                        CRegistry.RegistrySetValue(KeyPathFiles, "UserName", TUserName.Text);
                        DialogResult = DialogResult.OK; return;
                    }
                    else
                    {
                        TPassword.Text = "";
                        TUserName.Focus();
                    }
                }

            }


            //without active

            //if (GUsers.Login(TUserName.Text, TPassword.Text))
            //{
            //    int Versions = int.Parse(ProjBase.Versions.Replace(".", ""));
            //    int ProgramVersion = int.Parse(ProjBase.GetProgramVersion(ProjBase.ProgramName).Replace(".", ""));
            //    if (Versions > ProgramVersion)
            //    {
            //        if (GControls.Message.MSBox.Show(ProjBase.CurrentLanguage.GetValue("The old database version should be updated"), ProjBase.CurrentLanguage.GetValue("UpGradeDB"), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //        {
            //            if (new FrmUpGradeDB().ShowDialog() == DialogResult.OK)
            //            { DialogResult = DialogResult.OK; return; }
            //            else
            //            { DialogResult = DialogResult.Cancel; return; }

            //        }
            //        else
            //        { DialogResult = DialogResult.Cancel; return; }
            //    }
            //    else if (Versions < ProgramVersion)
            //    {
            //        GControls.Message.MSBox.Show(ProjBase.CurrentLanguage.GetValue("The rule is related to the latest version Please check the copy version number ") + ProjBase.GetProgramVersion(), ProjBase.CurrentLanguage.GetValue("Error"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        DialogResult = DialogResult.Cancel; return;
            //    }
            //    CRegistry.RegistrySetValue(KeyPathFiles, "UserName", TUserName.Text);
            //    DialogResult = DialogResult.OK; return;
            //}
            //else
            //{
            //    TPassword.Text = "";
            //    TUserName.Focus();
            //}
        }
        static void SetName(string UName)
        {
            // UName=  TUserName.Text;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
