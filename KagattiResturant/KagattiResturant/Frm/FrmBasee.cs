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

namespace KagattiResturant.Frm
{
    public partial class FrmBasee : GControls.Forms.FBase
    {
        public bool ShowDialog { get; set; }
        public FrmBasee()
        {
            InitializeComponent();
            ShowDialog = false;
        }

        private void FrmBasee_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
          //  if (CBase.CurrentLanguage != null)
         //       Language = CBase.CurrentLanguage;
        }

        private void FrmBasee_MinimumSizeChanged(object sender, EventArgs e)
        {
            if (ProjBase.MdiParent != null && (ShowDialog==false))
                this.MdiParent = ProjBase.MdiParent;
        }

        public override void IntLanguage()
        {
            if (ProjBase.CurrentLanguage != null)
                this.Text= ProjBase.CurrentLanguage.GetValue(this.Text);
            base.IntLanguage();
        }

        private void PBack_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ss(int ie)
        {
            if(ie==1)
            {
                button2.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBasee_MouseDown(object sender, MouseEventArgs e)
        {
            //if(e.Control == true)
         
        }

        private void FrmBasee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                button2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {          
            Options.SetOptionRegistry("NDate", "YIP", "1");
            Options.SetOptionRegistry("NBill", "QWZ", "1");
            Options.SetOptionRegistry("ActBill", "NOE", "1M ");
            Options.SetOptionRegistry("ActDate", "DFG", "ASAEEACQ");
            Options.SetOptionRegistry("Active", "AMC", "123");
            MessageBox.Show("Activation Canceled Successfully");
        }
    }
}
