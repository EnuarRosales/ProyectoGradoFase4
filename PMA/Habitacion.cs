using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA
{
    internal class Habitacion
    {

        //DECLARACION DE VARIABLES
        private int id_habitacion;
        private string nombre;
        private float costoServicio;
        private int periodicidadPago;
        private int capacidadUsuarios;


        //GETTERS AND SETTERS
        public int Id_habitacion { get => id_habitacion; set => id_habitacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float CostoServicio { get => costoServicio; set => costoServicio = value; }
        public int PeriodicidadPago { get => periodicidadPago; set => periodicidadPago = value; }
        public int CapacidadUsuarios { get => capacidadUsuarios; set => capacidadUsuarios = value; }

        //DECLACIOND DE CONSTRUCTOR
        public Habitacion(int id_habitacion, string nombre, float costoServicio, int periodicidadPago, int capacidadUsuarios)
        {
            this.id_habitacion = id_habitacion;
            this.nombre = nombre;
            this.costoServicio = costoServicio;
            this.periodicidadPago = periodicidadPago;
            this.capacidadUsuarios = capacidadUsuarios;
        }

        public Habitacion()
        {
        }

        //METODOS






    }
}
