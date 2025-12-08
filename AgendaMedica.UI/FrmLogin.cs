using System;
using System.Data;
using System.Windows.Forms;
using AgendaMedica.BL;
using AgendaMedica.UI;

namespace AgendaMedica.UI
{
    public partial class FrmLogin : Form
    {
        // Instancia de la lógica de negocio para el login
        private LoginBL bl = new LoginBL();

        public FrmLogin()
        {
            InitializeComponent();
        }

        // Evento del botón Iniciar Sesión
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Captura de datos ingresados
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Ingrese usuario y contraseña", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Se valida el usuario en la base de datos
                DataRow dr = bl.ValidarUsuario(usuario, contrasena);

                if (dr != null)
                {
                    // Se almacenan los datos en la sesión
                    SesionUsuario.Rol = dr["Rol"].ToString();
                    SesionUsuario.NombreUsuario = dr["Usuario"].ToString();

                    // Se muestra el menú principal
                    FrmMenu menu = new FrmMenu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    // Mensaje si las credenciales son incorrectas
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error de autenticación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                // Control de errores de conexión
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
