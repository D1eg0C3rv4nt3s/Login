using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun1.Cache;
using Dominio;

namespace Presentacion
{
    public partial class FormPerfilUsuario : Form
    {
        public FormPerfilUsuario()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void FormPerfilUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormPerfilUsuario_Load(object sender, EventArgs e)
        {
            loaduserData();
            initializepasseditcontrols();
        }

        private void loaduserData()
        {
            //vista
            lblusuario.Text = CacheInicioSesion.NomUsuario;
            lblnombre.Text = CacheInicioSesion.Nombre;
            lblapellido.Text = CacheInicioSesion.Apellido;
            lblcorreo.Text = CacheInicioSesion.Correo;
            lblcargo.Text = CacheInicioSesion.Posicion;

            //editar panel
            txtUsername.Text = CacheInicioSesion.NomUsuario;
            txtName.Text = CacheInicioSesion.Nombre;
            txtlastname.Text = CacheInicioSesion.Apellido;
            txtmail.Text = CacheInicioSesion.Correo;
            txtpassword.Text = CacheInicioSesion.Clave;
            txtconfirmpassword.Text = CacheInicioSesion.Clave;
            txtactualpassword.Text = "";
        }

        private void initializepasseditcontrols()
        {
            linkeditpass.Text = "Editar";
            txtpassword.Enabled = false;
            txtpassword.UseSystemPasswordChar = true;
            txtconfirmpassword.Enabled = false;
            txtconfirmpassword.UseSystemPasswordChar=true;

        }

        private void reset()
        {
            loaduserData();
            initializepasseditcontrols();
        }

        private void linkeditperfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            loaduserData();
        }

        private void linkeditpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkeditpass.Text == "Editar")
            {
                linkeditpass.Text = "Cancelar";
                txtpassword.Enabled = true;
                txtpassword.Text = "";
                txtconfirmpassword.Enabled = true;
                txtconfirmpassword.Text = "";
            }
            else if(linkeditpass.Text == "Cancelar")
            {
                reset();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text.Length >= 8 && txtpassword.Text.Length <= 12)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    if (txtactualpassword.Text == CacheInicioSesion.Clave)
                    {
                        var modeloUsuario = new ModeloUsuario(
                            IdUsuario: CacheInicioSesion.IdUsuario,
                            NomUsuario: txtUsername.Text,
                            Clave: txtpassword.Text,
                            Nombre: txtName.Text,
                            Apellido: txtlastname.Text,
                            Edad: null,
                            Nacimiento: null,
                            Direccion: null,
                            CodigoP: null,
                            Promedio: null,
                            Posicion: null,
                            Correo: txtmail.Text);
                        var result = modeloUsuario.EditarPerfilUsuario();
                        MessageBox.Show(result);
                        reset();
                        panel1.Visible = false;
                    }
                    else
                        MessageBox.Show("Contraseña actual incorrecta");
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden");
            }
            else
                MessageBox.Show("La contraseña debe tener mínimo 8 caracteres y máximo 12");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            reset();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de querer volver?", "Los datos se perderán",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FormPrincipal mainmenu = new FormPrincipal();
                mainmenu.Show();
                this.Hide();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtactualpassword_TextChanged(object sender, EventArgs e)
        {
            txtactualpassword.UseSystemPasswordChar = true;
        }
    }
}
