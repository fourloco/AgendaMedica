using System;
using System.Data;
using System.Windows.Forms;
using AgendaMedica.BL;

namespace AgendaMedica.UI
{
    public partial class FrmMedicos : Form
    {
        MedicoBL bl = new MedicoBL();
        EspecialidadBL especialidadBL = new EspecialidadBL();
        int idSeleccionado = 0;

        public FrmMedicos()
        {
            InitializeComponent();
            CargarEspecialidades();
            CargarMedicos();
        }

        private void CargarEspecialidades()
        {
            cboEspecialidad.DataSource = especialidadBL.Listar();
            cboEspecialidad.DisplayMember = "Nombre";
            cboEspecialidad.ValueMember = "IdEspecialidad";
        }

        private void CargarMedicos()
        {
            dgvMedicos.DataSource = bl.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bl.Insertar(
                txtNombre.Text,
                txtTelefono.Text,
                txtCorreo.Text,
                Convert.ToInt32(cboEspecialidad.SelectedValue)
            );

            CargarMedicos();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;

            bl.Editar(
                idSeleccionado,
                txtNombre.Text,
                txtTelefono.Text,
                txtCorreo.Text,
                Convert.ToInt32(cboEspecialidad.SelectedValue)
            );

            CargarMedicos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;

            bl.Eliminar(idSeleccionado);
            CargarMedicos();
            Limpiar();
        }

        private void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(
                    dgvMedicos.Rows[e.RowIndex].Cells["IdMedico"].Value
                );

                txtNombre.Text = dgvMedicos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtTelefono.Text = dgvMedicos.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dgvMedicos.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                cboEspecialidad.SelectedValue =
                    dgvMedicos.Rows[e.RowIndex].Cells["IdEspecialidad"].Value;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenu().Show();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            idSeleccionado = 0;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
