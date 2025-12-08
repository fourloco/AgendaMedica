using System;
using System.Windows.Forms;

namespace AgendaMedica.UI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        // Constructor que recibe el rol y usuario
        public FrmMenu(string rol, string usuario)
        {
            InitializeComponent();

            SesionUsuario.Rol = rol;
            SesionUsuario.NombreUsuario = usuario;
            lblUsuario.Text = "Usuario: " + usuario;

            ConfigurarAcceso();
        }

        // Se restringe acceso según el rol
        private void ConfigurarAcceso()
        {
            if (SesionUsuario.Rol == "Recepcion")
            {
                btnGestionMedicos.Enabled = false;
                btnGestionUsuarios.Enabled = false;
            }
        }

        // Acceso a pacientes
        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FrmPacientes frm = new FrmPacientes();
            frm.Show();
            this.Close();
        }

        private void btnGestionMedicos_Click(object sender, EventArgs e)
        {
            FrmMedicos frm = new FrmMedicos();
            frm.Show();
            this.Close();
        }


        // Acceso a médicos
        private void btnMedicos_Click(object sender, EventArgs e)
        {
            FrmMedicos frm = new FrmMedicos();
            frm.Show();
            this.Close();
        }

        // Acceso a citas
        private void btnCitas_Click(object sender, EventArgs e)
        {
            FrmAgenda frm = new FrmAgenda();
            frm.Show();
            this.Close();
        }

        // Acceso a usuarios
        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.Show();
            this.Close();
        }

        // Cerrar sistema
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmLogin().Show();
        }
        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            FrmEspecialidades frm = new FrmEspecialidades();
            frm.Show();
            this.Close();
        }

    }
}
