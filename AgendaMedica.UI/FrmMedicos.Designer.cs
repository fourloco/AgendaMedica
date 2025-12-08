namespace AgendaMedica.UI
{
    partial class FrmMedicos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Button btnRegresar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelFormulario = new Panel();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            cboEspecialidad = new ComboBox();
            panelBotones = new Panel();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            dgvMedicos = new DataGridView();
            btnRegresar = new Button();
            panelHeader.SuspendLayout();
            panelFormulario.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(26, 188, 156);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(850, 70);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(239, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Médicos";
            // 
            // panelFormulario
            // 
            panelFormulario.BackColor = Color.White;
            panelFormulario.BorderStyle = BorderStyle.FixedSingle;
            panelFormulario.Controls.Add(label1);
            panelFormulario.Controls.Add(txtNombre);
            panelFormulario.Controls.Add(label2);
            panelFormulario.Controls.Add(txtTelefono);
            panelFormulario.Controls.Add(label3);
            panelFormulario.Controls.Add(txtCorreo);
            panelFormulario.Controls.Add(label4);
            panelFormulario.Controls.Add(cboEspecialidad);
            panelFormulario.Location = new Point(20, 90);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(620, 170);
            panelFormulario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(140, 17);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(450, 25);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 58);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 2;
            label2.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.Location = new Point(140, 55);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 25);
            txtTelefono.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(20, 96);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 4;
            label3.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 10F);
            txtCorreo.Location = new Point(140, 93);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(450, 25);
            txtCorreo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(20, 134);
            label4.Name = "label4";
            label4.Size = new Size(85, 19);
            label4.TabIndex = 6;
            label4.Text = "Especialidad:";
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.Font = new Font("Segoe UI", 10F);
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Location = new Point(140, 131);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(450, 25);
            cboEspecialidad.TabIndex = 7;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(245, 245, 245);
            panelBotones.Controls.Add(btnNuevo);
            panelBotones.Controls.Add(btnGuardar);
            panelBotones.Controls.Add(btnEditar);
            panelBotones.Controls.Add(btnEliminar);
            panelBotones.Location = new Point(660, 90);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(170, 170);
            panelBotones.TabIndex = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(52, 152, 219);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(10, 10);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(150, 32);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "➕ Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(46, 204, 113);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(10, 50);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 32);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(241, 196, 15);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(10, 90);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 32);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "✏️ Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(10, 130);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 32);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvMedicos
            // 
            dgvMedicos.AllowUserToAddRows = false;
            dgvMedicos.AllowUserToDeleteRows = false;
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicos.BackgroundColor = Color.White;
            dgvMedicos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMedicos.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(26, 188, 156);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMedicos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMedicos.EnableHeadersVisualStyles = false;
            dgvMedicos.Location = new Point(20, 280);
            dgvMedicos.MultiSelect = false;
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.ReadOnly = true;
            dgvMedicos.RowHeadersVisible = false;
            dgvMedicos.RowTemplate.Height = 30;
            dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicos.Size = new Size(810, 280);
            dgvMedicos.TabIndex = 3;
            dgvMedicos.CellClick += dgvMedicos_CellClick;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(149, 165, 166);
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(20, 580);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(120, 35);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "⬅️ Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FrmMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(850, 630);
            Controls.Add(btnRegresar);
            Controls.Add(dgvMedicos);
            Controls.Add(panelBotones);
            Controls.Add(panelFormulario);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMedicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Médicos";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            ResumeLayout(false);
        }
    }
}