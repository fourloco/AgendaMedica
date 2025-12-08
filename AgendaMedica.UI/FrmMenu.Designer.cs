namespace AgendaMedica.UI
{
    partial class FrmMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGestionMedicos;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelAdministracion;
        private System.Windows.Forms.Panel panelOperaciones;
        private System.Windows.Forms.Label lblAdministracion;
        private System.Windows.Forms.Label lblOperaciones;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnGestionMedicos = new Button();
            btnGestionUsuarios = new Button();
            btnPacientes = new Button();
            btnCitas = new Button();
            btnSalir = new Button();
            lblUsuario = new Label();
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelAdministracion = new Panel();
            lblAdministracion = new Label();
            panelOperaciones = new Panel();
            Especialidades = new Button();
            lblOperaciones = new Label();
            panelHeader.SuspendLayout();
            panelAdministracion.SuspendLayout();
            panelOperaciones.SuspendLayout();
            SuspendLayout();
            // 
            // btnGestionMedicos
            // 
            btnGestionMedicos.BackColor = Color.FromArgb(52, 152, 219);
            btnGestionMedicos.Cursor = Cursors.Hand;
            btnGestionMedicos.FlatStyle = FlatStyle.Flat;
            btnGestionMedicos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGestionMedicos.ForeColor = Color.White;
            btnGestionMedicos.Location = new Point(18, 52);
            btnGestionMedicos.Margin = new Padding(4, 3, 4, 3);
            btnGestionMedicos.Name = "btnGestionMedicos";
            btnGestionMedicos.Size = new Size(257, 46);
            btnGestionMedicos.TabIndex = 1;
            btnGestionMedicos.Text = "Gestión Médicos";
            btnGestionMedicos.UseVisualStyleBackColor = false;
            btnGestionMedicos.Click += btnGestionMedicos_Click;
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.BackColor = Color.FromArgb(52, 152, 219);
            btnGestionUsuarios.Cursor = Cursors.Hand;
            btnGestionUsuarios.FlatStyle = FlatStyle.Flat;
            btnGestionUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGestionUsuarios.ForeColor = Color.White;
            btnGestionUsuarios.Location = new Point(18, 110);
            btnGestionUsuarios.Margin = new Padding(4, 3, 4, 3);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Size = new Size(257, 46);
            btnGestionUsuarios.TabIndex = 2;
            btnGestionUsuarios.Text = "Gestión Usuarios";
            btnGestionUsuarios.UseVisualStyleBackColor = false;
            btnGestionUsuarios.Click += btnGestionUsuarios_Click;
            // 
            // btnPacientes
            // 
            btnPacientes.BackColor = Color.FromArgb(46, 204, 113);
            btnPacientes.Cursor = Cursors.Hand;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPacientes.ForeColor = Color.White;
            btnPacientes.Location = new Point(18, 52);
            btnPacientes.Margin = new Padding(4, 3, 4, 3);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(257, 46);
            btnPacientes.TabIndex = 1;
            btnPacientes.Text = "Pacientes";
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.FromArgb(46, 204, 113);
            btnCitas.Cursor = Cursors.Hand;
            btnCitas.FlatStyle = FlatStyle.Flat;
            btnCitas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCitas.ForeColor = Color.White;
            btnCitas.Location = new Point(18, 156);
            btnCitas.Margin = new Padding(4, 3, 4, 3);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(257, 46);
            btnCitas.TabIndex = 3;
            btnCitas.Text = "Agenda de Citas";
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += btnCitas_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(231, 76, 60);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(35, 300);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(292, 46);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnRegresar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(23, 52);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(350, 23);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 128, 185);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblUsuario);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(700, 81);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(23, 17);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(169, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Menú Principal";
            // 
            // panelAdministracion
            // 
            panelAdministracion.BackColor = Color.FromArgb(236, 240, 241);
            panelAdministracion.Controls.Add(lblAdministracion);
            panelAdministracion.Controls.Add(btnGestionMedicos);
            panelAdministracion.Controls.Add(btnGestionUsuarios);
            panelAdministracion.Location = new Point(35, 104);
            panelAdministracion.Margin = new Padding(4, 3, 4, 3);
            panelAdministracion.Name = "panelAdministracion";
            panelAdministracion.Size = new Size(292, 173);
            panelAdministracion.TabIndex = 1;
            // 
            // lblAdministracion
            // 
            lblAdministracion.AutoSize = true;
            lblAdministracion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAdministracion.ForeColor = Color.FromArgb(52, 73, 94);
            lblAdministracion.Location = new Point(18, 12);
            lblAdministracion.Margin = new Padding(4, 0, 4, 0);
            lblAdministracion.Name = "lblAdministracion";
            lblAdministracion.Size = new Size(116, 20);
            lblAdministracion.TabIndex = 0;
            lblAdministracion.Text = "Administración";
            // 
            // panelOperaciones
            // 
            panelOperaciones.BackColor = Color.FromArgb(236, 240, 241);
            panelOperaciones.Controls.Add(Especialidades);
            panelOperaciones.Controls.Add(lblOperaciones);
            panelOperaciones.Controls.Add(btnPacientes);
            panelOperaciones.Controls.Add(btnCitas);
            panelOperaciones.Location = new Point(373, 104);
            panelOperaciones.Margin = new Padding(4, 3, 4, 3);
            panelOperaciones.Name = "panelOperaciones";
            panelOperaciones.Size = new Size(292, 221);
            panelOperaciones.TabIndex = 2;
            // 
            // Especialidades
            // 
            Especialidades.BackColor = Color.FromArgb(46, 204, 113);
            Especialidades.Cursor = Cursors.Hand;
            Especialidades.FlatStyle = FlatStyle.Flat;
            Especialidades.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Especialidades.ForeColor = Color.White;
            Especialidades.Location = new Point(18, 104);
            Especialidades.Margin = new Padding(4, 3, 4, 3);
            Especialidades.Name = "Especialidades";
            Especialidades.Size = new Size(257, 46);
            Especialidades.TabIndex = 4;
            Especialidades.Text = "Especialidades";
            Especialidades.UseVisualStyleBackColor = false;
            Especialidades.Click += btnEspecialidades_Click;
            // 
            // lblOperaciones
            // 
            lblOperaciones.AutoSize = true;
            lblOperaciones.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblOperaciones.ForeColor = Color.FromArgb(52, 73, 94);
            lblOperaciones.Location = new Point(18, 12);
            lblOperaciones.Margin = new Padding(4, 0, 4, 0);
            lblOperaciones.Name = "lblOperaciones";
            lblOperaciones.Size = new Size(95, 20);
            lblOperaciones.TabIndex = 0;
            lblOperaciones.Text = "Operaciones";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 392);
            Controls.Add(panelHeader);
            Controls.Add(panelAdministracion);
            Controls.Add(panelOperaciones);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal - Agenda Médica";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelAdministracion.ResumeLayout(false);
            panelAdministracion.PerformLayout();
            panelOperaciones.ResumeLayout(false);
            panelOperaciones.PerformLayout();
            ResumeLayout(false);
        }

        private Button button1;
        private Button Especialidades;
    }
}