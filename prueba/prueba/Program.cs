using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(mostrar(15));
            Console.WriteLine(mostrar(9));
            Console.WriteLine(mostrar(-1));

            Console.ReadKey();
        }

        public int mostrar(int valor) { if(valor > 9) return 0; return valor; }

    }
}
