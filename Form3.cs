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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
          
            if (TXBnom.Text == "") 
            {
                MessageBox.Show("TIENE QUE INGRESAR EL NOMBRE");

                if (n != -1)
                {
                    dataGridView1.Rows.RemoveAt(n);
                }

            }
            else 
            {
                int cant = Convert.ToInt32(MASKEDcantidad.Text);
                double pre = Convert.ToDouble(MASKEDprecio.Text);
                double monto = Convert.ToDouble(TXBentregar.Text);
               if(cant >= 1  && cant <= 15) 
               {
                 if(pre>= 1 && pre <= 65000) 
                 {


                        if (treeView1.SelectedNode.Text.Equals("Cordoba"))
                        {
                            dataGridView1.Rows[n].Cells[0].Value = TXBnom.Text;
                            dataGridView1.Rows[n].Cells[1].Value = MASKEDcantidad.Text;
                            dataGridView1.Rows[n].Cells[2].Value = MASKEDprecio.Text;

                            double stp , stf , tf , tfpor , vlt;

                            stp = cant * pre;
                            stf = stp;
                            dataGridView1.Rows[n].Cells[3].Value = stp;
                            tfpor = stf * 0.15;
                            tf = stf + stf;
                            vlt = tf - monto;
                           
                            TXBstf.Text = stf.ToString();
                            TXBtotalf.Text = tf.ToString();
                            TXBvuelto.Text = vlt.ToString();

                        }
                        else if (treeView1.SelectedNode.Text.Equals("Dolares"))
                        {
                            dataGridView1.Rows[n].Cells[0].Value = TXBnom.Text;
                            dataGridView1.Rows[n].Cells[1].Value = MASKEDcantidad.Text;
                            dataGridView1.Rows[n].Cells[2].Value = MASKEDprecio.Text;

                            double stp , conv;
                            conv = pre / 36.5;

                            stp = cant * conv;
                            dataGridView1.Rows[n].Cells[3].Value = stp;
                        }
                        else if (treeView1.SelectedNode.Text.Equals("Credito")) 
                        {
                            dataGridView1.Rows[n].Cells[0].Value = TXBnom.Text;
                            dataGridView1.Rows[n].Cells[1].Value = MASKEDcantidad.Text;
                            dataGridView1.Rows[n].Cells[2].Value = MASKEDprecio.Text;

                            double stp;

                            stp = cant * pre;
                            dataGridView1.Rows[n].Cells[3].Value = stp;
                        }
                        else 
                        {
                            MessageBox.Show("Ingrese un metodo de pago");
                            if (n != -1)
                            {
                                dataGridView1.Rows.RemoveAt(n);
                            }
                        }


                    }
                 else 
                 {
                        MessageBox.Show("EL PRECIO DEBE SER DE 1 HASTA 65000");
                        MASKEDprecio.Focus();

                        if (n != -1)
                        {
                            dataGridView1.Rows.RemoveAt(n);
                        }
                    }
               }
               else 
               {
                    MessageBox.Show("LA CANTIDAD DEBE SER DE 1 HASTA 15");
                    MASKEDcantidad.Focus();

                    if (n != -1)
                    {
                        dataGridView1.Rows.RemoveAt(n);
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXBnom.Text = "";
            MASKEDcantidad.Text = "";
            MASKEDprecio.Text = "";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (treeView1.SelectedNode.Text.Equals("Cordoba"))
            {
                label2.Text = "Cordoba";
            }
            else if (treeView1.SelectedNode.Text.Equals("Dolares"))
            {
                label2.Text = "Dolares";
            }
            else if (treeView1.SelectedNode.Text.Equals("Credito"))
            {
                label2.Text = "Credito";
            }




        }

        private void Form3_Load(object sender, EventArgs e)
        {
            TXBvuelto.Enabled = false;
            TXBstf.Enabled = false;
        }
    }
}
