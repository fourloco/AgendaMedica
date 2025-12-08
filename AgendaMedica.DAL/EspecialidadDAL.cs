using System.Data;
using MySql.Data.MySqlClient;

namespace AgendaMedica.DAL
{
    public class EspecialidadDAL
    {
        Conexion conexion = new Conexion();

        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = conexion.Conectar())
            {
                string sql = "SELECT * FROM Especialidades";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            return dt;
        }

        public void Insertar(string nombre, string descripcion)
        {
            using (MySqlConnection con = conexion.Conectar())
            {
                string sql = "INSERT INTO Especialidades(Nombre, Descripcion) VALUES(@n,@d)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@n", nombre);
                cmd.Parameters.AddWithValue("@d", descripcion);
                cmd.ExecuteNonQuery();
            }
        }

        public void Editar(int id, string nombre, string descripcion)
        {
            using (MySqlConnection con = conexion.Conectar())
            {
                string sql = "UPDATE Especialidades SET Nombre=@n, Descripcion=@d WHERE IdEspecialidad=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@n", nombre);
                cmd.Parameters.AddWithValue("@d", descripcion);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (MySqlConnection con = conexion.Conectar())
            {
                string sql = "DELETE FROM Especialidades WHERE IdEspecialidad=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
