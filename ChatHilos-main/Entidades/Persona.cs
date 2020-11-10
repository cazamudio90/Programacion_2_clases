using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public int PersonId { get; set; }
        public double DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public Persona()
        {

        }
        public Persona(string apellido, string nombre, int id, double dni)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.PersonId = id;
            this.DNI = dni;
        }

        public static Persona RetornarPersonaPorId (List<Persona> personas, int id)
        {
            foreach (Persona item in personas)
            {
                if (item.PersonId == id)
                {
                    return item;
                }
            }

            return null;
        }

    }
}
