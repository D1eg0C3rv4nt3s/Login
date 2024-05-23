namespace Presentacion
{
    partial class VerUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerUsuarios));
            this.Panel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuserrequest = new System.Windows.Forms.MaskedTextBox();
            this.Solicitar = new System.Windows.Forms.Button();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Controls.Add(this.pictureBox1);
            this.Panel2.Location = new System.Drawing.Point(126, 12);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(316, 190);
            this.Panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 187);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.BackColor = System.Drawing.Color.Transparent;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(41, 309);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(84, 20);
            this.lblresultado.TabIndex = 1;
            this.lblresultado.Text = "Resultado";
            // 
            // btnvolver
            // 
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnvolver.Location = new System.Drawing.Point(242, 527);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(101, 28);
            this.btnvolver.TabIndex = 18;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncerrar.BackgroundImage")));
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncerrar.Location = new System.Drawing.Point(583, 2);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(27, 25);
            this.btncerrar.TabIndex = 19;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnminimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnminimizar.BackgroundImage")));
            this.btnminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnminimizar.Location = new System.Drawing.Point(548, 2);
            this.btnminimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(27, 25);
            this.btnminimizar.TabIndex = 20;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ingresa el usuario para obtener su información:";
            // 
            // txtuserrequest
            // 
            this.txtuserrequest.Location = new System.Drawing.Point(44, 248);
            this.txtuserrequest.Name = "txtuserrequest";
            this.txtuserrequest.Size = new System.Drawing.Size(245, 22);
            this.txtuserrequest.TabIndex = 22;
            // 
            // Solicitar
            // 
            this.Solicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solicitar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Solicitar.Location = new System.Drawing.Point(329, 243);
            this.Solicitar.Margin = new System.Windows.Forms.Padding(4);
            this.Solicitar.Name = "Solicitar";
            this.Solicitar.Size = new System.Drawing.Size(101, 30);
            this.Solicitar.TabIndex = 23;
            this.Solicitar.Text = "Solicitar";
            this.Solicitar.UseVisualStyleBackColor = true;
            this.Solicitar.Click += new System.EventHandler(this.Solicitar_Click);
            // 
            // VerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 613);
            this.Controls.Add(this.Solicitar);
            this.Controls.Add(this.txtuserrequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerUsuarios";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VerUsuarios_MouseDown);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtuserrequest;
        private System.Windows.Forms.Button Solicitar;
    }
}