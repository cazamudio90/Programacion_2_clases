﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico : Persona
    {
        /*string nombre;
        string apellido;
        int dni;*/
        EEspecialidades especialidad;

        public Medico(string p_nombre, string p_apelldio, int p_dni, EEspecialidades p_especialidad) : base(p_nombre, p_apelldio, p_dni)
        {
            this.especialidad = p_especialidad;
        }


        public static bool operator +(Medico[] p_medico_array, Medico p_medico)
        {
            bool v_return = false;
            
            for (int i = 0; i < p_medico_array.Length; i++)
            {
                if (p_medico_array[i] == null )
                {
                    p_medico_array[i] = p_medico;
                    v_return = true;
                    break;
                }
            }

            if (v_return == false)
            {
                Array.Resize<Medico>(ref p_medico_array, p_medico_array.Length + 1);

                p_medico_array[p_medico_array.Length - 1] = p_medico;
                v_return = true;
            }

            return v_return;
        }
    }
}
