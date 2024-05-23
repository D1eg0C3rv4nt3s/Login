namespace Presentacion.Administrador
{
    partial class Altausuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Altausuario));
            this.Bienvenido = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnalta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCodigop = new System.Windows.Forms.TextBox();
            this.txtNacimiento = new System.Windows.Forms.TextBox();
            this.txtposicion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // Bienvenido
            // 
            this.Bienvenido.AutoSize = true;
            this.Bienvenido.BackColor = System.Drawing.Color.Transparent;
            this.Bienvenido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bienvenido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bienvenido.Font = new System.Drawing.Font("Yu Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bienvenido.Location = new System.Drawing.Point(248, 22);
            this.Bienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bienvenido.Name = "Bienvenido";
            this.Bienvenido.Size = new System.Drawing.Size(280, 45);
            this.Bienvenido.TabIndex = 1;
            this.Bienvenido.Text = "Alta de usuarios";
            this.Bienvenido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bienvenido_MouseDown);
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.SystemColors.Window;
            this.txtEdad.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(68, 243);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(271, 34);
            this.txtEdad.TabIndex = 4;
            this.txtEdad.Text = "Edad:";
            this.txtEdad.Enter += new System.EventHandler(this.txtEdad_Enter);
            this.txtEdad.Leave += new System.EventHandler(this.txtEdad_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txtContraseña.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(422, 177);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(271, 34);
            this.txtContraseña.TabIndex = 7;
            this.txtContraseña.Text = "Contraseña:";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(68, 177);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(271, 34);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Text = "Usuario:";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(422, 111);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(271, 34);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.Text = "Apellido:";
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(68, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(271, 34);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.Text = "Nombre:";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // btnalta
            // 
            this.btnalta.Location = new System.Drawing.Point(330, 488);
            this.btnalta.Name = "btnalta";
            this.btnalta.Size = new System.Drawing.Size(101, 31);
            this.btnalta.TabIndex = 13;
            this.btnalta.Text = "Dar de alta";
            this.btnalta.UseVisualStyleBackColor = true;
            this.btnalta.Click += new System.EventHandler(this.btnalta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(330, 540);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 31);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncerrar.BackgroundImage")));
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncerrar.Location = new System.Drawing.Point(738, 4);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(27, 25);
            this.btncerrar.TabIndex = 15;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnminimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnminimizar.BackgroundImage")));
            this.btnminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnminimizar.Location = new System.Drawing.Point(703, 4);
            this.btnminimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(27, 25);
            this.btnminimizar.TabIndex = 16;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // txtPromedio
            // 
            this.txtPromedio.BackColor = System.Drawing.SystemColors.Window;
            this.txtPromedio.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio.Location = new System.Drawing.Point(68, 371);
            this.txtPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(271, 34);
            this.txtPromedio.TabIndex = 11;
            this.txtPromedio.Text = "Promedio:";
            this.txtPromedio.Enter += new System.EventHandler(this.txtPromedio_Enter);
            this.txtPromedio.Leave += new System.EventHandler(this.txtPromedio_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(68, 307);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(271, 34);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.Text = "Dirección:";
            this.txtDireccion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // txtCodigop
            // 
            this.txtCodigop.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigop.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigop.Location = new System.Drawing.Point(422, 307);
            this.txtCodigop.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigop.Name = "txtCodigop";
            this.txtCodigop.Size = new System.Drawing.Size(271, 34);
            this.txtCodigop.TabIndex = 5;
            this.txtCodigop.Text = "Código postal:";
            this.txtCodigop.Enter += new System.EventHandler(this.txtCodigop_Enter);
            this.txtCodigop.Leave += new System.EventHandler(this.txtCodigop_Leave);
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.BackColor = System.Drawing.SystemColors.Window;
            this.txtNacimiento.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacimiento.Location = new System.Drawing.Point(422, 243);
            this.txtNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(271, 34);
            this.txtNacimiento.TabIndex = 3;
            this.txtNacimiento.Text = "Fecha de nacimiento:";
            this.txtNacimiento.Enter += new System.EventHandler(this.txtNacimineto_Enter);
            this.txtNacimiento.Leave += new System.EventHandler(this.txtNacimineto_Leave);
            // 
            // txtposicion
            // 
            this.txtposicion.BackColor = System.Drawing.SystemColors.Window;
            this.txtposicion.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposicion.Location = new System.Drawing.Point(422, 371);
            this.txtposicion.Margin = new System.Windows.Forms.Padding(4);
            this.txtposicion.Name = "txtposicion";
            this.txtposicion.Size = new System.Drawing.Size(271, 34);
            this.txtposicion.TabIndex = 17;
            this.txtposicion.Text = "Posición:";
            this.txtposicion.Enter += new System.EventHandler(this.txtposicion_Enter);
            this.txtposicion.Leave += new System.EventHandler(this.txtposicion_Leave);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCorreo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(68, 430);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(271, 34);
            this.txtCorreo.TabIndex = 18;
            this.txtCorreo.Text = "Correo:";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // Altausuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 607);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtposicion);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnalta);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCodigop);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNacimiento);
            this.Controls.Add(this.Bienvenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Altausuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altausuario";
            this.Load += new System.EventHandler(this.Altausuario_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Altausuario_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnalta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCodigop;
        private System.Windows.Forms.TextBox txtNacimiento;
        private System.Windows.Forms.TextBox txtposicion;
        private System.Windows.Forms.TextBox txtCorreo;
    }
}