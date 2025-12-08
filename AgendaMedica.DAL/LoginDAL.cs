using System;
using System.Data;                      // Permite trabajar con DataTable y DataRow
using MySql.Data.MySqlClient;           // Permite la conexión con MySQL

namespace AgendaMedica.DAL
{
    // Clase encargada de la validación de usuarios directamente en la base de datos
    public class LoginDAL
    {
        // Objeto que maneja la conexión a la base de datos
        private Conexion conexion = new Conexion();

        // Método que valida un usuario en la base de datos
        // Recibe como parámetros el nombre de usuario y la contraseña
        // Retorna una fila con los datos del usuario si existe, en caso contrario null
        public DataRow ValidarUsuario(string usuario, string contrasena)
        {
            // Se crea un DataTable para almacenar el resultado
            DataTable dt = new DataTable();

            // Se establece conexión con la base de datos
            using (MySqlConnection con = conexion.Conectar())
            {
                // Consulta SQL para verificar si el usuario existe
                string sql = @"SELECT IdUsuario, Usuario, Rol 
                               FROM Usuarios
                               WHERE Usuario=@Usuario AND Contrasena=@Contrasena";

                // Se prepara el comando SQL
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    // Se asignan los valores a los parámetros
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    // Se ejecuta la consulta y se llena el DataTable
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            // Si se encontró exactamente un usuario, se retorna la fila
            if (dt.Rows.Count == 1)
                return dt.Rows[0];
            else
                // Si no coincide ningún usuario, se retorna null
                return null;
        }
    }
}
