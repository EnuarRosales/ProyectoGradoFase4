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
    public partial class FrmAsignacionHabitacion : Form
    {
        public FrmAsignacionHabitacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Hide();

            Form1 inicio = new Form1();
            inicio.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SE INSTANCIA FORMULARIO PARA EL REPORTE
            FrmHabitacion frmConfigurarHabitacion = new FrmHabitacion();
            frmConfigurarHabitacion.Show();
            Hide();

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            //SE INSTANCIA FORMULARIO PARA EL REPORTE        

            FrmReporteHabitacion frmReporteHabitacion = new FrmReporteHabitacion();
            frmReporteHabitacion.Show();
            Hide();
        }
    }
}
