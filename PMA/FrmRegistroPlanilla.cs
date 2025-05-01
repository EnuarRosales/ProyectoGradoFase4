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
    public partial class FrmRegistroPlanilla : Form
    {
        public FrmRegistroPlanilla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this.Hide();

            FrmMenuAlimentacion inicio = new FrmMenuAlimentacion();
            inicio.Show();
            Hide();
        }
    }
}
