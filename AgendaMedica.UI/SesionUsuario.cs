using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.UI
{
    // Clase estática para mantener la sesión del usuario
    public static class SesionUsuario
    {
        // Rol del usuario: Admin, Recepcion, etc.
        public static string Rol { get; set; }

        // Nombre o usuario ingresado en el login
        public static string NombreUsuario { get; set; }
    }
}
