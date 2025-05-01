using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA
{
    internal class Ranchado
    {
        //DECLARACION DE VARIABLES
        private int idRnachado;
        private Usuario usuario;
        private Instancia instancia;

        //GETTERS AND SETTERS
        public int IdRnachado { get => idRnachado; set => idRnachado = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }
        internal Instancia Instancia { get => instancia; set => instancia = value; }

        //CONSTRUCTORES
        public Ranchado(int idRnachado, Usuario usuario, Instancia instancia)
        {
            this.idRnachado = idRnachado;
            this.usuario = usuario;
            this.instancia = instancia;
        }

        public Ranchado()
        {
        }

        //DECLALRACION DE METODOS


    }
}
