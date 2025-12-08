namespace AgendaMedica.UI
{
    partial class FrmEspecialidades
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.Button btnRegresar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelFormulario = new Panel();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtDescripcion = new TextBox();
            panelBotones = new Panel();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            dgvEspecialidades = new DataGridView();
            btnRegresar = new Button();

            panelHeader.SuspendLayout();
            panelFormulario.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            SuspendLayout();

            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 70);
            panelHeader.TabIndex = 0;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(320, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Especialidades";

            // 
            // panelFormulario
            // 
            panelFormulario.BackColor = Color.White;
            panelFormulario.BorderStyle = BorderStyle.FixedSingle;
            panelFormulario.Controls.Add(label1);
            panelFormulario.Controls.Add(txtNombre);
            panelFormulario.Controls.Add(label2);
            panelFormulario.Controls.Add(txtDescripcion);
            panelFormulario.Location = new Point(20, 90);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(560, 120);
            panelFormulario.TabIndex = 1;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";

            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(130, 17);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(400, 25);
            txtNombre.TabIndex = 1;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 2;
            label2.Text = "Descripción:";

            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.Location = new Point(130, 57);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(400, 45);
            txtDescripcion.TabIndex = 3;

            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(245, 245, 245);
            panelBotones.Controls.Add(btnNuevo);
            panelBotones.Controls.Add(btnGuardar);
            panelBotones.Controls.Add(btnEditar);
            panelBotones.Controls.Add(btnEliminar);
            panelBotones.Location = new Point(600, 90);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(180, 120);
            panelBotones.TabIndex = 2;

            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(52, 152, 219);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(15, 10);
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
            btnGuardar.Location = new Point(15, 45);
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
            btnEditar.Location = new Point(15, 80);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(72, 32);
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
            btnEliminar.Location = new Point(93, 80);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(72, 32);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;

            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.AllowUserToAddRows = false;
            dgvEspecialidades.AllowUserToDeleteRows = false;
            dgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.BackgroundColor = Color.White;
            dgvEspecialidades.BorderStyle = BorderStyle.None;
            dgvEspecialidades.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvEspecialidades.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvEspecialidades.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEspecialidades.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dgvEspecialidades.ColumnHeadersHeight = 35;
            dgvEspecialidades.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvEspecialidades.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvEspecialidades.EnableHeadersVisualStyles = false;
            dgvEspecialidades.Location = new Point(20, 230);
            dgvEspecialidades.MultiSelect = false;
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowHeadersVisible = false;
            dgvEspecialidades.RowTemplate.Height = 30;
            dgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEspecialidades.Size = new Size(760, 280);
            dgvEspecialidades.TabIndex = 3;

            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(149, 165, 166);
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(20, 530);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(120, 35);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "⬅️ Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;

            // 
            // FrmEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(800, 580);
            Controls.Add(btnRegresar);
            Controls.Add(dgvEspecialidades);
            Controls.Add(panelBotones);
            Controls.Add(panelFormulario);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmEspecialidades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Especialidades";

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            ResumeLayout(false);
        }
    }
}