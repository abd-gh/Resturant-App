using KagattiResturant.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KagattiResturant.Frm
{
    public partial class FrmWebActive : Form
    {
        public FrmWebActive()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string hardnumber = FrmLogin.HardNumber;
            string name = LName.Text;
            string phone = LPhone.Text;
            string email = LEmail.Text;
            string country = LCountry.Text;
            string address = LAddress.Text;
            string note = LNote.Text;
            string today=  DateTime.Now.ToString("yyyy/MM/dd");
            DBConnect m = new DBConnect();
            m.Insert("insert into keygen "
           + "(Address,Country,date,DateEdit,DateOrder,DateShow,Email,End_Date,hdd,hddkey,IsActive,IsWait,Name,Note,Phone,QtyOpen,Remark,TypePro)"
            + " values ('"+ address + "' , '"+ country + "' , '"+ today + "' ,'" + today + "' ,'" + today + "' ,'" + today + "','email','" + today + "', '" + hardnumber + "' , "
            + "'',0,0,'"+ name + "','"+note+"','"+ phone + "','0','remark',6)");
        }

        private void FrmWebActive_Load(object sender, EventArgs e)
        {
            LHardNumber.Text= FrmLogin.HardNumber;
        }
    }
}
