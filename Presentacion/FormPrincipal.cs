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
using Comun1.Cache;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void concedido_Load(object sender, EventArgs e)
        {
            LoadUserData();
            //Permisos 
            if(CacheInicioSesion.Posicion == Posiciones.Usuario)
            {
                btndardealta.Enabled = false;
            }

        }

        private void LoadUserData()
        {
            lblNombre.Text = CacheInicioSesion.Nombre+" " +CacheInicioSesion.Apellido;
            lblPosicion.Text = CacheInicioSesion.Posicion;
            lblCorreo.Text = CacheInicioSesion.Correo;
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro de querer salir?", "Los datos se perderán",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de querer cerrar sesión?", "Los datos se perderán",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FormLogin mainmenu = new FormLogin();
                mainmenu.Show();
                this.Hide();
            }

        }

        private void btndardealta_Click(object sender, EventArgs e)
        {
            Administrador.Altausuario mainmenu = new Administrador.Altausuario();
            mainmenu.Show();
            this.Hide();
        }

        private void linklabelperfilusuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPerfilUsuario mainmenu = new FormPerfilUsuario();
            mainmenu.Show();
            this.Hide();
        }

        private void btnVerusuarios_Click(object sender, EventArgs e)
        {
            VerUsuarios mainmenu = new VerUsuarios();
            mainmenu.Show();
            this.Hide();    
        }
    }
}
