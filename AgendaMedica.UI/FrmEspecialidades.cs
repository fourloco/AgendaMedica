using System;
using System.Data;
using System.Windows.Forms;
using AgendaMedica.BL;

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
            try
            {
                dgvEspecialidades.DataSource = bl.Listar();

                // Mejorar apariencia del DataGridView
                if (dgvEspecialidades.Columns.Count > 0)
                {
                    dgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvEspecialidades.MultiSelect = false;
                    dgvEspecialidades.AlternatingRowsDefaultCellStyle.BackColor =
                        System.Drawing.Color.FromArgb(245, 245, 245);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar especialidades: " + ex.Message,
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                if (txtNombre.Text.Length > 100)
                {
                    MessageBox.Show("El nombre no puede exceder 100 caracteres", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                bl.Insertar(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());

                MessageBox.Show("Especialidad guardada exitosamente",
                               "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarEspecialidades();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message,
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione una especialidad para editar",
                                   "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validaciones
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                if (txtNombre.Text.Length > 100)
                {
                    MessageBox.Show("El nombre no puede exceder 100 caracteres", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                bl.Editar(idSeleccionado, txtNombre.Text.Trim(), txtDescripcion.Text.Trim());

                MessageBox.Show("Especialidad actualizada exitosamente",
                               "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarEspecialidades();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message,
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione una especialidad para eliminar",
                                   "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de eliminar esta especialidad?\n" +
                    "Esta acción no se puede deshacer y puede afectar médicos relacionados.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    bl.Eliminar(idSeleccionado);

                    MessageBox.Show("Especialidad eliminada exitosamente",
                                   "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarEspecialidades();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message +
                               "\n\nPosiblemente esta especialidad está siendo usada por uno o más médicos.",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvEspecialidades.Rows[e.RowIndex];

                    idSeleccionado = Convert.ToInt32(row.Cells["IdEspecialidad"].Value);
                    txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
                    txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar: " + ex.Message,
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtNombre.Focus();
        }
    }
}