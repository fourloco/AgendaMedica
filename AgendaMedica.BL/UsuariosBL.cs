using System;
using System.Data;
using AgendaMedica.DAL;

namespace AgendaMedica.BL
{
    // Clase de la capa de Lógica de Negocio encargada de la gestión de usuarios del sistema
    public class UsuariosBL
    {
        // Instancia de la capa de acceso a datos de usuarios
        private UsuariosDAL dal = new UsuariosDAL();

        // Método que obtiene la lista completa de usuarios desde la base de datos
        public DataTable ListarUsuarios()
        {
            // Se consulta la lista de usuarios mediante la capa DAL
            return dal.ListarUsuarios();
        }

        // Método que permite registrar un nuevo usuario en el sistema
        public bool InsertarUsuario(string usuario, string contrasena, string rol)
        {
            // Validación: usuario y contraseña no pueden estar vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
                throw new Exception("Usuario y contraseña son obligatorios");

            // Validación: se verifica si el usuario ya existe en el sistema
            if (dal.ExisteUsuario(usuario))
                throw new Exception("El usuario ya existe");

            // Se envían los datos validados a la capa DAL para su inserción
            return dal.InsertarUsuario(usuario, contrasena, rol);
        }

        // Método que permite actualizar los datos de un usuario existente
        public bool ActualizarUsuario(int id, string usuario, string contrasena, string rol)
        {
            // Validación: usuario y contraseña no pueden estar vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
                throw new Exception("Usuario y contraseña son obligatorios");

            // Se envían los datos a la capa DAL para actualizar el registro
            return dal.ActualizarUsuario(id, usuario, contrasena, rol);
        }

        // Método que permite eliminar un usuario según su ID
        public bool EliminarUsuario(int id)
        {
            // Se envía el ID a la capa DAL para eliminar el usuario
            return dal.EliminarUsuario(id);
        }
    }
}
