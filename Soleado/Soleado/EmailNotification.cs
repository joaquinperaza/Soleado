using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace Soleado
{
    public class EmailNotification
    {
        public EmailNotification(Task t)
        {


                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("barcobus.noreply@gmail.com");
                msg.To.Add(t.Usuario.Mail);
                msg.Subject = t.Usuario.NombreDeUsuario+" Soleado - Actualizacion climatica";
                msg.Body = "";

                //msg.Attachments.Add(new Attachment(attachedFile)); 

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "barcobus.noreply@gmail.com";
                ntcd.Password = "BarcoBus123";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                System.Diagnostics.Debug.WriteLine("Your Mail is sended");  

            
        }
    }
}