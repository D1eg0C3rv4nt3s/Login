using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.ServiciosCorreo
{
    internal class CorreoSoporteSistema: ServiciosCorreo
    {
        public CorreoSoporteSistema() {

            SenderMail = "notificaciones@mccollect.com.mx";
            Password = "fqgdogwxxalpsfpu";
            Host = "smtp.gmail.com";
            Port = 587;
            ssl = true;
            InitializeSmtpClient();
        }
    }
}
