using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
     class GALLETITA
    {
        public string sabor;
        public Boolean bajasCalorias;
        
        /// <summary>
        /// Este metodo es para obtener el valor de sabor
        /// </summary>
        /// <returns> Devuelve el valor del atributo Sabor</returns>
        public string getSabor()
        {
            return this.sabor;
        }
        /// <summary>
        /// Este metodo es para setiar un atributo que le pasamos por parametro
        /// </summary>
        /// <param name="p_sabor"> Parametro que se recibe</param>
        public void setSabor( string p_sabor)
        {
            this.sabor = p_sabor;
        }
    }
}
