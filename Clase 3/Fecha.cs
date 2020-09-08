using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    public class Fecha
    {
        int dia;
        int mes;
        int año;

        public Fecha(int p_dia, int p_mes, int p_año)
        {
            this.dia = p_dia;
            this.mes = p_mes;
            this.año = p_año;
        }

         public void MostrarFecha()
        {
            Console.WriteLine("Fecha Acutal {0}/{1}/{2}", this.dia, this.mes, this.año );
        }
    }
}
