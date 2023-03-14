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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(TXBusuario.Text);
            string b = Convert.ToString(TXBcontra.Text);

            if (a == "" && b == "")
            {
                MessageBox.Show("ERROR,NO PUEDE ESTAR EN BLANCO ,INGRESE LOS DATOS CORRESPONDIENTE ");
                TXBusuario.Focus();
            }
            else if (a == "jeremy78" && b == "")
            {
                MessageBox.Show("INGRESE LA CONTRASEÑA PARA ACCEDER :(");
                TXBcontra.Focus();
            }
            else if (a == "" && b == "Soul2004")
            {
                MessageBox.Show("INGRESE EL USUARIO PARA ACCEDER :(");
                TXBusuario.Focus();
            }
            else if (a == "jeremy78" && b != "Soul2004")
            {
                MessageBox.Show("LA CONTRASEÑA ES INCORRECTA :(");
                TXBcontra.Text = "";
                TXBcontra.Focus();
            }
            else if (a != "jeremy78" && b == "Soul2004")
            {
                MessageBox.Show("EL USUARIO ES INCORRECTA :(");
                TXBusuario.Text = "";
                TXBusuario.Focus();
            }
            else if (a != "jeremy78" && b != "Soul2004")
            {
                MessageBox.Show("LA CONTRASEÑA Y EL USUARIO ES INCORRECTO :(");
                TXBcontra.Text = "";
                TXBcontra.Focus();
                TXBusuario.Text = "";
                TXBusuario.Focus();
            }
            else if (a == "jeremy78" && b == "Soul2004")
            {
                Form4 j = new Form4();
                j.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
