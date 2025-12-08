namespace AgendaMedica.UI
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;

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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(350, 60);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(95, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(160, 30);
            this.lblTitulo.Text = "Agenda Médica";

            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsuario.Location = new System.Drawing.Point(60, 85);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 19);
            this.lblUsuario.Text = "Usuario:";

            // txtUsuario
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.Location = new System.Drawing.Point(60, 110);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(230, 25);

            // lblContrasena
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblContrasena.Location = new System.Drawing.Point(60, 150);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(80, 19);
            this.lblContrasena.Text = "Contraseña:";

            // txtContrasena
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContrasena.Location = new System.Drawing.Point(60, 175);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(230, 25);
            this.txtContrasena.PasswordChar = '●';

            // btnLogin
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(60, 225);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(230, 40);
            this.btnLogin.Text = "INICIAR SESIÓN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // FrmLogin
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Agenda Médica";
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.btnLogin);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}