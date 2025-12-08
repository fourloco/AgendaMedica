using System.Drawing;
using System.Windows.Forms;

namespace AgendaMedica.UI
{
    partial class FrmAgenda
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewCitas;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnNuevaCita;
        private System.Windows.Forms.Button btnEditarCita;
        private System.Windows.Forms.Button btnEliminarCita;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewCitas = new DataGridView();
            cmbMedico = new ComboBox();
            cmbPaciente = new ComboBox();
            cmbEstado = new ComboBox();
            btnFiltrar = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            btnRegresar = new Button();
            panelFiltros = new Panel();
            lblMedico = new Label();
            lblPaciente = new Label();
            lblEstado = new Label();
            btnNuevaCita = new Button();
            btnEditarCita = new Button();
            btnEliminarCita = new Button();

            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).BeginInit();
            panelHeader.SuspendLayout();
            panelFiltros.SuspendLayout();
            SuspendLayout();

            // panelHeader
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(btnRegresar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 70);
            panelHeader.TabIndex = 0;

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(180, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agenda de Citas";

            // btnRegresar
            btnRegresar.BackColor = Color.FromArgb(231, 76, 60);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(810, 15);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 40);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "Regresar";
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.Click += btnRegresar_Click;

            // dataGridViewCitas
            dataGridViewCitas.AllowUserToAddRows = false;
            dataGridViewCitas.AllowUserToDeleteRows = false;
            dataGridViewCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCitas.BackgroundColor = Color.White;
            dataGridViewCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCitas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCitas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewCitas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCitas.Location = new Point(20, 90);
            dataGridViewCitas.Name = "dataGridViewCitas";
            dataGridViewCitas.ReadOnly = true;
            dataGridViewCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCitas.Size = new Size(860, 400);
            dataGridViewCitas.TabIndex = 1;

            // panelFiltros
            panelFiltros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltros.BackColor = Color.FromArgb(236, 240, 241);
            panelFiltros.Controls.Add(btnNuevaCita);
            panelFiltros.Controls.Add(btnEditarCita);
            panelFiltros.Controls.Add(btnEliminarCita);
            panelFiltros.Controls.Add(lblMedico);
            panelFiltros.Controls.Add(cmbMedico);
            panelFiltros.Controls.Add(lblPaciente);
            panelFiltros.Controls.Add(cmbPaciente);
            panelFiltros.Controls.Add(lblEstado);
            panelFiltros.Controls.Add(cmbEstado);
            panelFiltros.Controls.Add(btnFiltrar);
            panelFiltros.Location = new Point(20, 510);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(860, 80);
            panelFiltros.TabIndex = 2;

            // btnNuevaCita
            btnNuevaCita.BackColor = Color.FromArgb(46, 204, 113);
            btnNuevaCita.FlatStyle = FlatStyle.Flat;
            btnNuevaCita.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevaCita.ForeColor = Color.White;
            btnNuevaCita.Location = new Point(20, 25);
            btnNuevaCita.Name = "btnNuevaCita";
            btnNuevaCita.Size = new Size(100, 35);
            btnNuevaCita.TabIndex = 0;
            btnNuevaCita.Text = "Nueva Cita";
            btnNuevaCita.Cursor = Cursors.Hand;
            btnNuevaCita.UseVisualStyleBackColor = false;
            btnNuevaCita.Click += BtnNuevaCita_Click;

            // btnEditarCita
            btnEditarCita.BackColor = Color.FromArgb(241, 196, 15);
            btnEditarCita.FlatStyle = FlatStyle.Flat;
            btnEditarCita.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarCita.ForeColor = Color.White;
            btnEditarCita.Location = new Point(130, 25);
            btnEditarCita.Name = "btnEditarCita";
            btnEditarCita.Size = new Size(100, 35);
            btnEditarCita.TabIndex = 1;
            btnEditarCita.Text = "Editar Cita";
            btnEditarCita.Cursor = Cursors.Hand;
            btnEditarCita.UseVisualStyleBackColor = false;
            btnEditarCita.Click += BtnEditarCita_Click;

            // btnEliminarCita
            btnEliminarCita.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminarCita.FlatStyle = FlatStyle.Flat;
            btnEliminarCita.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarCita.ForeColor = Color.White;
            btnEliminarCita.Location = new Point(240, 25);
            btnEliminarCita.Name = "btnEliminarCita";
            btnEliminarCita.Size = new Size(100, 35);
            btnEliminarCita.TabIndex = 2;
            btnEliminarCita.Text = "Eliminar Cita";
            btnEliminarCita.Cursor = Cursors.Hand;
            btnEliminarCita.UseVisualStyleBackColor = false;
            btnEliminarCita.Click += BtnEliminarCita_Click;

            // lblMedico
            lblMedico.AutoSize = true;
            lblMedico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMedico.ForeColor = Color.FromArgb(52, 73, 94);
            lblMedico.Location = new Point(360, 10);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(52, 15);
            lblMedico.TabIndex = 3;
            lblMedico.Text = "Médico:";

            // cmbMedico
            cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedico.Font = new Font("Segoe UI", 10F);
            cmbMedico.Location = new Point(360, 30);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(150, 25);
            cmbMedico.TabIndex = 4;

            // lblPaciente
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPaciente.ForeColor = Color.FromArgb(52, 73, 94);
            lblPaciente.Location = new Point(520, 10);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(58, 15);
            lblPaciente.TabIndex = 5;
            lblPaciente.Text = "Paciente:";

            // cmbPaciente
            cmbPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaciente.Font = new Font("Segoe UI", 10F);
            cmbPaciente.Location = new Point(520, 30);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(150, 25);
            cmbPaciente.TabIndex = 6;

            // lblEstado
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstado.ForeColor = Color.FromArgb(52, 73, 94);
            lblEstado.Location = new Point(680, 10);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(48, 15);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Estado:";

            // cmbEstado
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 10F);
            cmbEstado.Location = new Point(680, 30);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(80, 25);
            cmbEstado.TabIndex = 8;

            // btnFiltrar
            btnFiltrar.BackColor = Color.FromArgb(52, 152, 219);
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(770, 25);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(80, 35);
            btnFiltrar.TabIndex = 9;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Cursor = Cursors.Hand;
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;

            // FrmAgenda
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 610);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Controls.Add(panelHeader);
            Controls.Add(dataGridViewCitas);
            Controls.Add(panelFiltros);
            Name = "FrmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda de Citas - Agenda Médica";

            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            ResumeLayout(false);
        }
    }
}