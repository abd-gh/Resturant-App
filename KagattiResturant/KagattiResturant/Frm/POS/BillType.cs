using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KagattiResturant
{
    public partial class BillType : Form
    {
        public KagattiResturant.MainF.AddTypeBill AddType;
        public BillType()
        {
            InitializeComponent();
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            AddType(true,TNotes.Text);
            this.Close();
        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            AddType(false,TNotes.Text);
            this.Close();
        }
    }
}
