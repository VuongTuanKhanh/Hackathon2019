using Hackathon.BSLayer;
using System;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace Hackathon
{
    public partial class frmForgetPassword : Form
    {
        private Thread threadEmail;

        public frmForgetPassword()
        {
            InitializeComponent();
        }

        string Gmail;
        int New_Password;

        private void button1_Click(object sender, EventArgs e)
        {
            // Take out the Username
            string Username = txtUsername.Text;

            // Take out the Gmail from the Username
            ForgetPasswordBS forgetPasswordBS = new ForgetPasswordBS();
            Gmail = forgetPasswordBS.Send_Mail_To(Username);

            // Generate a new Password
            Random rd = new Random();
            New_Password = rd.Next(1000000, 99999999);
            forgetPasswordBS.Change_Password(Username, New_Password.ToString());

            // Send Email
            try
            {
                threadEmail = new Thread(send_Email);
                threadEmail.SetApartmentState(ApartmentState.STA);
                threadEmail.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect");
            }
        }
        private void send_Email()
        {
            Attachment attachment = new Attachment(@"C:\Users\HP\Desktop\Hackathon\Logo\Google-Station-free-wifi-1280x720.jpg");
            CommonFunction.Send_Email("17110313@student.hcmute.edu.vn", Gmail, "Reset Password", "Mật khẩu mới của bạn là: " + New_Password, attachment);
        }
    }
}
