using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fecha nuevaFecha = new Fecha(22,02,1990);

            nuevaFecha.MostrarFecha();

            Console.ReadKey();
        }
    }
}
