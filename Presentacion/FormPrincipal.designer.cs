
namespace Presentacion
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnVerusuarios = new System.Windows.Forms.Button();
            this.lblverusuarios = new System.Windows.Forms.Label();
            this.btndardealta = new System.Windows.Forms.Button();
            this.lbldardealta = new System.Windows.Forms.Label();
            this.linklabelperfilusuario = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncerrar.BackgroundImage")));
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncerrar.Location = new System.Drawing.Point(416, 2);
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
            this.btnminimizar.Location = new System.Drawing.Point(381, 2);
            this.btnminimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(27, 25);
            this.btnminimizar.TabIndex = 16;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(170, 254);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(101, 28);
            this.btnCerrarSesion.TabIndex = 17;
            this.btnCerrarSesion.Text = "Cerrar sesiòn";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 81);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.BackColor = System.Drawing.Color.Transparent;
            this.lblPosicion.Location = new System.Drawing.Point(111, 61);
            this.lblPosicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(59, 16);
            this.lblPosicion.TabIndex = 19;
            this.lblPosicion.Text = "Posición";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Location = new System.Drawing.Point(111, 45);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(48, 16);
            this.lblCorreo.TabIndex = 20;
            this.lblCorreo.Text = "Correo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(111, 29);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre";
            // 
            // btnVerusuarios
            // 
            this.btnVerusuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnVerusuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerusuarios.BackgroundImage")));
            this.btnVerusuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerusuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerusuarios.Location = new System.Drawing.Point(92, 148);
            this.btnVerusuarios.Name = "btnVerusuarios";
            this.btnVerusuarios.Size = new System.Drawing.Size(106, 57);
            this.btnVerusuarios.TabIndex = 22;
            this.btnVerusuarios.UseVisualStyleBackColor = false;
            this.btnVerusuarios.Click += new System.EventHandler(this.btnVerusuarios_Click);
            // 
            // lblverusuarios
            // 
            this.lblverusuarios.AutoSize = true;
            this.lblverusuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblverusuarios.Location = new System.Drawing.Point(111, 208);
            this.lblverusuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblverusuarios.Name = "lblverusuarios";
            this.lblverusuarios.Size = new System.Drawing.Size(75, 16);
            this.lblverusuarios.TabIndex = 23;
            this.lblverusuarios.Text = "Ver usuario";
            // 
            // btndardealta
            // 
            this.btndardealta.BackColor = System.Drawing.Color.Transparent;
            this.btndardealta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndardealta.BackgroundImage")));
            this.btndardealta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndardealta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndardealta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndardealta.Location = new System.Drawing.Point(250, 148);
            this.btndardealta.Name = "btndardealta";
            this.btndardealta.Size = new System.Drawing.Size(105, 57);
            this.btndardealta.TabIndex = 26;
            this.btndardealta.UseVisualStyleBackColor = false;
            this.btndardealta.Click += new System.EventHandler(this.btndardealta_Click);
            // 
            // lbldardealta
            // 
            this.lbldardealta.AutoSize = true;
            this.lbldardealta.BackColor = System.Drawing.Color.Transparent;
            this.lbldardealta.Location = new System.Drawing.Point(247, 208);
            this.lbldardealta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldardealta.Name = "lbldardealta";
            this.lbldardealta.Size = new System.Drawing.Size(120, 16);
            this.lbldardealta.TabIndex = 27;
            this.lbldardealta.Text = "Dar de alta usuario";
            // 
            // linklabelperfilusuario
            // 
            this.linklabelperfilusuario.AutoSize = true;
            this.linklabelperfilusuario.BackColor = System.Drawing.Color.Transparent;
            this.linklabelperfilusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklabelperfilusuario.Location = new System.Drawing.Point(30, 96);
            this.linklabelperfilusuario.Name = "linklabelperfilusuario";
            this.linklabelperfilusuario.Size = new System.Drawing.Size(59, 18);
            this.linklabelperfilusuario.TabIndex = 71;
            this.linklabelperfilusuario.TabStop = true;
            this.linklabelperfilusuario.Text = "Mi perfil";
            this.linklabelperfilusuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelperfilusuario_LinkClicked);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 332);
            this.Controls.Add(this.linklabelperfilusuario);
            this.Controls.Add(this.lbldardealta);
            this.Controls.Add(this.btndardealta);
            this.Controls.Add(this.lblverusuarios);
            this.Controls.Add(this.btnVerusuarios);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "concedido";
            this.Load += new System.EventHandler(this.concedido_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPrincipal_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnVerusuarios;
        private System.Windows.Forms.Label lblverusuarios;
        private System.Windows.Forms.Button btndardealta;
        private System.Windows.Forms.Label lbldardealta;
        private System.Windows.Forms.LinkLabel linklabelperfilusuario;
    }
}