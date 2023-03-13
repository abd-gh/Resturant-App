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
//using GBase.Class;
using System.Management;
using Hard_Number;
using System.Collections;
using KagattiResturant.Frm;
using KagattiResturant.Class;
using MySql.Data.MySqlClient;

namespace GBase.Frm
{
    public partial class FrmAct : GControls.Forms.FBase
    {
       
        string hash = "";
        string hardnumber = "";
        ArrayList hardDriveDetails = new ArrayList();

        public bool ShowDialog { get; set; }
        public FrmAct()
        {
            InitializeComponent();
            ShowDialog = false;
        }

        private void FrmAct_Load(object sender, EventArgs e)
        {
            LHardNumber.Text = FrmLogin.HardNumber;
        }
        //public void vis(int i)
        //{
        //    if(i==1)
        //    {
        //        textBox1.Hide();
        //        textBox2.Hide();
        //        textBox3.Hide();
        //        textBox4.Hide();
        //        textBox5.Hide();
        //        LHardNumber.Hide();
        //        BtnActiveWeb.Hide();
        //        BtnSave.Hide();
        //        label1.Hide();
        //        label2.Hide();
        //        label3.Text = "The Program is Activeted";
        //    }
        //    else
        //    {
               
        //    }
        //}
        private void FrmAct_MinimumSizeChanged(object sender, EventArgs e)
        {
            if (CBase.MdiParent != null && (ShowDialog == false))
                this.MdiParent = CBase.MdiParent;
        }

        public override void IntLanguage()
        {
            if (CBase.CurrentLanguage != null)
                this.Text = CBase.CurrentLanguage.GetValue(this.Text);
            base.IntLanguage();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string hard, dat;
                    //, nd, nb, hrd;
                string Act = textBox1.Text;
                //+textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text;
                HardDrive hd = new HardDrive();
                hard = hd.NonHardDisk(Act);
                dat = hd.HashDate(Act);
                //nd = hd.NumDate(Act);
                //nb = hd.NumPayment(Act);
                //hrd = hd.NonHardDisk(Act);
                Options.SetOptionRegistry("Active", "AMC", hard);
                //Options.SetOptionRegistry("ActBill", "NOE", b);
                Options.SetOptionRegistry("ActDate", "DFG", dat);
                //Options.SetOptionRegistry("NBill", "QWZ", nb);
                //Options.SetOptionRegistry("NDate", "YIP", nd);

                //("Active", "GetActive", "123").ToString();
                //string ActDate = Options.GetOptionRegistry("ActDate", "GetDate", "0").ToString();
                //string ActBill = Options.GetOptionRegistry("ActBill", "GetBill", "0").ToString();
                //string NBill = Options.GetOptionRegistry("NBill", "GetNBill", "1").ToString();
                //string NDate = Options.GetOptionRegistry("NDate", "GetNDate", "1")
                this.Close();
            }else
            {
                MessageBox.Show("Please Insert Key");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmWebActive f = new FrmWebActive();
            f.Show();

            //hardnumber = FrmLogin.HardNumber;
            //DBConnect m = new DBConnect();
            //m.Insert("insert into keygen "
            //+"(Address,Country,date,DateEdit,DateOrder,DateShow,Email,End_Date,hdd,hddkey,IsActive,IsWait,Name,Note,Phone,QtyOpen,Remark,TypePro)"
            //+ " values ('adress' , 'country' , '05/09/2018' , '05/09/2018' ,'05/09/2018' ,'05/09/2018','email','05/09/2018', '"+hardnumber+"' , "
            //+ "'',0,0,'mamon','notes','00963','0','remark',6)");

        }
    }
}
