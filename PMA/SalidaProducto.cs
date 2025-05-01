using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA
{
    internal class SalidaProducto
    {
        //DECLARACION DE VARIABLES
        private int idSalidaProducto;
        private Usuario usuario;
        private Producto producto;
        private string fechaVenta;
        private string tipoSalida;
        private double costo;

        //GETTERS AND SETTERS
        public int IdSalidaProducto { get => idSalidaProducto; set => idSalidaProducto = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }
        internal Producto Producto { get => producto; set => producto = value; }
        public string FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public string TipoSalida { get => tipoSalida; set => tipoSalida = value; }
        public double Costo { get => costo; set => costo = value; }

        //METODOS CONSTRUCTORES
        public SalidaProducto(int idSalidaProducto, Usuario usuario, Producto producto, string fechaVenta, string tipoSalida, double costo)
        {
            this.idSalidaProducto = idSalidaProducto;
            this.usuario = usuario;
            this.producto = producto;
            this.fechaVenta = fechaVenta;
            this.tipoSalida = tipoSalida;
            this.costo = costo;
        }

        public SalidaProducto()
        {
        }               

        //DECLARACION DE METODOS


    }
}
