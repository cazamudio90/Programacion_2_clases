using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        string nombre;
        string apellido;
        int dni;
        Enfermedad dolencia;
        string descripcionDolecia;

        public Paciente(string p_nombre, string p_apellido, int p_dni, string p_descripcionDolecia)
        {
            this.nombre = p_nombre;
            this.apellido = p_apellido;
            this.dni = p_dni;
            this.descripcionDolecia = p_descripcionDolecia;
        }
        //public void SetEnfermedad(Enfermedad p_dolencia)
        //{
        //    this.dolencia = p_dolencia;
        //}

        public Enfermedad Dolencia
        {
            set { dolencia = value; }
            get { return dolencia;  }
        }

        public static bool operator +(List<Paciente> p_paciente_array, Paciente p_paciente)
        {
            bool v_return = false;

            p_paciente_array.Add(p_paciente);
            return v_return;
        }
    }
}
