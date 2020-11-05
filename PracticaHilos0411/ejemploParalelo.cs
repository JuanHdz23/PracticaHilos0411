using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PracticaHilos0411
{
    public partial class ejemploParalelo : Form
    {
        public ejemploParalelo()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        Thread hilo;
        Thread hilo2;

        private void btn_contar_Click(object sender, EventArgs e)
        {
            hilo = new Thread(contador);
            hilo.Start();

            hilo2 = new Thread(new ThreadStart(reloj));
            hilo2.IsBackground = true;
            hilo2.Start();
        }

        public void contador()
        {
            Int64 x = 0;
            Int64 y = 0;

            for (x = 1; x <= 2000000000; x++)
            {
                y = y + x;
            }

            lb_resultado.Text = Convert.ToString(y);
        }

        public void reloj()
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int contador = Convert.ToInt32(lb_contar.Text);
            contador = contador + 1;
            lb_contar.Text = contador.ToString();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta es la prueba paralela");
        }
    }
}
