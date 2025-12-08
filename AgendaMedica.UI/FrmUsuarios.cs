using System;
using System.Data;
using System.Windows.Forms;
using AgendaMedica.BL;

namespace AgendaMedica.UI
{
    public partial class FrmUsuarios : Form
    {
        // Lógica de negocio para usuarios
        private UsuariosBL bl = new UsuariosBL();

        // ID del usuario seleccionado en la tabla
        private int idSeleccionado = 0;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        // Evento al cargar el formulario
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            lblUsuarioSesion.Text = "Usuario: " + SesionUsuario.NombreUsuario;
            CargarUsuarios();
            LimpiarCampos();
        }

        // Carga los usuarios al DataGridView
        private void CargarUsuarios()
        {
            DataTable dt = bl.ListarUsuarios();
            dgvUsuarios.DataSource = dt;
        }

        // Selección de usuario en la tabla
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdUsuario"].Value);
            txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
            cmbRol.Text = fila.Cells["Rol"].Value.ToString();
        }

        // Insertar usuario
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bl.InsertarUsuario(txtUsuario.Text, txtContrasena.Text, cmbRol.Text);
            CargarUsuarios();
            LimpiarCampos();
        }

        // Actualizar usuario
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bl.ActualizarUsuario(idSeleccionado, txtUsuario.Text, txtContrasena.Text, cmbRol.Text);
            CargarUsuarios();
            LimpiarCampos();
        }

        // Eliminar usuario
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bl.EliminarUsuario(idSeleccionado);
            CargarUsuarios();
            LimpiarCampos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenu().Show();
        }


        // Limpia los campos
        private void LimpiarCampos()
        {
            idSeleccionado = 0;
            txtUsuario.Clear();
            txtContrasena.Clear();
            cmbRol.SelectedIndex = -1;
        }
    }
}
