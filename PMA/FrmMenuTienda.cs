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
    public partial class FrmMenuTienda : Form
    {
        public FrmMenuTienda()
        {
            InitializeComponent();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            // this.Hide();

            FrmProducto inicio = new FrmProducto();
            inicio.Show();
            Hide();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            FrmTienda inicio = new FrmTienda();
            inicio.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSalidaProdcuto inicio = new FrmSalidaProdcuto();
            inicio.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            Hide();
        }
    }
}
