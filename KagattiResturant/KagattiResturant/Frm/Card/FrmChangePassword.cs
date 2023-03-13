using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GProjects.Class;
using KagattiResturant.Class;
using System.Data.SqlClient;
using EnCryptDecrypt;

namespace GBase
{
    public partial class FrmChangePassword : GControls.Forms.FBase
    {
        public bool ShowDialog { get; set; }
        public FrmChangePassword()
        {
            InitializeComponent();
            ShowDialog = false;
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
          //  if (CBase.CurrentLanguage != null)
         //       Language = CBase.CurrentLanguage;
        
        }

        private void FrmChangePassword_MinimumSizeChanged(object sender, EventArgs e)
        {
            if (ProjBase.MdiParent != null && (ShowDialog==false))
                this.MdiParent = ProjBase.MdiParent;
        }

        public override void IntLanguage()
        {
            string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (lng == "Ar")
            {
                ProjBase.CurrentLanguage.GetValue(LNewPassword);
                ProjBase.CurrentLanguage.GetValue(LOldPassword);
                ProjBase.CurrentLanguage.GetValue(LConformPassword);
                ProjBase.CurrentLanguage.GetValue(btnSave);


                base.IntLanguage();
            }
        }

        private void PBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Guid g = CSamaHotel.CurrUser.guid;
            string x = TOldPassword.Text;
            string y = TNewPassword.Text;
            string z = TConformPassword.Text;
            SqlDataReader Dr;
            SqlCommand Comm = ProjBase.Conn.CreateCommand();
            Comm.CommandText = "Select * from GUsers Where Guid ='" + g + "'";
            Dr = Comm.ExecuteReader();
            Dr.Read();                   
            string pass = ValuesFix.GetValueString(Dr["Password"].ToString());
            Dr.Close();
            if (TOldPassword.Text !=""&& TNewPassword.Text !="" &&TConformPassword.Text != "")
            {

                if (pass == CryptorEngine.Encrypt(x, true))
                {
                    if (y == z)
                    {
                        string c = CryptorEngine.Encrypt(y, true);
                        using (SqlCommand cmmd = new SqlCommand("update GUsers set Password='" + c + "' where GUID='" + g + "'", ProjBase.Conn))
                        {
                            int rows = cmmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Change Password done is Successfully");
                      
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("new password don't conform....");
                    }
                }
                else
                {
                    MessageBox.Show("password is incorrect....");
                }
            }
            else
            {
                MessageBox.Show("Please enter all fields");
            }
        }
    }
}
