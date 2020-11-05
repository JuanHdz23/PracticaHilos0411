using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaHilos0411
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_contar_Click(object sender, EventArgs e)
        {
            timer1.Start();

            Int64 x = 0;
            Int64 y = 0;

            for (x = 1; x <= 2000000000; x++)
            {
                y = y + x;
            }

            lb_resultado.Text = Convert.ToString(y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int contador = Convert.ToInt32(lb_contar.Text);
            contador = contador + 1;
            lb_contar.Text = contador.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ejemploParalelo paralelo = new ejemploParalelo();
            paralelo.Show();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta es la prueba paralela");
        }
    }
}
