using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Genreicas.Entidades
{
    class Validaciones<T> where T : IComparable
    {
        public static bool validarValor(T min, T max, T valor)
        {
            bool v_return = false;

            if (valor.CompareTo(min) > 0 && valor.CompareTo(max) < 0)
            {
                v_return = true;
            }

            return v_return;
        }
    }
}
