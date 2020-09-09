using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico
    {
        string nombre;
        string apellido;
        int dni;
        string especialidad;

        public Medico(string p_nombre, string p_apelldio, int p_dni, string p_especialidad)
        {
            this.nombre = p_nombre;
            this.apellido = p_apelldio;
            this.dni = p_dni;
            this.especialidad = p_especialidad;
        }
    }
}
