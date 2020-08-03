using LojaVirtual.Models;
using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Libaries.Email
{
    public class ContatoEmail
    {

        public static void EnviarContaPorEmail(Contato contato)
        {
            string corpoMsg = string.Format("<h2>Contato - LojaVirtual</h2>" +
                            "<b>Nome: </b> {0} <br />" +
                            "<b>E-mail: </b> {1} <br />" +
                            "<b>Texto: </b> {2} <br />" +
                            "<br /> Email enviado automaticamente do site lojaVirtual",
                            contato.Nome,
                            contato.Email,
                            contato.Texto);

            ExchangeService exchange = new ExchangeService();
            WebCredentials webCredentials = new WebCredentials("rolim.r@hotmail.com", "BGsword368");
            exchange.Credentials = webCredentials;
            exchange.AutodiscoverUrl("rolim.r@hotmail.com");

            EmailMessage message = new EmailMessage(exchange);
            message.Subject = "Contato lojaVirtual teste -Email: " + contato.Email; //Mensagem Assunto
            message.Body = corpoMsg; // Corpo do Email
            message.ToRecipients.Add(new EmailAddress("rolim.r@mail.com")); // Para quem?
            message.ToRecipients.Add(new EmailAddress("rolim.r@icloud.com")); // Para quem?
            message.SendAndSaveCopy(); //enviar mensagem

            /* 
               SMTP -> Servidor que vai enviar a mensagem.
              */
            /*
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("paladino368@gmail.com", "overload863");
                        smtp.EnableSsl = true;
                        string corpoMsg = string.Format("<h2>Contato - LojaVirtual</h2>" +
                            "<b>Nome: </b> {0} <br />" +
                            "<b>E-mail: </b> {1} <br />" +
                            "<b>Texto: </b> {2} <br />" +
                            "<br /> Email enviado automaticamente do site lojaVirtual",
                            contato.Nome,
                            contato.Email,
                            contato.Texto);
           */         
            /*
             MailMenssage -> Construir a Mensagem a ser enviada.
            */
            /*
               MailMessage mensagem = new MailMessage();

               mensagem.From = new MailAddress("paladino368@gmail.com"); //Mensagem De
               mensagem.To.Add("rolim.r@hotmail.com");// Mensagem Para quem?
               mensagem.To.Add("rolim.r@icloud.com");// Mensagem Para quem?
               mensagem.Subject = "Contato lojaVirtual teste - Email: " + contato.Email; //Mensagem Assunto
               mensagem.Body = corpoMsg; // Corpo do Email
               mensagem.IsBodyHtml = true; //Para habilitar HTML na mensagem   

               //enviar mensagem via smtp
               smtp.Send(mensagem);

               */
        }
    }
}
