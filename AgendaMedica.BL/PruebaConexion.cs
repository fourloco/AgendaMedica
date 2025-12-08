using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaMedica.DAL;
using MySql.Data.MySqlClient;

namespace AgendaMedica.BL
{
    public class PruebaConexion
    {
        public bool Probar()
        {
            try
            {
                Conexion c = new Conexion(); // Usamos la clase DAL
                using MySqlConnection con = c.Conectar();
                con.Open(); // Abrimos la conexión
                return true; // Conexión exitosa
            }
            catch
            {
                return false; // Falló la conexión
            }
        }
    }
}
