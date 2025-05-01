using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA
{
    internal class Instancia
    {
        //DECLARACION DE VARIABLES

        private int idInstancia;
        private Menu menu;


        //DECLARACION DE GETTER AND SETTERS
        public int IdInstancia { get => idInstancia; set => idInstancia = value; }
        internal Menu Menu { get => menu; set => menu = value; }



        //DECLLARACION DE CONSTRUCTORES
        public Instancia(int idInstancia, Menu menu)
        {
            this.idInstancia = idInstancia;
            this.menu = menu;
        }

        public Instancia()
        {
        }

        //DECLARACION DE METODOS 

        
    }
}
