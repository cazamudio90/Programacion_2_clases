using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        string nombre;
        string apellido;
        int dni;

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Apellido
        {
            get { return this.apellido;  }
        }

        public int Dni
        {
            get { return this.dni;  }
        }

        public Persona(string p_nombre, string p_apellido, int p_dni)
        {
            this.nombre = p_nombre;
            this.apellido = p_apellido;
            this.dni = p_dni;
        }
    }
}
