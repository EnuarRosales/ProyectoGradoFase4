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
    public partial class FrmSalidaProdcuto : Form
    {
        public FrmSalidaProdcuto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuTienda inicio = new FrmMenuTienda();
            inicio.Show();
            Hide();
        }
    }
}
