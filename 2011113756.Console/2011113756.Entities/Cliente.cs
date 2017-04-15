using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756.Entities
{
    class Cliente:Persona
    {
        private int dni = 0;

        public Cliente(String nombre, String apellido, int edad, int dni) : base(nombre,apellido,edad) {

            this.dni = dni;
        }

        public int Dni
        {

            get { return dni; }
            set { dni = value; }
        }
    }
}
