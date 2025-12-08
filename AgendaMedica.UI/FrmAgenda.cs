using System;
using System.Data;
using System.Windows.Forms;
using AgendaMedica.BL;
using AgendaMedica.UI;

namespace AgendaMedica.UI
{
    public partial class FrmAgenda : Form
    {
        private AgendaBL agendaBL = new AgendaBL();

        public FrmAgenda()
        {
            InitializeComponent();
            CargarComboBoxes();
            CargarCitas();
            
        }

        private void CargarCitas()
        {
            try
            {
                DataTable dt = agendaBL.ListarCitas();
                dataGridViewCitas.DataSource = dt;

                // Mejorar apariencia del DataGridView
                if (dataGridViewCitas.Columns.Count > 0)
                {
                    dataGridViewCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewCitas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las citas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBoxes()
        {
            try
            {
                DataTable dtMedicos = agendaBL.ListarMedicos();
                cmbMedico.DataSource = dtMedicos;
                cmbMedico.DisplayMember = "NombreCompleto";
                cmbMedico.ValueMember = "IdMedico";
                cmbMedico.SelectedIndex = -1;

                DataTable dtPacientes = agendaBL.ListarPacientes();
                cmbPaciente.DataSource = dtPacientes;
                cmbPaciente.DisplayMember = "NombreCompleto";
                cmbPaciente.ValueMember = "IdPaciente";
                cmbPaciente.SelectedIndex = -1;

                DataTable dtEstados = agendaBL.ListarEstados();
                cmbEstado.DataSource = dtEstados;
                cmbEstado.DisplayMember = "NombreEstado";
                cmbEstado.ValueMember = "IdEstado";
                cmbEstado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar filtros: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                int? idMedico = cmbMedico.SelectedIndex >= 0 ? (int?)cmbMedico.SelectedValue : null;
                int? idPaciente = cmbPaciente.SelectedIndex >= 0 ? (int?)cmbPaciente.SelectedValue : null;
                int? idEstado = cmbEstado.SelectedIndex >= 0 ? (int?)cmbEstado.SelectedValue : null;

                DataTable dt = agendaBL.FiltrarCitas(idMedico, idPaciente, idEstado);
                dataGridViewCitas.DataSource = dt;

                MessageBox.Show($"Se encontraron {dt.Rows.Count} cita(s)",
                               "Filtro Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar citas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNuevaCita_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmCitaModal frmModal = new FrmCitaModal(agendaBL))
                {
                    if (frmModal.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Cita creada exitosamente",
                                       "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCitas();
                        LimpiarFiltros();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la cita: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditarCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCitas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una cita para editar",
                                   "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCita = Convert.ToInt32(dataGridViewCitas.SelectedRows[0].Cells["IdCita"].Value);
                DataRowView row = (DataRowView)dataGridViewCitas.SelectedRows[0].DataBoundItem;

                using (FrmCitaModal frmModal = new FrmCitaModal(agendaBL, row))
                {
                    if (frmModal.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Cita actualizada exitosamente",
                                       "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCitas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar la cita: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCitas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una cita para eliminar",
                                   "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de eliminar esta cita?\nEsta acción no se puede deshacer.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    int idCita = Convert.ToInt32(dataGridViewCitas.SelectedRows[0].Cells["IdCita"].Value);

                    if (agendaBL.EliminarCita(idCita))
                    {
                        MessageBox.Show("Cita eliminada exitosamente",
                                       "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCitas();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la cita",
                                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFiltros()
        {
            cmbMedico.SelectedIndex = -1;
            cmbPaciente.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenu().Show();
        }
    }

    // ============================================
    // FORMULARIO MODAL PARA CREAR/EDITAR CITAS
    // ============================================
    public class FrmCitaModal : Form
    {
        private AgendaBL agendaBL;
        private DataRowView citaActual = null;
        private bool modoEdicion = false;

        // Controles
        private ComboBox cmbMedico;
        private ComboBox cmbPaciente;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpHoraFin;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblTitulo;

        // Constructor para NUEVA cita
        public FrmCitaModal(AgendaBL bl)
        {
            this.agendaBL = bl;
            this.modoEdicion = false;
            InicializarComponentes();
            CargarDatos();
        }

        // Constructor para EDITAR cita
        public FrmCitaModal(AgendaBL bl, DataRowView cita)
        {
            this.agendaBL = bl;
            this.citaActual = cita;
            this.modoEdicion = true;
            InicializarComponentes();
            CargarDatos();
            CargarDatosCita();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenu().Show();  
        }

        private void InicializarComponentes()
        {
            this.Text = modoEdicion ? "Editar Cita" : "Nueva Cita";
            this.Size = new System.Drawing.Size(500, 450);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.White;

            // Panel header
            Panel panelHeader = new Panel
            {
                BackColor = System.Drawing.Color.FromArgb(41, 128, 185),
                Dock = DockStyle.Top,
                Height = 60
            };

            lblTitulo = new Label
            {
                Text = modoEdicion ? "Editar Cita" : "Nueva Cita",
                Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(20, 18),
                AutoSize = true
            };
            panelHeader.Controls.Add(lblTitulo);
            this.Controls.Add(panelHeader);



            // Médico
            Label lblMedico = new Label
            {
                Text = "Médico:",
                Location = new System.Drawing.Point(30, 80),
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                AutoSize = true
            };
            cmbMedico = new ComboBox
            {
                Location = new System.Drawing.Point(30, 100),
                Size = new System.Drawing.Size(420, 25),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new System.Drawing.Font("Segoe UI", 10F)
            };

            // Paciente
            Label lblPaciente = new Label
            {
                Text = "Paciente:",
                Location = new System.Drawing.Point(30, 135),
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                AutoSize = true
            };
            cmbPaciente = new ComboBox
            {
                Location = new System.Drawing.Point(30, 155),
                Size = new System.Drawing.Size(420, 25),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new System.Drawing.Font("Segoe UI", 10F)
            };

            // Fecha
            Label lblFecha = new Label
            {
                Text = "Fecha:",
                Location = new System.Drawing.Point(30, 190),
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                AutoSize = true
            };
            dtpFecha = new DateTimePicker
            {
                Location = new System.Drawing.Point(30, 210),
                Size = new System.Drawing.Size(420, 25),
                Format = DateTimePickerFormat.Short,
                Font = new System.Drawing.Font("Segoe UI", 10F)
            };

            // Hora Inicio
            Label lblHoraInicio = new Label
            {
                Text = "Hora Inicio:",
                Location = new System.Drawing.Point(30, 245),
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                AutoSize = true
            };
            dtpHoraInicio = new DateTimePicker
            {
                Location = new System.Drawing.Point(30, 265),
                Size = new System.Drawing.Size(200, 25),
                Format = DateTimePickerFormat.Time,
                ShowUpDown = true,
                Font = new System.Drawing.Font("Segoe UI", 10F)
            };

            // Hora Fin
            Label lblHoraFin = new Label
            {
                Text = "Hora Fin:",
                Location = new System.Drawing.Point(250, 245),
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                AutoSize = true
            };
            dtpHoraFin = new DateTimePicker
            {
                Location = new System.Drawing.Point(250, 265),
                Size = new System.Drawing.Size(200, 25),
                Format = DateTimePickerFormat.Time,
                ShowUpDown = true,
                Font = new System.Drawing.Font("Segoe UI", 10F)
            };

            // Estado
            Label lblEstado = new Label
            {
                Text = "Estado:",
                Location = new System.Drawing.Point(30, 300),
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                AutoSize = true
            };
            cmbEstado = new ComboBox
            {
                Location = new System.Drawing.Point(30, 320),
                Size = new System.Drawing.Size(200, 25),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new System.Drawing.Font("Segoe UI", 10F)
            };

            // Botones
            btnGuardar = new Button
            {
                Text = modoEdicion ? "Actualizar" : "Guardar",
                Location = new System.Drawing.Point(240, 365),
                Size = new System.Drawing.Size(100, 35),
                BackColor = System.Drawing.Color.FromArgb(46, 204, 113),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnGuardar.Click += BtnGuardar_Click;

            btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new System.Drawing.Point(350, 365),
                Size = new System.Drawing.Size(100, 35),
                BackColor = System.Drawing.Color.FromArgb(149, 165, 166),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnCancelar.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            // Agregar controles
            this.Controls.AddRange(new Control[] {
                lblMedico, cmbMedico,
                lblPaciente, cmbPaciente,
                lblFecha, dtpFecha,
                lblHoraInicio, dtpHoraInicio,
                lblHoraFin, dtpHoraFin,
                lblEstado, cmbEstado,
                btnGuardar, btnCancelar
            });
        }

        private void CargarDatos()
        {
            try
            {
                // Cargar médicos
                DataTable dtMedicos = agendaBL.ListarMedicos();
                cmbMedico.DataSource = dtMedicos;
                cmbMedico.DisplayMember = "NombreCompleto";
                cmbMedico.ValueMember = "IdMedico";
                cmbMedico.SelectedIndex = -1;

                // Cargar pacientes
                DataTable dtPacientes = agendaBL.ListarPacientes();
                cmbPaciente.DataSource = dtPacientes;
                cmbPaciente.DisplayMember = "NombreCompleto";
                cmbPaciente.ValueMember = "IdPaciente";
                cmbPaciente.SelectedIndex = -1;

                // Cargar estados
                DataTable dtEstados = agendaBL.ListarEstados();
                cmbEstado.DataSource = dtEstados;
                cmbEstado.DisplayMember = "NombreEstado";
                cmbEstado.ValueMember = "IdEstado";

                // Si es nueva cita, seleccionar el primer estado (generalmente "Pendiente")
                if (!modoEdicion && dtEstados.Rows.Count > 0)
                    cmbEstado.SelectedIndex = 0;
                else
                    cmbEstado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message,
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosCita()
        {
            try
            {
                if (citaActual != null)
                {
                    // Cargar médico
                    if (citaActual.Row.Table.Columns.Contains("IdMedico"))
                        cmbMedico.SelectedValue = citaActual["IdMedico"];

                    // Cargar paciente
                    if (citaActual.Row.Table.Columns.Contains("IdPaciente"))
                        cmbPaciente.SelectedValue = citaActual["IdPaciente"];

                    // Cargar fecha
                    if (citaActual.Row.Table.Columns.Contains("Fecha"))
                        dtpFecha.Value = Convert.ToDateTime(citaActual["Fecha"]);

                    // Cargar hora inicio
                    if (citaActual.Row.Table.Columns.Contains("HoraInicio"))
                    {
                        TimeSpan horaInicio = (TimeSpan)citaActual["HoraInicio"];
                        dtpHoraInicio.Value = DateTime.Today.Add(horaInicio);
                    }

                    // Cargar hora fin
                    if (citaActual.Row.Table.Columns.Contains("HoraFin"))
                    {
                        TimeSpan horaFin = (TimeSpan)citaActual["HoraFin"];
                        dtpHoraFin.Value = DateTime.Today.Add(horaFin);
                    }

                    // Cargar estado
                    if (citaActual.Row.Table.Columns.Contains("IdEstado"))
                        cmbEstado.SelectedValue = citaActual["IdEstado"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la cita: " + ex.Message,
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (cmbMedico.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un médico", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbMedico.Focus();
                    return;
                }

                if (cmbPaciente.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un paciente", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbPaciente.Focus();
                    return;
                }

                if (cmbEstado.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un estado", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbEstado.Focus();
                    return;
                }

                // Obtener valores
                DateTime fecha = dtpFecha.Value.Date;
                TimeSpan horaInicio = dtpHoraInicio.Value.TimeOfDay;
                TimeSpan horaFin = dtpHoraFin.Value.TimeOfDay;

                // Validar que hora fin sea mayor que hora inicio
                if (horaFin <= horaInicio)
                {
                    MessageBox.Show("La hora de fin debe ser mayor que la hora de inicio", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpHoraFin.Focus();
                    return;
                }

                // Validar que la fecha no sea pasada (solo para nuevas citas)
                if (!modoEdicion && fecha < DateTime.Today)
                {
                    MessageBox.Show("No puede agendar una cita en fecha pasada", "Validación",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idMedico = Convert.ToInt32(cmbMedico.SelectedValue);
                int idPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);
                int idEstado = Convert.ToInt32(cmbEstado.SelectedValue);

                // Guardar
                bool resultado = agendaBL.InsertarCita(fecha, horaInicio, horaFin, idMedico, idPaciente, idEstado);

                if (resultado)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la cita.\nVerifique que las horas no se traslapen con otras citas.",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}