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
    public partial class FrmReporteHabitacion : Form
    {
        public FrmReporteHabitacion()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //SE INSTANCIA FORMULARIO PARA EL REPORTE        

            FrmAsignacionHabitacion frmAsignacionHabitacion = new FrmAsignacionHabitacion();
            frmAsignacionHabitacion.Show();
            Hide();

        }
    }
}
