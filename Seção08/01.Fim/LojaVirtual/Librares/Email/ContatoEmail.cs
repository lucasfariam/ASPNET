using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Librares.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail( Contato contato )
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("testelojavirtuallucas@gmail.com", "!suzana123");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("Contato   Loja Virtual" +
             "<b>Nome:</b> <br /> {0} <br />" +
             "<b>Email:</b> <br /> {1} <br />" +
             "<b>Texto:</b> <br /> {2} <br />" +
             "<br /> Email enviado automaticamente",
             contato.Nome,
             contato.Email,
             contato.Texto
                 );

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("testelojavirtuallucas@gmail.com");
            mensagem.To.Add("testelojavirtuallucas@gmail.com");
            mensagem.Subject = "Contato - Loja Virtual - E-mail: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            //enviar msg via smtp
            smtp.Send(mensagem);

        }
    }
}
