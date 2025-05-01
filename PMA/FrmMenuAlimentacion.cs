using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMA
{
    public partial class FrmMenuAlimentacion : Form
    {
        public FrmMenuAlimentacion()
        {
            InitializeComponent();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            // this.Hide();

            FrmMenu inicio = new FrmMenu();
            inicio.Show();
            Hide();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            FrmInstancia inicio = new FrmInstancia();
            inicio.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRanchado inicio = new FrmRanchado();
            inicio.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this.Hide();

            FrmRegistroPlanilla inicio = new FrmRegistroPlanilla();
            inicio.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // this.Hide();

            Form1 inicio = new Form1();
            inicio.Show();
            Hide();

        }
    }
}
