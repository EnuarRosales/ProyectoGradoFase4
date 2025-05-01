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
    public partial class FrmLoguin : Form
    {
        Usuario administrador = new Usuario("1086136444","CP","Enuar Rosales","3153149783","CGDJ6","123");

        
        public FrmLoguin()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (administrador.Login(txtContrasena.Text) == true)
            {
                Form1 inicio = new Form1();
                inicio.Show();
                Hide();
            }
            else
                MessageBox.Show("clave incorrecta coloca 123");

        }
    }
}
