using System.Data;
using MySql.Data.MySqlClient;

namespace AgendaMedica.DAL
{
    public class MedicoDAL
    {
        Conexion conexion = new Conexion();

        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection con = conexion.Conectar())
            {
                string sql = @"SELECT m.IdMedico, m.NombreCompleto, m.Telefono, 
                                      m.Correo, m.IdEspecialidad, e.Nombre AS Especialidad
                               FROM Medicos m
                               INNER JOIN Especialidades e 
                               ON m.IdEspecialidad = e.IdEspecialidad";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.Fill(dt);
            }

            return dt;
        }

        public void Insertar(string nombre, string telefono, string correo, int idEspecialidad)
        {
            using (MySqlConnection con = conexion.Conectar())
            {
                string sql = @"INSERT INTO Medicos
                               (Nombre, Telefono, Correo, IdEspecialidad)
                               VALUES (@n,@t,@c,@e)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@n", nombre);
                cmd.Parameters.AddWithValue("@t", telefono);
                cmd.Parameters.AddWithValue("@c", correo);
                cmd.Parameters.AddWithValue("@e", idEspecialidad);
                cmd.ExecuteNonQuery();
            }
        }

        public void Editar(int id, string nombre, string telefono, string correo, int idEspecialidad)
        {
            using (MySqlConnection con = conexion.Conectar())
            {
                string sql = @"UPDATE Medicos
                               SET Nombre=@n, Telefono=@t, Correo=@c, IdEspecialidad=@e
                               WHERE IdMedico=@id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@n", nombre);
                cmd.Parameters.AddWithValue("@t", telefono);
                cmd.Parameters.AddWithValue("@c", correo);
                cmd.Parameters.AddWithValue("@e", idEspecialidad);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (MySqlConnection con = conexion.Conectar())
            {
                string sql = "DELETE FROM Medicos WHERE IdMedico=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
