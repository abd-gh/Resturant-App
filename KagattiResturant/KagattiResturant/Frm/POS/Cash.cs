using GBase;
using GProjects.Class;
using KagattiResturant.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KagattiResturant
{
    public partial class Cash : Form
    {
        public KagattiResturant.MainF.DeletDelvary DelDeliv;
        public KagattiResturant.MainF.CashDelivary CashDeliv;
        public Cash()
        {
            InitializeComponent();
        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            DelDeliv();
            this.Close();
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            CashDeliv();
            this.Close();
        }

        private void Cash_Load(object sender, EventArgs e)
        {
            //User Is Admin ?
            Guid User_Guid = CSamaHotel.CurrUser.guid;
            SqlDataReader DrU;
            SqlCommand CommU = ProjBase.Conn.CreateCommand();
            CommU.CommandText = " Select Isadmin from GUsers where Guid='" + User_Guid.ToString() + "' ";
            DrU = CommU.ExecuteReader();
            DrU.Read();
           bool User_IsAdmin = GBase.ValuesFix.GetValuebool(DrU["Isadmin"].ToString());
            DrU.Close();
            //End User Is Admin
            if(User_IsAdmin==false)
            {
                xButton2.Enabled = false;
            }
        }
    }
}
