using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        string username;
        string password;

        public string Username 
        {
            get { return username; }
            set { username = value; }
        }
        public string Password 
        {
            get { return password; }
            set { password = value; }
        }

        public Usuarios(string user, string pass)
        {
            this.username = user;
            this.Password = pass;
        }
    }
}
