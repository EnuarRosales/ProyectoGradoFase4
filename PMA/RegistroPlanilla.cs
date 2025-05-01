using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA
{
    internal class RegistroPlanilla
    {
        //DECLARCION DE VARIABLES
        private int idRegistroPlanilla;
        private Ranchado ranchado;
        private string fechaRegistro;

        
        //DECLARACION DE CONSTRUCTORES
        public RegistroPlanilla(int idRegistroPlanilla, Ranchado ranchado, string fechaRegistro)
        {
            this.idRegistroPlanilla = idRegistroPlanilla;
            this.ranchado = ranchado;
            this.fechaRegistro = fechaRegistro;
        }

        public RegistroPlanilla()
        {
        }
        //DECLARACION DE GETTERS AND SETTERS

        public int IdRegistroPlanilla { get => idRegistroPlanilla; set => idRegistroPlanilla = value; }
        internal Ranchado Ranchado { get => ranchado; set => ranchado = value; }
        public string FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }

    }

    //DECLARACION DE METODOS




}
