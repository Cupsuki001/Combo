namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXBapellido.Text = "";
            TXBnombre.Text = "";
            MASKEDingreso.Text = "";
            MASKEDsalario.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TXBnombre.Text == "") 
            {
                MessageBox.Show("INGRESE EL NOMBRE");
                TXBnombre.Focus();
            }
            else 
            {
               if(TXBapellido.Text == "")
               {
                    MessageBox.Show("INGRESE EL APELLIDO");
                    TXBapellido.Focus();
               }
               else 
               {
                    double sal = Convert.ToDouble(MASKEDsalario.Text);
                    int a�o = Convert.ToInt32(MASKEDingreso.Text);

                    if(sal >= 4000 && sal <= 500000) 
                    {
                       if(a�o >= 1963 && sal <= 2023) 
                       {
                           
                       }
                       else 
                       {
                            MessageBox.Show("eL A�O TIENE QUE ESTAR ENTRE 1963 HASTA 2023");
                            MASKEDingreso.Focus();   
                       }    
                    }
                    else 
                    {
                        MessageBox.Show("el salario tiene que ser entre 4,000 o 500,000");
                        MASKEDsalario.Focus();
                    }
               }
            }
        }
    }
}