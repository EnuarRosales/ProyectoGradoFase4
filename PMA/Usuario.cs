using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA
{
    internal class Usuario
    {
        //DECLARACION DE VARIABLES 

        private string codigoMilitar;
        private string grado;
        private string nombre;
        private string telefono;
        private string unidadMilitar;
        private string claveSistema;


        //GETTER AND SETTERS
        public string CodigoMilitar { get => codigoMilitar; set => codigoMilitar = value; }
        public string Grado { get => grado; set => grado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string UnidadMilitar { get => unidadMilitar; set => unidadMilitar = value; }
        public string ClaveSistema { get => claveSistema; set => claveSistema = value; }

        // METODOS CONSTRUCTOR 
        public Usuario(string codigoMilitar, string grado, string nombre, string telefono, string unidadMilitar, string claveSistema)
        {
            this.codigoMilitar = codigoMilitar;
            this.grado = grado;
            this.nombre = nombre;
            this.telefono = telefono;
            this.unidadMilitar = unidadMilitar;
            this.claveSistema = claveSistema;
        }

        public Usuario()
        {
        }

        //metodo para la autenticacion de los usuarios
        public bool Login(string c)
        {

            if (claveSistema == c)
            {
             
                return true;

            }
            else
            {            
               return false;
            }

        }










        //DECLARACION DE METODOS

        //metodo para la autenticacion de los usuarios





    }
}
