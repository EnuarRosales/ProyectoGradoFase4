using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA
{
    internal class Tienda
    {
        //DECLARACION DE VARIABLES 
        private int idTienda;
        private Producto producto;
        private double costo;
        private int cantidad;
        private string fechaingreso;

        //GETTERS AND SETTERS
        public int IdTienda { get => idTienda; set => idTienda = value; }
        internal Producto Producto { get => producto; set => producto = value; }
        public double Costo { get => costo; set => costo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Fechaingreso { get => fechaingreso; set => fechaingreso = value; }

        //METODOS CONSTRUCTORES
        public Tienda(int idTienda, Producto producto, double costo, int cantidad, string fechaingreso)
        {
            this.idTienda = idTienda;
            this.producto = producto;
            this.costo = costo;
            this.cantidad = cantidad;
            this.fechaingreso = fechaingreso;
        }

        public Tienda()
        {
        }


        //DECLARACIOND DE METODOS


    }
}
