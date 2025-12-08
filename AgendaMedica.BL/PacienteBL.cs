using System;                    // Permite usar tipos básicos como Exception y DateTime
using System.Data;               // Permite trabajar con DataTable
using AgendaMedica.DAL;          // Permite usar la capa de acceso a datos (PacienteDAL)

namespace AgendaMedica.BL
{
    // Capa de Lógica de Negocio para el módulo de Pacientes
    public class PacienteBL
    {
        // Objeto que permite comunicarse con la capa DAL
        private PacienteDAL dal = new PacienteDAL();

        // ================================
        // LISTAR TODOS LOS PACIENTES
        // ================================
        public DataTable ListarPacientes()
        {
            // Devuelve todos los pacientes desde la base de datos
            return dal.ListarPacientes();
        }

        // ================================
        // INSERTAR NUEVO PACIENTE
        // ================================
        public bool InsertarPaciente(string nombre, string cedula, DateTime fecha, string telefono, string correo)
        {
            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(cedula))
                throw new Exception("Nombre y cédula son obligatorios");

            // Llamada al método de la capa DAL para insertar el paciente
            return dal.InsertarPaciente(nombre, cedula, fecha, telefono, correo);
        }

        // ================================
        // ACTUALIZAR PACIENTE EXISTENTE
        // ================================
        public bool ActualizarPaciente(int id, string nombre, string cedula, DateTime fecha, string telefono, string correo)
        {
            // Validación del ID
            if (id <= 0)
                throw new Exception("ID del paciente inválido");

            // Llamada al método de actualización en la DAL
            return dal.ActualizarPaciente(id, nombre, cedula, fecha, telefono, correo);
        }


        // ELIMINAR PACIENTE

        public bool EliminarPaciente(int id)
        {
            // Validación del ID antes de eliminar
            if (id <= 0)
                throw new Exception("ID del paciente inválido");

            // Llamada al método para eliminar en la capa DAL
            return dal.EliminarPaciente(id);
        }
    }
}
