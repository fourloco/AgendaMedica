using MySql.Data.MySqlClient;   // Librería para la conexión con MySQL
using System;
using System.Data;             // Permite el uso de DataTable

namespace AgendaMedica.DAL
{
    // Clase encargada de gestionar todas las operaciones CRUD de los pacientes
    public class PacienteDAL
    {
        // Objeto para gestionar la conexión a la base de datos
        private Conexion conexion = new Conexion();

        // ==========================
        // Insertar un nuevo paciente
        // ==========================
        public bool InsertarPaciente(string nombre, string cedula, DateTime fechaNacimiento, string telefono, string correo)
        {
            try
            {
                // Establece la conexión con la base de datos
                using MySqlConnection con = conexion.Conectar();

                // Consulta SQL para insertar un paciente
                string sql = "INSERT INTO Pacientes (NombreCompleto, Cedula, FechaNacimiento, Telefono, Correo) " +
                             "VALUES (@Nombre, @Cedula, @Fecha, @Telefono, @Correo)";

                // Se prepara el comando SQL
                using MySqlCommand cmd = new MySqlCommand(sql, con);

                // Se asignan los valores a cada parámetro
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Cedula", cedula);
                cmd.Parameters.AddWithValue("@Fecha", fechaNacimiento);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Correo", correo);

                // Ejecuta la consulta
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                // Muestra el error en consola para depuración
                Console.WriteLine("Error InsertarPaciente: " + ex.Message);
                return false;
            }
        }

        // ==========================
        // Listar todos los pacientes
        // ==========================
        public DataTable ListarPacientes()
        {
            DataTable dt = new DataTable();

            try
            {
                // Establece la conexión con la base de datos
                using MySqlConnection con = conexion.Conectar();

                // Consulta SQL para obtener todos los pacientes
                string sql = "SELECT * FROM Pacientes";

                // Adaptador que ejecuta la consulta y llena el DataTable
                using MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                // Muestra el error en consola
                Console.WriteLine("Error ListarPacientes: " + ex.Message);
            }

            return dt;
        }

        // ==========================
        // Actualizar un paciente
        // ==========================
        public bool ActualizarPaciente(int id, string nombre, string cedula, DateTime fechaNacimiento, string telefono, string correo)
        {
            try
            {
                // Establece la conexión con la base de datos
                using MySqlConnection con = conexion.Conectar();

                // Consulta SQL para actualizar los datos del paciente
                string sql = "UPDATE Pacientes SET NombreCompleto=@Nombre, Cedula=@Cedula, FechaNacimiento=@Fecha, " +
                             "Telefono=@Telefono, Correo=@Correo WHERE IdPaciente=@Id";

                // Se prepara el comando SQL
                using MySqlCommand cmd = new MySqlCommand(sql, con);

                // Se asignan los valores a los parámetros
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Cedula", cedula);
                cmd.Parameters.AddWithValue("@Fecha", fechaNacimiento);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Correo", correo);

                // Ejecuta la consulta
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                // Muestra el error en consola
                Console.WriteLine("Error ActualizarPaciente: " + ex.Message);
                return false;
            }
        }

        // ==========================
        // Eliminar un paciente
        // ==========================
        public bool EliminarPaciente(int id)
        {
            try
            {
                // Establece la conexión con la base de datos
                using MySqlConnection con = conexion.Conectar();

                // Consulta SQL para eliminar el paciente por ID
                string sql = "DELETE FROM Pacientes WHERE IdPaciente=@Id";

                // Se prepara el comando SQL
                using MySqlCommand cmd = new MySqlCommand(sql, con);

                // Se asigna el ID como parámetro
                cmd.Parameters.AddWithValue("@Id", id);

                // Ejecuta la consulta
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                // Muestra el error en consola
                Console.WriteLine("Error EliminarPaciente: " + ex.Message);
                return false;
            }
        }
    }
}
