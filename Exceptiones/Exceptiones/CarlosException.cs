using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptiones
{
    class CarlosException : Exception
    {
        public CarlosException( string msg):base("El Mensaje Personalizado es "+msg)
        {

        }
    }
}
