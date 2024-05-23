using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Comun1.Cache;

namespace AccesoDatos
{

    public class UserDao:ConnectionToSql
    {
        public void editarperfil(int id, string usuario, string contraseña, string nombre, string apellido, string correo)
        {
            using (var cn = GetConnection()) { 
            
                cn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = cn;
                    command.CommandText = "update Users set  " + 
                    "NomUsuario=@usuario, Clave=@contraseña, Nombre=@nombre, Apellido=@apellido, Correo=@correo where IdUsuario=@id";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }

        }

        
        public void altausuario(string Nombre, string Apellido, string NomUsuario, string Clave, string Edad,
            string Nacimiento, string Direccion, string CodigoP, string Promedio, string Posicion, string Correo)
        {

            bool altaregistro;
            string respuesta;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection= cn;
                    command.CommandText = "sp_AltaUsuario";
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido", Apellido);
                    command.Parameters.AddWithValue("@NomUsuario", NomUsuario);
                    command.Parameters.AddWithValue("@Clave", Clave);
                    command.Parameters.AddWithValue("@Edad", Edad);
                    command.Parameters.AddWithValue("@Nacimiento", Nacimiento);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@CodigoP", CodigoP);
                    command.Parameters.AddWithValue("@Promedio", Promedio);
                    command.Parameters.AddWithValue("@Posicion", Posicion);
                    command.Parameters.AddWithValue("@Correo", Correo);

                    command.Parameters.Add("AltaRegistro", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    command.Parameters.Add("Respuesta", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();

                    altaregistro = Convert.ToBoolean(command.Parameters["AltaRegistro"].Value);
                    respuesta = command.Parameters["Respuesta"].Value.ToString();
                }

            }

        }
        public bool Login(string usuario, string contrasenia)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Users where NomUsuario = @usuario and Clave = @contrasenia";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contrasenia", contrasenia);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            CacheInicioSesion.IdUsuario = reader.GetInt32(0);
                            CacheInicioSesion.NomUsuario = reader.GetString(1);
                            CacheInicioSesion.Clave = reader.GetString(2);
                            CacheInicioSesion.Nombre = reader.GetString(3);
                            CacheInicioSesion.Apellido = reader.GetString(4);
                            CacheInicioSesion.Posicion = reader.GetString(10);
                            CacheInicioSesion.Correo = reader.GetString(11);

                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }


        public string Verdatos(string visualizar)
        {
            using (var cn = GetConnection())
            {
                cn.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = cn;
                    command.CommandText = "select * from Users where NomUsuario=@user";
                    command.Parameters.AddWithValue("@user", visualizar);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string Username = reader.GetString(3) + " " + reader.GetString(4);
                        string Edad = reader.GetString(5);
                        string Nacimiento = reader.GetString(6);
                        string Direccion = reader.GetString(7) + ", " + reader.GetString(8);
                        string Promedio = reader.GetString(9);
                        string Posicion = reader.GetString(10);
                        string Correo = reader.GetString(11);



                        return "Hola, estos son los datos de " + Username + "\n\n" +
                            "Edad: " + Edad + "\nFecha de nacimiento: " + Nacimiento + "\nDirección: " + Direccion +
                            "\nPromedio: " + Promedio + "\nCargo que desempeña: " + Posicion + "\nCorreo electronico: " + Correo;
                    }
                    else
                        return "Lo sentimos, no encontramos una cuenta registrada\n con ese usuario, pruebe con otro nombre.";
                }
            }
        }
        //
        public string recoverPassword(string userRequesting)
        {
            using (var cn = GetConnection())
            {
                cn.Open();
                using ( var command = new SqlCommand())
                {
                    command.Connection = cn;
                    command.CommandText = "select * from Users where NomUsuario=@user or Correo=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + " " + reader.GetString(4);
                        string userMail = reader.GetString(11);
                        string accountPassword = reader.GetString(2);

                        var servicioCorreo = new ServiciosCorreo.CorreoSoporteSistema();
                        servicioCorreo.sendMail(
                            subject: "SISTEMA: Solicitud de recuperación de contraseña",
                            body: "Hola, " + userName + "\nSolicitaste una recuperación de contraseña.\n" +
                            "tu contraseña actual es: " + accountPassword +
                            "\nSin embargo, le pedimos que cambie su contraseña antes de que ingrese al sistema.",
                            recipientMail: new List<string> { userMail });

                        return "Hola, " + userName + "\nSolicitaste una recuperación de contraseña.\n" +
                            "Por favor revisa tu correo electrónico: " + userMail +
                            "\nSin embargo, le pedimos que cambie su contraseña antes de que ingrese al sistema.";
                    }
                    else
                        return "Lo sentimos, no encontramos una cuenta registrada con ese correo y/o usuario";
                }
            }
        }
        public void Acceso()
        {
            if (CacheInicioSesion.Posicion == Posiciones.Administrador)
            {

            }
            if (CacheInicioSesion.Posicion == Posiciones.Usuario)
            {

            }
        }
    }
}
