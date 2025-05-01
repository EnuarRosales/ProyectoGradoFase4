using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA
{
    internal class Producto
    {
        //DECLARACION DE LAS VARIABLES
        private int idProducto;
        private string nombreProducto;
        private string fechaCaducidad;

        //GETTERS ANS SETTERS
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string FechaCaducidad { get => fechaCaducidad; set => fechaCaducidad = value; }

        //CONSTRCUTORES
        public Producto(int idProducto, string nombreProducto, string fechaCaducidad)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.fechaCaducidad = fechaCaducidad;
        }

        public Producto()
        {
        }

        //DEFINICION DE LOS METODOS
    }
}
