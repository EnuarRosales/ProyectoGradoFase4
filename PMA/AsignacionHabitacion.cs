using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA
{
    internal class AsignacionHabitacion
    {
        //DECLARACION DE VARIABLES

        private int idAsignacionHabitacion;
        private Usuario codigoMilitar;
        private Habitacion idHabitacion;

        //GETTERS AND SETTERS
        public int IdAsignacionHabitacion { get => idAsignacionHabitacion; set => idAsignacionHabitacion = value; }
        internal Usuario CodigoMilitar { get => codigoMilitar; set => codigoMilitar = value; }
        internal Habitacion IdHabitacion { get => idHabitacion; set => idHabitacion = value; }

        //DECLARACION DE CONSTRUCTOR 
        public AsignacionHabitacion(int idAsignacionHabitacion, Usuario codigoMilitar, Habitacion idHabitacion)
        {
            this.idAsignacionHabitacion = idAsignacionHabitacion;
            this.codigoMilitar = codigoMilitar;
            this.idHabitacion = idHabitacion;
        }

        public AsignacionHabitacion()
        {
        }


        //DECLARACION DE METODOS






    }
}
