namespace AgendaMedica.UI
{
    partial class FrmPacientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvPacientes = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            dtpFecha = new DateTimePicker();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            lblUsuario = new Label();
            btnRegresar = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelFormulario = new Panel();
            lblNombre = new Label();
            lblCedula = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblFechaNacimiento = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            panelHeader.SuspendLayout();
            panelFormulario.SuspendLayout();
            SuspendLayout();

            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblUsuario);
            panelHeader.Controls.Add(btnRegresar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 70);

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(240, 30);
            lblTitulo.Text = "Gestión de Pacientes";

            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(600, 25);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(200, 20);
            lblUsuario.Text = "Usuario: ---";

            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(231, 76, 60);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(810, 15);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 40);
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;

            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvPacientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPacientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvPacientes.Location = new Point(20, 90);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new Size(860, 300);
            dgvPacientes.CellClick += dgvPacientes_CellClick;

            // 
            // panelFormulario
            // 
            panelFormulario.BackColor = Color.FromArgb(236, 240, 241);
            panelFormulario.Controls.Add(lblNombre);
            panelFormulario.Controls.Add(txtNombre);
            panelFormulario.Controls.Add(lblCedula);
            panelFormulario.Controls.Add(txtCedula);
            panelFormulario.Controls.Add(lblTelefono);
            panelFormulario.Controls.Add(txtTelefono);
            panelFormulario.Controls.Add(lblCorreo);
            panelFormulario.Controls.Add(txtCorreo);
            panelFormulario.Controls.Add(lblFechaNacimiento);
            panelFormulario.Controls.Add(dtpFecha);
            panelFormulario.Location = new Point(20, 410);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(860, 80);

            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(52, 73, 94);
            lblNombre.Location = new Point(15, 10);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(55, 15);
            lblNombre.Text = "Nombre:";

            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(15, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 25);

            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCedula.ForeColor = Color.FromArgb(52, 73, 94);
            lblCedula.Location = new Point(230, 10);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(50, 15);
            lblCedula.Text = "Cédula:";

            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Segoe UI", 10F);
            txtCedula.Location = new Point(230, 30);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(120, 25);

            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(52, 73, 94);
            lblTelefono.Location = new Point(365, 10);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(60, 15);
            lblTelefono.Text = "Teléfono:";

            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.Location = new Point(365, 30);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(120, 25);

            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCorreo.ForeColor = Color.FromArgb(52, 73, 94);
            lblCorreo.Location = new Point(500, 10);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(48, 15);
            lblCorreo.Text = "Correo:";

            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 10F);
            txtCorreo.Location = new Point(500, 30);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(180, 25);

            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaNacimiento.ForeColor = Color.FromArgb(52, 73, 94);
            lblFechaNacimiento.Location = new Point(695, 10);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(120, 15);
            lblFechaNacimiento.Text = "Fecha de Nacimiento:";

            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 10F);
            dtpFecha.Location = new Point(695, 30);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(150, 25);

            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(46, 204, 113);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(20, 510);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 40);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;

            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(52, 152, 219);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(150, 510);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 40);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;

            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(280, 510);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;

            // 
            // FrmPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 570);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Controls.Add(panelHeader);
            Controls.Add(dgvPacientes);
            Controls.Add(panelFormulario);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Name = "FrmPacientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Pacientes - Agenda Médica";
            Load += Form1_Load;

            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPacientes;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnActualizar;
        private DateTimePicker dtpFecha;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private Label lblUsuario;
        private Button btnRegresar;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelFormulario;
        private Label lblNombre;
        private Label lblCedula;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblFechaNacimiento;
    }
}