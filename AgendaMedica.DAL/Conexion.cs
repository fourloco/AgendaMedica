using MySql.Data.MySqlClient;

namespace AgendaMedica.DAL
{
    public class Conexion
    {
        private string cadena = "server=localhost;user=root;password=mj160776@J3shua;database=AgendaMedica;";//cambiar contraseña

        public MySqlConnection Conectar()
        {
            var conexion = new MySqlConnection(cadena);
            conexion.Open(); // Abre la conexión
            using (var cmd = new MySqlCommand("SET autocommit=1;", conexion))
            {
                cmd.ExecuteNonQuery(); // Activa autocommit
            }
            return conexion;
        }
    }
}
  