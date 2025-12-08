using System;
using System.Data;
using System.Windows.Forms;
using AgendaMedica.BL;
using AgendaMedica.UI;

namespace AgendaMedica.UI
{
    public partial class FrmEspecialidades : Form
    {
        EspecialidadBL bl = new EspecialidadBL();
        int idSeleccionado = 0;

        public FrmEspecialidades()
        {
            InitializeComponent();
            CargarEspecialidades();
        }

        private void CargarEspecialidades()
        {
            dgvEspecialidades.DataSource = bl.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bl.Insertar(txtNombre.Text, txtDescripcion.Text);
            CargarEspecialidades();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;

            bl.Editar(idSeleccionado, txtNombre.Text, txtDescripcion.Text);
            CargarEspecialidades();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bl.Eliminar(idSeleccionado);
            CargarEspecialidades();
            Limpiar();
        }

        private void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvEspecialidades.Rows[e.RowIndex].Cells["IdEspecialidad"].Value);
                txtNombre.Text = dgvEspecialidades.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvEspecialidades.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
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
            txtDescripcion.Clear();
            idSeleccionado = 0;
        }
    }
}
