
using System.Net;
using System.Net.Mail;

namespace MailApi.Estrutura
{
    public class EmailServices : IEmail
    {

        private string smtpAdress => "smtp.office365.com";

        private int portNumber => 587;

        private string emailFrom => "";

        private string senha => ""; 



        public void EnviarEmail(string? nome, string? emailContato, string? assunto)
        {
            string destinatario = "gaeque.cf@hotmail.com";
            using (MailMessage emailMensagem = new MailMessage())
            {
                emailMensagem.From = new MailAddress(emailFrom);
                emailMensagem.To.Add(destinatario);
                emailMensagem.Subject = emailContato;
                emailMensagem.Body = $"{nome} \n\n {assunto}";

     

                using (SmtpClient smtp = new SmtpClient(smtpAdress, portNumber))
                {
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(emailFrom, senha);
                    smtp.Send(emailMensagem);
                }

            }
        }

    }
}
