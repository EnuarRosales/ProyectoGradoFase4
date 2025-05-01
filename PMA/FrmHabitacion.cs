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
    public partial class FrmHabitacion : Form
    {
        public FrmHabitacion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SE INSTANCIA FORMULARIO PARA EL REPORTE        

            FrmAsignacionHabitacion frmAsignacionHabitacion = new FrmAsignacionHabitacion();
            frmAsignacionHabitacion.Show();
            Hide();

        }
    }
}
