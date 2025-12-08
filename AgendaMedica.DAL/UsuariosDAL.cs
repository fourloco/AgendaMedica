using MySql.Data.MySqlClient;   // Librería para la conexión con MySQL
using System;
using System.Data;              // Permite el uso de DataTable

namespace AgendaMedica.DAL
{
    // Clase encargada de todas las operaciones CRUD relacionadas con los usuarios
    public class UsuariosDAL
    {
        // Objeto que gestiona la conexión con la base de datos
        Conexion conexion = new Conexion();

        // ==========================
        // Listar todos los usuarios
        // ==========================
        public DataTable ListarUsuarios()
        {
            // Se crea un DataTable para almacenar los datos
            DataTable dt = new DataTable();

            // Se abre la conexión usando la clase de conexión
            using (var cn = conexion.Conectar())
            {
                // Consulta SQL para obtener los usuarios
                string sql = "SELECT IdUsuario, Usuario, Rol, FechaCreacion FROM Usuarios";

                // Adaptador que ejecuta la consulta y llena el DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cn);
                da.Fill(dt);
            }

            // Retorna la tabla con los usuarios
            return dt;
        }

        // ==========================
        // Insertar un nuevo usuario
        // ==========================
        public bool InsertarUsuario(string usuario, string contrasena, string rol)
        {
            // Se abre la conexión con la base de datos
            using (var cn = conexion.Conectar())
            {
                // Consulta SQL para insertar un nuevo usuario
                string sql = @"INSERT INTO Usuarios 
                              (Usuario, Contrasena, Rol)
                              VALUES (@u, @c, @r)";

                // Se prepara el comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, cn);

                // Se asignan los datos a los parámetros
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@c", contrasena);
                cmd.Parameters.AddWithValue("@r", rol);

                // Se ejecuta la consulta y se valida si se insertó correctamente
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ==========================
        // Actualizar un usuario
        // ==========================
        public bool ActualizarUsuario(int id, string usuario, string contrasena, string rol)
        {
            // Se establece la conexión con la base de datos
            using (var cn = conexion.Conectar())
            {
                // Consulta SQL para actualizar los datos del usuario
                string sql = @"UPDATE Usuarios SET 
                              Usuario=@u, Contrasena=@c, Rol=@r
                              WHERE IdUsuario=@id";

                // Se prepara el comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, cn);

                // Se asignan los valores a los parámetros
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@c", contrasena);
                cmd.Parameters.AddWithValue("@r", rol);
                cmd.Parameters.AddWithValue("@id", id);

                // Se ejecuta la actualización
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ==========================
        // Eliminar un usuario
        // ==========================
        public bool EliminarUsuario(int id)
        {
            // Se establece la conexión con la base de datos
            using (var cn = conexion.Conectar())
            {
                // Consulta SQL para eliminar el usuario según su ID
                string sql = "DELETE FROM Usuarios WHERE IdUsuario=@id";

                // Se prepara el comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, cn);

                // Se asigna el ID al parámetro
                cmd.Parameters.AddWithValue("@id", id);

                // Se ejecuta la eliminación
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ==========================
        // Verificar si un usuario existe
        // ==========================
        public bool ExisteUsuario(string usuario)
        {
            // Se establece la conexión a la base de datos
            using (var cn = conexion.Conectar())
            {
                // Consulta SQL para contar cuántos usuarios existen con ese nombre
                string sql = "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@u";

                // Se prepara el comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, cn);

                // Se asigna el valor al parámetro
                cmd.Parameters.AddWithValue("@u", usuario);

                // Se ejecuta la consulta y se valida si existe el usuario
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
    }
}
