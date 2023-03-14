using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        Form3 v = new Form3();
        Form1 n = new Form1();
        public Form4()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void vENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.MdiParent = this;
            v.Show();
        }

        private void nOMINAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n.MdiParent=this;
            n.Show();
        }
    }
}
