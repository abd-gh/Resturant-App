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
    public partial class ControlGrid : Form
    {

        public KagattiResturant.MainF.AddItemDelegate AddItemCallback;
        public KagattiResturant.MainF.DelItemDelegate DelItemCallback;

        private int indexRow;
        public int IndexRow
        {
            get
            {
                return this.indexRow;
            }
            set
            {
                this.indexRow = value;
            }
        }
        MainF ths;
        public ControlGrid()
        {
            InitializeComponent();
            label1.TextChanged += new EventHandler(label1_TextChanged);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(label1.Text);
            if (num > 0)
            {
                label1.Text = (num + 1).ToString();
            }
            AddItemCallback(this.label1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(label1.Text);
            if (num > 0)
            {
                label1.Text = (num - 1).ToString();

            }
            AddItemCallback(this.label1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DelItemCallback();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
