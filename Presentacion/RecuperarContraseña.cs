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
using Dominio;

namespace Presentacion
{
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var user = new ModeloUsuario();
            var result = user.recoverPassword(txtsolicitudusuario.Text);
            lblresultado.Text = result;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnminimizar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtcorreousuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            FormLogin mainmenu = new FormLogin();
            mainmenu.Show();
            this.Hide();
        }

        private void RecuperarContraseña_MouseEnter(object sender, EventArgs e)
        {

        }

        private void RecuperarContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }
    }
}
