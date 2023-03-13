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

namespace GBase
{
    public partial class FrmBase : GControls.Forms.FBase
    {
        public bool ShowDialog { get; set; }
        public FrmBase()
        {
            InitializeComponent();
            ShowDialog = false;
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
          //  if (CBase.CurrentLanguage != null)
         //       Language = CBase.CurrentLanguage;
        }

        private void FrmBase_MinimumSizeChanged(object sender, EventArgs e)
        {
            if (ProjBase.MdiParent != null && (ShowDialog == false))
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
    }
}
