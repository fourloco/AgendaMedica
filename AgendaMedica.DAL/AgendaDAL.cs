using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace AgendaMedica.DAL
{
    // Clase encargada de la gestión directa con MySQL para la agenda
    public class AgendaDAL
    {
        // Objeto de conexión a la base de datos
        private Conexion conexion = new Conexion();

        // ------------------- CRUD Citas -------------------

        // Inserta una nueva cita en la base de datos
        public bool InsertarCita(DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin,
                                 int idMedico, int idPaciente, int idEstado)
        {
            try
            {
                // Se abre la conexión a la base de datos
                using (MySqlConnection con = conexion.Conectar())
                {
                    // Consulta SQL de inserción
                    string sql = @"INSERT INTO Agenda 
                                   (Fecha, HoraInicio, HoraFin, IdMedico, IdPaciente, IdEstado)
                                   VALUES (@Fecha, @HoraInicio, @HoraFin, @IdMedico, @IdPaciente, @IdEstado)";

                    // Se prepara el comando SQL
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        // Se asignan los valores a los parámetros
                        cmd.Parameters.AddWithValue("@Fecha", fecha);
                        cmd.Parameters.AddWithValue("@HoraInicio", horaInicio);
                        cmd.Parameters.AddWithValue("@HoraFin", horaFin);
                        cmd.Parameters.AddWithValue("@IdMedico", idMedico);
                        cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                        cmd.Parameters.AddWithValue("@IdEstado", idEstado);

                        // Ejecuta la consulta
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Captura errores generados por la base de datos
                throw new Exception(ex.Message);
            }
        }

        // Obtiene todas las citas del sistema
        public DataTable ListarCitas()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection con = conexion.Conectar())
            {
                // Consulta con relaciones a médicos, pacientes y estados
                string sql = @"SELECT 
                                A.IdCita, A.Fecha, A.HoraInicio, A.HoraFin,
                                P.NombreCompleto AS Paciente,
                                M.NombreCompleto AS Medico,
                                E.NombreEstado AS Estado
                               FROM Agenda A
                               INNER JOIN Pacientes P ON A.IdPaciente = P.IdPaciente
                               INNER JOIN Medicos M ON A.IdMedico = M.IdMedico
                               INNER JOIN EstadosCita E ON A.IdEstado = E.IdEstado";

                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, con))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        // Actualiza una cita por su ID
        public bool ActualizarCita(int id, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin,
                                   int idMedico, int idPaciente, int idEstado)
        {
            try
            {
                using (MySqlConnection con = conexion.Conectar())
                {
                    string sql = @"UPDATE Agenda SET 
                                   Fecha=@Fecha,
                                   HoraInicio=@HoraInicio,
                                   HoraFin=@HoraFin,
                                   IdMedico=@IdMedico,
                                   IdPaciente=@IdPaciente,
                                   IdEstado=@IdEstado
                                   WHERE IdCita=@Id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Fecha", fecha);
                        cmd.Parameters.AddWithValue("@HoraInicio", horaInicio);
                        cmd.Parameters.AddWithValue("@HoraFin", horaFin);
                        cmd.Parameters.AddWithValue("@IdMedico", idMedico);
                        cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                        cmd.Parameters.AddWithValue("@IdEstado", idEstado);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Elimina una cita por su ID
        public bool EliminarCita(int id)
        {
            try
            {
                using (MySqlConnection con = conexion.Conectar())
                {
                    string sql = "DELETE FROM Agenda WHERE IdCita=@Id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // ------------------- Listados para ComboBox -------------------

        // Lista médicos
        public DataTable ListarMedicos()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = conexion.Conectar())
            {
                string sql = "SELECT IdMedico, NombreCompleto FROM Medicos ORDER BY NombreCompleto";
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // Lista pacientes
        public DataTable ListarPacientes()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = conexion.Conectar())
            {
                string sql = "SELECT IdPaciente, NombreCompleto FROM Pacientes ORDER BY NombreCompleto";
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // Lista estados de las citas
        public DataTable ListarEstados()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = conexion.Conectar())
            {
                string sql = "SELECT IdEstado, NombreEstado FROM EstadosCita ORDER BY NombreEstado";
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // ------------------- Filtrado de citas -------------------

        // Filtra citas por médico, paciente y estado
        public DataTable FiltrarCitas(int? idMedico, int? idPaciente, int? idEstado)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = conexion.Conectar())
            {
                string sql = @"SELECT 
                                A.IdCita, A.Fecha, A.HoraInicio, A.HoraFin,
                                P.NombreCompleto AS Paciente,
                                M.NombreCompleto AS Medico,
                                E.NombreEstado AS Estado
                               FROM Agenda A
                               INNER JOIN Pacientes P ON A.IdPaciente = P.IdPaciente
                               INNER JOIN Medicos M ON A.IdMedico = M.IdMedico
                               INNER JOIN EstadosCita E ON A.IdEstado = E.IdEstado
                               WHERE (@IdMedico IS NULL OR A.IdMedico = @IdMedico)
                                 AND (@IdPaciente IS NULL OR A.IdPaciente = @IdPaciente)
                                 AND (@IdEstado IS NULL OR A.IdEstado = @IdEstado)";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@IdMedico", (object)idMedico ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IdPaciente", (object)idPaciente ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IdEstado", (object)idEstado ?? DBNull.Value);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
