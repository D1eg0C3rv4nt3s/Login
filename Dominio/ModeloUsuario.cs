using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Comun1.Cache;
namespace Dominio
{
    public class ModeloUsuario
    {
        UserDao userDao = new UserDao();

        //Atributos
        private int IdUsuario;
        private string NomUsuario;
        private string Clave;
        private string Nombre;
        private string Apellido;
        private string Posicion;
        private string Correo;

        private string Edad;
        private string Nacimiento;
        private string Direccion;
        private string CodigoP;
        private string Promedio;

        public ModeloUsuario(int IdUsuario, string NomUsuario, string Clave, string Nombre, string Apellido, string Edad, string Nacimiento, string Direccion, string CodigoP, string Promedio, string Posicion, string Correo)
        {
            this.IdUsuario = IdUsuario;
            this.NomUsuario = NomUsuario;
            this.Clave = Clave;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Nacimiento = Nacimiento;
            this.Direccion = Direccion;
            this.CodigoP = CodigoP;
            this.Promedio = Promedio;
            this.Correo = Correo;
            this.Posicion = Posicion;
        }

        public ModeloUsuario(string NomUsuario, string Clave, string Nombre, string Apellido, string Edad, string Nacimiento, string Direccion, string CodigoP, string Promedio, string Posicion, string Correo)
        {
            this.NomUsuario = NomUsuario;
            this.Clave = Clave;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Nacimiento = Nacimiento;
            this.Direccion = Direccion;
            this.CodigoP = CodigoP;
            this.Promedio = Promedio;
            this.Posicion = Posicion;
            this.Correo = Correo;

        }

        public ModeloUsuario()
        {

        }

        public string daraltausuario()
        {
            try
            {
                userDao.altausuario(Nombre, Apellido, NomUsuario, Clave, Edad, Nacimiento, Direccion, CodigoP, Promedio, Posicion, Correo);
                return "Nuevo Usuario registrado.";
            }
            catch (Exception)
            {
                return "Error al dar de alta.";
            }
        }
        public string EditarPerfilUsuario()
        {
            try {
                userDao.editarperfil(IdUsuario, NomUsuario, Clave, Nombre, Apellido, Correo);
                LoginUser(NomUsuario, Clave);
                return "Tu perfil se ha actualizado correctamente";
            }
            catch (Exception)
            {
                return "Este usuario ya está registrado, prueba con otro usuario.";
            }
        }
        public bool LoginUser(string usuario, string contrasenia)
        {
            return userDao.Login(usuario, contrasenia);
        }

        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }

        public string Verdatos(string visualizar)
        {
            return userDao.Verdatos(visualizar);
        }
    }
}
