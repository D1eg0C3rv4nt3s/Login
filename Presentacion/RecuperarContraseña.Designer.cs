namespace Presentacion
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.txtcorreousuario = new System.Windows.Forms.Label();
            this.txtsolicitudusuario = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnvolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcorreousuario
            // 
            this.txtcorreousuario.AutoSize = true;
            this.txtcorreousuario.BackColor = System.Drawing.Color.Transparent;
            this.txtcorreousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreousuario.Location = new System.Drawing.Point(42, 42);
            this.txtcorreousuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtcorreousuario.Name = "txtcorreousuario";
            this.txtcorreousuario.Size = new System.Drawing.Size(328, 20);
            this.txtcorreousuario.TabIndex = 1;
            this.txtcorreousuario.Text = "Ingresa tu usuario o correo registrado";
            this.txtcorreousuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtcorreousuario_MouseDown);
            // 
            // txtsolicitudusuario
            // 
            this.txtsolicitudusuario.Location = new System.Drawing.Point(46, 85);
            this.txtsolicitudusuario.Name = "txtsolicitudusuario";
            this.txtsolicitudusuario.Size = new System.Drawing.Size(259, 22);
            this.txtsolicitudusuario.TabIndex = 2;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(280, 138);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 28);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.BackColor = System.Drawing.Color.Transparent;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(42, 195);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(93, 20);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Click += new System.EventHandler(this.lblresultado_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncerrar.BackgroundImage")));
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncerrar.Location = new System.Drawing.Point(862, 4);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(27, 25);
            this.btncerrar.TabIndex = 9;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnminimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnminimizar.BackgroundImage")));
            this.btnminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnminimizar.Location = new System.Drawing.Point(827, 4);
            this.btnminimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(27, 25);
            this.btnminimizar.TabIndex = 10;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            this.btnminimizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnminimizar_MouseDown);
            // 
            // btnvolver
            // 
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnvolver.Location = new System.Drawing.Point(362, 138);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(77, 28);
            this.btnvolver.TabIndex = 18;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 431);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtsolicitudusuario);
            this.Controls.Add(this.txtcorreousuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarContraseña";
            this.Load += new System.EventHandler(this.RecuperarContraseña_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecuperarContraseña_MouseDown);
            this.MouseEnter += new System.EventHandler(this.RecuperarContraseña_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtcorreousuario;
        private System.Windows.Forms.TextBox txtsolicitudusuario;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.Button btnvolver;
    }
}