using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgendaMedica.UI
{
    partial class FrmUsuarios
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
            dgvUsuarios = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            cmbRol = new ComboBox();
            btnRegresar = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblUsuarioSesion = new Label();
            panelFormulario = new Panel();
            lblUsuario = new Label();
            lblContrasena = new Label();
            lblRol = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panelHeader.SuspendLayout();
            panelFormulario.SuspendLayout();
            SuspendLayout();

            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(142, 68, 173);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblUsuarioSesion);
            panelHeader.Controls.Add(btnRegresar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 70);

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 30);
            lblTitulo.Text = "Gestión de Usuarios";

            // 
            // lblUsuarioSesion
            // 
            lblUsuarioSesion.Font = new Font("Segoe UI", 10F);
            lblUsuarioSesion.ForeColor = Color.White;
            lblUsuarioSesion.Location = new Point(500, 25);
            lblUsuarioSesion.Name = "lblUsuarioSesion";
            lblUsuarioSesion.Size = new Size(200, 20);
            lblUsuarioSesion.Text = "Usuario: ---";

            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(192, 57, 43);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(710, 15);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 40);
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += new EventHandler(this.btnRegresar_Click);

            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(125, 60, 152);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvUsuarios.Location = new Point(20, 90);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(760, 300);
            dgvUsuarios.CellClick += new DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);

            // 
            // panelFormulario
            // 
            panelFormulario.BackColor = Color.FromArgb(243, 239, 247);
            panelFormulario.Controls.Add(lblUsuario);
            panelFormulario.Controls.Add(txtUsuario);
            panelFormulario.Controls.Add(lblContrasena);
            panelFormulario.Controls.Add(txtContrasena);
            panelFormulario.Controls.Add(lblRol);
            panelFormulario.Controls.Add(cmbRol);
            panelFormulario.Location = new Point(20, 410);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(760, 80);

            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(125, 60, 152);
            lblUsuario.Location = new Point(15, 10);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(55, 15);
            lblUsuario.Text = "Usuario:";

            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.Location = new Point(15, 30);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 25);

            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContrasena.ForeColor = Color.FromArgb(125, 60, 152);
            lblContrasena.Location = new Point(280, 10);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(75, 15);
            lblContrasena.Text = "Contraseña:";

            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 10F);
            txtContrasena.Location = new Point(280, 30);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(200, 25);

            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRol.ForeColor = Color.FromArgb(125, 60, 152);
            lblRol.Location = new Point(495, 10);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(30, 15);
            lblRol.Text = "Rol:";

            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Font = new Font("Segoe UI", 10F);
            cmbRol.Items.AddRange(new object[] { "Admin", "Recepcion" });
            cmbRol.Location = new Point(495, 30);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(180, 25);

            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(39, 174, 96);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(20, 510);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 40);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += new EventHandler(this.btnAgregar_Click);

            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(142, 68, 173);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(150, 510);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 40);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += new EventHandler(this.btnActualizar_Click);

            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 57, 43);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(280, 510);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += new EventHandler(this.btnEliminar_Click);

            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 570);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Controls.Add(panelHeader);
            Controls.Add(dgvUsuarios);
            Controls.Add(panelFormulario);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Usuarios - Agenda Médica";
            Load += new EventHandler(this.FrmUsuarios_Load);

            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnActualizar;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private ComboBox cmbRol;
        private Button btnRegresar;
        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblUsuarioSesion;
        private Panel panelFormulario;
        private Label lblUsuario;
        private Label lblContrasena;
        private Label lblRol;
    }
}