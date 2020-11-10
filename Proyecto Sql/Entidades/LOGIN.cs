using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;


namespace Entidades
{
    public static class LOGIN
    {
        public static List<Usuarios> listUsuarios = new List<Usuarios>();
        public static SqlConnection miConexion = new SqlConnection("Data Source=agasoluciones.dynamic-dns.net\\mssqlserver2; Initial Catalog = Mensajes; User Id=Alumno;Password=FraUtn;");

        public static void CargarUsuarios()
        {
            //SqlConnection miConexion = new SqlConnection("Data Source=agasoluciones.dynamic-dns.net\\mssqlserver2; Initial Catalog = Mensajes; User Id=Alumno;Password=FraUtn;");

            SqlCommand sqlCommand = new SqlCommand();

            //sqlCommand.Connection = new SqlConnection("Data Source=[agasoluciones.dynamic-dns.net\\mssqlserver2]; Initial Catalog = [Mensajes]; User Id=Alumno;Password=FraUtn;"); ;

            sqlCommand.Connection = miConexion;

            sqlCommand.CommandType = CommandType.Text;

            sqlCommand.CommandText = "select * from Users";

            miConexion.Open();

            SqlDataReader lector = sqlCommand.ExecuteReader();

            //string nombreAlumno;

            while (lector.Read())
            {

                //nombreAlumno = lector["Username"].ToString();
                listUsuarios.Add(new Usuarios(lector["Username"].ToString(), lector["Password"].ToString()));
            }
        }

        public static bool ValidarUsuarios(List<Usuarios> listUsuarios, string user, string pass)
        {
            bool v_return = false;

            CargarUsuarios();

            foreach (Usuarios item in listUsuarios)
            {
                if (item.Username == user && item.Password == pass)
                {
                    v_return = true;
                    break;
                }
            }
            return v_return;
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
