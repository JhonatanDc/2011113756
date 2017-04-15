using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756.Entities
{
   public class Persona
    {
        protected String nombre = "";
        protected String apellido = "";
        protected int edad = 0;

        public Persona(String nombre , String apellido , int edad) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        } 

        public String Nombre {

            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido
        {

            get { return apellido; }
            set { apellido = value; }
        }

        public int Edad
        {

            get { return edad; }
            set { edad = value; }
        }

    }
}
