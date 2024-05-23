using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Dominio;
using Comun1.Cache;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "Correo:")
            {
                if (txtContraseña.Text != "Contraseña:")
                {
                    ModeloUsuario usuario = new ModeloUsuario();
                    var ValidLogin = usuario.LoginUser(txtCorreo.Text, txtContraseña.Text);
                    if (ValidLogin == true)
                    {
                        this.Hide();
                        FormBienvenida bienvenida = new FormBienvenida();
                        bienvenida.ShowDialog();

                        FormPrincipal mainMenu = new FormPrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                    }
                    else
                    {
                        msgError("Usuario y/o contraseña incorrectos. \n Por favor, prueba de nuevo.");
                        txtContraseña.Text = "Contraseña:";
                        txtCorreo.Focus();
                    }
                }
                else msgError("Por favor ingrese su contraseña.");
            }
            else msgError("Por favor ingrese su nombre de usuario y contraseña.");

        }
        private void msgError(string msg)
        {
            lblMensajedeerror.Text = msg;
            lblMensajedeerror.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtContraseña.Text = "Contraseña:";
            txtContraseña.UseSystemPasswordChar = false;
            txtCorreo.Text = "Correo:";
            lblMensajedeerror.Visible = false;
            this.Show(); 
        }
        private void Registrarme_Click(object sender, EventArgs e)
        {

        }   
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
            var recoverPassword = new RecuperarContraseña();
            recoverPassword.ShowDialog();
        }
        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if(txtCorreo.Text == "Correo:"){
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo:";
                txtCorreo.ForeColor = Color.DimGray;
            }
        }
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "Contraseña:")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña:";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
