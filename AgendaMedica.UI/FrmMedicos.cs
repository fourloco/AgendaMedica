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
            try
            {
                cboEspecialidad.DataSource = especialidadBL.Listar();
                cboEspecialidad.DisplayMember = "Nombre";
                cboEspecialidad.ValueMember = "IdEspecialidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar especialidades: " + ex.Message,
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMedicos()
        {
            try
            {
                dgvMedicos.DataSource = bl.Listar();

                // Mejorar apariencia del DataGridView
                if (dgvMedicos.Columns.Count > 0)
                {
                    dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvMedicos.MultiSelect = false;
                    dgvMedicos.AlternatingRowsDefaultCellStyle.BackColor =
                        System.Drawing.Color.FromArgb(245, 245, 245);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar médicos: " + ex.Message,
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

                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("El teléfono es obligatorio", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefono.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    MessageBox.Show("El correo es obligatorio", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    return;
                }

                if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
                {
                    MessageBox.Show("Ingrese un correo electrónico válido", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    return;
                }

                if (cboEspecialidad.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una especialidad", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboEspecialidad.Focus();
                    return;
                }

                // Nota: Si tienes campos para HoraInicio y HoraFin, agrégalos aquí
                // Por ahora, se usa el método Insertar original que ya tienes
                bl.Insertar(
                    txtNombre.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    Convert.ToInt32(cboEspecialidad.SelectedValue)
                );

                MessageBox.Show("Médico guardado exitosamente",
                               "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarMedicos();
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
                    MessageBox.Show("Seleccione un médico para editar",
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

                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("El teléfono es obligatorio", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefono.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    MessageBox.Show("El correo es obligatorio", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    return;
                }

                if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
                {
                    MessageBox.Show("Ingrese un correo electrónico válido", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    return;
                }

                if (cboEspecialidad.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una especialidad", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboEspecialidad.Focus();
                    return;
                }

                bl.Editar(
                    idSeleccionado,
                    txtNombre.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    Convert.ToInt32(cboEspecialidad.SelectedValue)
                );

                MessageBox.Show("Médico actualizado exitosamente",
                               "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarMedicos();
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
                    MessageBox.Show("Seleccione un médico para eliminar",
                                   "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de eliminar este médico?\n" +
                    "Esta acción no se puede deshacer y puede afectar citas relacionadas.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    bl.Eliminar(idSeleccionado);

                    MessageBox.Show("Médico eliminado exitosamente",
                                   "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarMedicos();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message +
                               "\n\nPosiblemente este médico tiene citas asociadas.",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvMedicos.Rows.Count)
                {
                    DataGridViewRow row = dgvMedicos.Rows[e.RowIndex];

                    // Cargar datos usando los nombres exactos de las columnas
                    idSeleccionado = Convert.ToInt32(row.Cells["IdMedico"].Value);
                    txtNombre.Text = row.Cells["NombreCompleto"].Value?.ToString() ?? "";
                    txtTelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? "";
                    txtCorreo.Text = row.Cells["Correo"].Value?.ToString() ?? "";

                    // Cargar la especialidad usando el IdEspecialidad (número)
                    if (row.Cells["IdEspecialidad"].Value != null &&
                        row.Cells["IdEspecialidad"].Value != DBNull.Value)
                    {
                        cboEspecialidad.SelectedValue = Convert.ToInt32(row.Cells["IdEspecialidad"].Value);
                    }

                    // Nota: Si tienes controles para HoraInicio y HoraFin, cárgalos aquí
                    // Ejemplo:
                    // if (row.Cells["HoraInicio"].Value != null && row.Cells["HoraInicio"].Value != DBNull.Value)
                    // {
                    //     dtpHoraInicio.Value = DateTime.Today.Add((TimeSpan)row.Cells["HoraInicio"].Value);
                    // }
                    // if (row.Cells["HoraFin"].Value != null && row.Cells["HoraFin"].Value != DBNull.Value)
                    // {
                    //     dtpHoraFin.Value = DateTime.Today.Add((TimeSpan)row.Cells["HoraFin"].Value);
                    // }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar médico: " + ex.Message,
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
            txtTelefono.Clear();
            txtCorreo.Clear();
            idSeleccionado = 0;

            if (cboEspecialidad.Items.Count > 0)
            {
                cboEspecialidad.SelectedIndex = 0;
            }

            txtNombre.Focus();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }
    }
}