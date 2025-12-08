using System;
using System.Data;
using AgendaMedica.DAL;

namespace AgendaMedica.BL
{
    // Clase de la capa de Lógica de Negocio encargada del proceso de inicio de sesión
    public class LoginBL
    {
        // Instancia de la capa de acceso a datos para el login
        private LoginDAL dal = new LoginDAL();

        // Método que valida el usuario y contraseña recibidos desde la interfaz
        // Retorna un DataRow con los datos del usuario si es válido, o null si no existe
        public DataRow ValidarUsuario(string usuario, string contrasena)
        {
            // Se envían los datos a la capa DAL para validar en la base de datos
            return dal.ValidarUsuario(usuario, contrasena);
        }
    }
}
