using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mensaje
    {
        //string mensaje;
        
        public string TextoMensaje { get; set; }
        public Persona persona { get; set; }

        public Mensaje(string men, Persona per)
        {
            this.TextoMensaje = men;
            this.persona = per;
        }
    }
}
