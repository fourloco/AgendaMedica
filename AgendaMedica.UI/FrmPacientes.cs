using AgendaMedica.BL;
using System;
using System.Windows.Forms;

namespace AgendaMedica.UI
{
    public partial class FrmPacientes : Form
    {
        private PacienteBL pacienteBL = new PacienteBL(); // Instancia de BL

        public FrmPacientes()
        {
            InitializeComponent();
            CargarPacientes(); // Carga los pacientes al abrir el formulario
        }

        private void CargarPacientes()
        {
            dgvPacientes.DataSource = null; // Limpia cualquier dato previo
            dgvPacientes.DataSource = pacienteBL.ListarPacientes(); // Asigna la fuente de datos
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            bool resultado = pacienteBL.InsertarPaciente(
                txtNombre.Text,
                txtCedula.Text,
                dtpFecha.Value,
                txtTelefono.Text,
                txtCorreo.Text
            );

            if (resultado)
            {
                MessageBox.Show("Paciente agregado correctamente");
                LimpiarFormulario();
                CargarPacientes();
            }
            else
            {
                MessageBox.Show("Error al agregar (posible cédula duplicada)");
            }
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un paciente");
                return;
            }

            if (!ValidarCampos())
                return;

            int id = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["IdPaciente"].Value);

            bool resultado = pacienteBL.ActualizarPaciente(
                id,
                txtNombre.Text,
                txtCedula.Text,
                dtpFecha.Value,
                txtTelefono.Text,
                txtCorreo.Text
            );

            if (resultado)
            {
                MessageBox.Show("Paciente actualizado");
                LimpiarFormulario();
                CargarPacientes();
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvPacientes.Rows[e.RowIndex];

                txtNombre.Text = fila.Cells["NombreCompleto"].Value.ToString();
                txtCedula.Text = fila.Cells["Cedula"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un paciente");
                return;
            }

            DialogResult r = MessageBox.Show(
                "¿Está seguro de eliminar este paciente?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (r == DialogResult.No) return;

            int id = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["IdPaciente"].Value);

            bool resultado = pacienteBL.EliminarPaciente(id);

            if (resultado)
            {
                MessageBox.Show("Paciente eliminado");
                LimpiarFormulario();
                CargarPacientes();
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("La cédula es obligatoria");
                txtCedula.Focus();
                return false;
            }

            if (!long.TryParse(txtCedula.Text, out _))
            {
                MessageBox.Show("La cédula solo debe contener números");
                txtCedula.Focus();
                return false;
            }

            if (dtpFecha.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio");
                txtTelefono.Focus();
                return false;
            }

            if (!long.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("El teléfono solo debe contener números");
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El correo es obligatorio");
                txtCorreo.Focus();
                return false;
            }

            if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
            {
                MessageBox.Show("Correo inválido");
                txtCorreo.Focus();
                return false;
            }

            return true;
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenu().Show();
        }



        private void LimpiarFormulario()
        {
            txtNombre.Text = string.Empty;
            txtCedula.Text = string.Empty;
            dtpFecha.Value = DateTime.Today;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
