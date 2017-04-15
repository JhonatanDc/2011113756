using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756.Entities
{
    class Empleado:Persona
    {
        private int codigoEmpleado = 0;

        public Empleado(String nombre, String apellido, int edad, int codigoEmpleado) : base(nombre,apellido,edad) {

            this.codigoEmpleado = codigoEmpleado;
        }

        public int CodigoEmpleado
        {

            get { return codigoEmpleado; }
            set { codigoEmpleado = value; }
        }
    }
}
