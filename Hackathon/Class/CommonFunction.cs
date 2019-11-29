using EmailValidation;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Hackathon
{
    class CommonFunction
    {
        // Send Gmail
        public static void Send_Email(string from, string to, string subject, string message, Attachment file = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("17110313@student.hcmute.edu.vn", "k16111999");
            if (file != null)
            {
                mess.Attachments.Add(file);
            }
            try
            {
                client.Send(mess);
                MessageBox.Show("Send new password success in your email");
            }
            catch
            {
                MessageBox.Show("Unable to connect");
            }
        }

        // Get the current time
        public static int getIdOnTime()
        {
            DateTime dateTime = DateTime.Now;
            string hour = dateTime.Hour.ToString();
            string minutes = dateTime.Minute.ToString();
            string secound = dateTime.Second.ToString();
            string miliSecound = dateTime.Millisecond.ToString();
            return int.Parse(hour + minutes + secound + miliSecound);
        }

        // Check Gmail
        public static bool Check_Gmail(string Gmail)
        {
            EmailValidator emailValidator = new EmailValidator();
            EmailValidationResult result;

            if (!emailValidator.Validate(Gmail, out result))
            {
                // No internet connection or mailserver is down or busy
                MessageBox.Show("Unable to check email");
            }

            if (result == EmailValidationResult.OK)
                return true;
            return false;
        }
    }
}
