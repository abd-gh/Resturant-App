using Hard_Number;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Collections;

namespace Kagatti_Active
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HardDrive hd = new HardDrive();
            string hash = "";
            ManagementObjectSearcher moSearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            ArrayList hardDriveDetails = new ArrayList();
            foreach (ManagementObject wmi_HD in moSearcher.Get())
            {
                hd.Model = wmi_HD["Model"].ToString();
                hd.Type = wmi_HD["InterfaceType"].ToString();
                hd.SerialNo = wmi_HD["SerialNumber"].ToString();
                hardDriveDetails.Add(hd);
                hash = hd.SerialNo;
              //  HardNumber = hd.SerialNo;
            }
            textBox1.Text = hash;
        }

        private void btnCalculat_Click(object sender, EventArgs e)
        {
            HardDrive hd = new HardDrive();
           string hard_hash= hd.CalculateMD5Hash(textBox1.Text);
           string date_hash;
           DateTime date = DateTime.Parse(TendDate.Text);
            
            if(checkBox1.Checked==true)
            {
                date_hash = "KAGTWMLI";
            }
            else
            {
                string year = date.Year.ToString();
                string month = date.Month.ToString();
                string day = date.Day.ToString();
                if(month.Length==1)
                {
                    month = "0" + month;
                }
                if (day.Length == 1)
                {
                    day = "0" + day;
                }
                string Date=day+'/'+month+'/'+year;
                date_hash = hd.Hashing(Date);
            }
            textBox2.Text = hard_hash + date_hash;
        }
    }
}
