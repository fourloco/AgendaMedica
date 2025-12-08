using System;
using System.Data;
using AgendaMedica.DAL;

namespace AgendaMedica.BL
{
    public class AgendaBL
    {
        private AgendaDAL dal = new AgendaDAL();

        // Insertar cita
        public bool InsertarCita(DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, int idMedico, int idPaciente, int idEstado)
        {
            if (horaInicio >= horaFin)
                return false;

            return dal.InsertarCita(fecha, horaInicio, horaFin, idMedico, idPaciente, idEstado);
        }

        // Listar todas las citas
        public DataTable ListarCitas()
        {
            return dal.ListarCitas();
        }

        // ------------------- NUEVOS MÉTODOS -------------------

        // Listar todos los médicos
        public DataTable ListarMedicos()
        {
            return dal.ListarMedicos();
        }

        // Listar todos los pacientes
        public DataTable ListarPacientes()
        {
            return dal.ListarPacientes();
        }

        public bool EliminarCita(int idCita)
        {
            try
            {
                return dal.EliminarCita(idCita);
            }
            catch (Exception ex)
            {
               
                throw new ApplicationException("Error al eliminar la cita", ex);
            }
        }



        // Listar todos los estados
        public DataTable ListarEstados()
        {
            return dal.ListarEstados();
        }

        // Filtrar citas
        public DataTable FiltrarCitas(int? idMedico, int? idPaciente, int? idEstado)
        {
            return dal.FiltrarCitas(idMedico, idPaciente, idEstado);
        }
    }
}
