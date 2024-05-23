using Comun1.Cache;
using Dominio;
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
using System.Xml.Linq;

namespace Presentacion.Administrador
{
    public partial class Altausuario : Form
    {
        public Altausuario()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void Altausuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Bienvenido_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de querer volver?", "Los datos se perderàn",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FormPrincipal mainmenu = new FormPrincipal();
                mainmenu.Show();
                this.Hide();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre:")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre:";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido:")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido:";
                txtApellido.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario:")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario:";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña:")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña:";
                txtContraseña.ForeColor = Color.DimGray;
            }
        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            if (txtEdad.Text == "Edad:")
            {
                txtEdad.Text = "";
                txtEdad.ForeColor = Color.Black;
            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (txtEdad.Text == "")
            {
                txtEdad.Text = "Edad:";
                txtEdad.ForeColor = Color.DimGray;
            }
        }

        private void txtNacimineto_Enter(object sender, EventArgs e)
        {
            if (txtNacimiento.Text == "Fecha de nacimiento:")
            {
                txtNacimiento.Text = "";
                txtNacimiento.ForeColor = Color.Black;
            }
        }

        private void txtNacimineto_Leave(object sender, EventArgs e)
        {
            if (txtNacimiento.Text == "")
            {
                txtNacimiento.Text = "Fecha de nacimiento:";
                txtNacimiento.ForeColor = Color.DimGray;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Dirección:")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.Black;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Dirección:";
                txtDireccion.ForeColor = Color.DimGray;
            }
        }

        private void txtCodigop_Enter(object sender, EventArgs e)
        {
            if (txtCodigop.Text == "Código postal:")
            {
                txtCodigop.Text = "";
                txtCodigop.ForeColor = Color.Black;
            }
        }

        private void txtCodigop_Leave(object sender, EventArgs e)
        {
            if (txtCodigop.Text == "")
            {
                txtCodigop.Text = "Código postal:";
                txtCodigop.ForeColor = Color.DimGray;
            }
        }

        private void txtPromedio_Enter(object sender, EventArgs e)
        {
            if (txtPromedio.Text == "Promedio:")
            {
                txtPromedio.Text = "";
                txtPromedio.ForeColor = Color.Black;
            }
        }

        private void txtPromedio_Leave(object sender, EventArgs e)
        {
            if (txtPromedio.Text == "")
            {
                txtPromedio.Text = "Promedio:";
                txtPromedio.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void txtposicion_Enter(object sender, EventArgs e)
        {
            if (txtposicion.Text == "Posición:")
            {
                txtposicion.Text = "";
                txtposicion.ForeColor = Color.Black;
            }
        }

        private void txtposicion_Leave(object sender, EventArgs e)
        {
            if (txtposicion.Text == "")
            {
                txtposicion.Text = "Posición:";
                txtposicion.ForeColor = Color.DimGray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo:")
            {
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
        private void Altausuario_Load(object sender, EventArgs e)
        {

        }

        private void loaduserData()
        {
            txtNombre.Text = CacheInicioSesion.Nombre;
            txtApellido.Text = CacheInicioSesion.Apellido;
            txtUsuario.Text = CacheInicioSesion.NomUsuario;
            txtContraseña.Text = CacheInicioSesion.Clave;
            txtEdad.Text = CacheInicioSesion.Edad;
            txtNacimiento.Text = CacheInicioSesion.Nacimiento;
            txtDireccion.Text = CacheInicioSesion.Direccion;
            txtCodigop.Text = CacheInicioSesion.CodigoP;
            txtPromedio.Text = CacheInicioSesion.Promedio;
            txtposicion.Text = CacheInicioSesion.Posicion;
            txtCorreo.Text = CacheInicioSesion.Correo;


        }
        private void reset()
        {
            loaduserData();
        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            var modeloUsuario = new ModeloUsuario(
            NomUsuario: txtUsuario.Text,
            Clave: txtContraseña.Text,
            Nombre: txtNombre.Text,
            Apellido: txtApellido.Text,
            Edad: txtEdad.Text,
            Nacimiento: txtNacimiento.Text,
            Direccion: txtDireccion.Text,
            CodigoP: txtCodigop.Text,
            Promedio: txtPromedio.Text,
            Posicion: txtposicion.Text,
            Correo: txtCorreo.Text);
            var result = modeloUsuario.daraltausuario();
            MessageBox.Show(result);
            reset();
        }

    }
}