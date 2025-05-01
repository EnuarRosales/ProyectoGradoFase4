using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA
{
    internal class Menu
    {

        //DECLARACION DE VARIABLES

        private int idMenu;
        private string tipoComida;
        private double  costo;
        private string descripcion;
        private string fechaInicio;
        private string fechaTermino;


        //CONSTRUCTORES
        public Menu()
        {
        }              

        public Menu(int idMenu, string tipoComida, double costo, string descripcion, string fechaInicio, string fechaTermino)
        {
            this.idMenu = idMenu;
            this.tipoComida = tipoComida;
            this.costo = costo;
            this.descripcion = descripcion;
            this.fechaInicio = fechaInicio;
            this.fechaTermino = fechaTermino;
        }


        //GETTER AND SETTERS
        public int IdMenu { get => idMenu; set => idMenu = value; }
        public string TipoComida { get => tipoComida; set => tipoComida = value; }
        public double Costo { get => costo; set => costo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string FechaTermino { get => fechaTermino; set => fechaTermino = value; }
    }

    //DECLARACION DE LOS METODOS 



}
