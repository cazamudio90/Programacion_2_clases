using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente: Persona
    {
        /*string nombre;
        string apellido;
        int dni;*/ // se van porque empiezan a tomar los de Persona
        Enfermedad dolencia;
        string descripcionDolecia;

        /* public string Nombre
         {
             set { nombre = value; }
             get { return nombre; }
         }

         public string Apellido
         {
             set { apellido = value; }
             get { return apellido; }
         }

         public int Dni
         {
             set { dni = value; }
             get { return dni; }
         }*/ // se van porque empiezan a tomar los de Persona

        public string DescripcionDolecia
        {
            set { descripcionDolecia = value; }
            get { return descripcionDolecia; }
        }

        public Paciente(string p_nombre, string p_apellido, int p_dni, string p_descripcionDolecia):base(p_nombre, p_apellido, p_dni)
        {
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
            v_return = true;

            return v_return;
        }
    }
}
