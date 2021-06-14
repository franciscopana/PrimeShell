using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Medicamentos
{
    class Email
    {
        private static string EmailSender;
        private static string Credential;

        public static void SendEmail(string email, string MessageBody, string Subject, bool emergency = false, bool cancel=false)
        {

            MailMessage message = new MailMessage();

            //Email Used By Company (Gmail)
            EmailSender = "primeshell.official@gmail.com";

            //Password Of Mail Company
            Credential = "rumoao20";

            message.To.Add(email);

            message.From = new MailAddress(EmailSender);

            message.Body = MessageBody;

            message.Subject = Subject;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.EnableSsl = true;

            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new NetworkCredential(EmailSender, Credential);

            try
            {
                smtp.Send(message);

                if(emergency)
                {
                    if (frmLogin.trad)
                        MessageBox.Show("Pedido SOS enviado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("SOS request was sent", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(cancel)
                {
                    return;
                }
                else
                {
                    if(frmLogin.trad)
                        MessageBox.Show("Se o Gmail for válido vamos enviar-lhe o código", "Processo de confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("If gmail is valid, you will be provided with a code constantly!", "Confirmation Procedure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool IsGmailValid(string email)
        {
            // Building Regex:

            // ^[a-z0-9] : the email string should begin with a lowercase character ranging from a-z or begin with a number ranging from 0-9;
            // (\.?[a-z0-9]){5,} : First Character of beggining of string should be followed by at least five alphanumeric characters and those characters could be preceded by a dot or not (is optional => ?)
            // @g(oogle)?mail : After That The string should contain @ (this symbol) and migh be followed by oogle (but is optional => ?), however must contain mail (pattern)
            // \.com$ : To finish our validation we just need to check for a dot and com(universal pattern) we append the dollar sign so that we know the string has ended.

            // Example Valid Email:
            // rodrigosa@googlemail.com || samuelsantos@gmail.com || 2.003marco@gmail.com

            //Example Invalid Email:
            // Ana.@gmail.pt || Errors : First letter is Upper Case, Less Than five alphanumeric characters, Dot after Characters , Does Not Accept "pt"


            Regex regex = new Regex(@"^[a-z0-9](\.?[a-z0-9]){5,}@g(oogle)?mail\.com$");

            Match match = regex.Match(email);

            if (match.Success)
            {
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}
