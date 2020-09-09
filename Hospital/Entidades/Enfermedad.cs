using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfermedad
    {
        string nombre;
        string[] sintomas;

        private Enfermedad()
        {
            sintomas = new string[4];
        }

        public Enfermedad(string p_nombre):this()
        {
            this.nombre = p_nombre;
        }

        public Enfermedad(string p_nombre, string[] p_sintomas) : this(p_nombre)
        {
            this.sintomas = p_sintomas;
        }
    }
}
