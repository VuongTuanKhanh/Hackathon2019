using Hackathon.BSLayer;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TouchlessLib;
using ZXing;

namespace Hackathon
{
    public partial class btnSignup : Form
    {
        #region Constructor
        public TouchlessMgr _touch;
        private Thread threadForm;

        public btnSignup()
        {
            InitializeComponent();
        }
        #endregion

        #region Code Scanner
        private void ReadBarcode(Bitmap bitmap)
        {
            try
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox.Image);
                string decoded = "";
                if (result != null)
                {
                    txtResult.ResetText();
                    decoded = decoded + result.ToString();
                    if (decoded != "")
                    {
                        txtResult.Text = decoded;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Webcame Activities
        public void StartCamera()
        {
            if (_touch.Cameras.Count == 0)
            {
                MessageBox.Show("No USB webcam connected");
                return;
            }
            _touch.CurrentCamera = _touch.Cameras[0];
            _touch.CurrentCamera.CaptureWidth = Constant._previewWidth;
            _touch.CurrentCamera.CaptureWidth = Constant._previewHeight;
            _touch.CurrentCamera.OnImageCaptured += new EventHandler<CameraEventArgs>(OnImageCaptured);
        }

        public void StopCamera()
        {
            try
            {
                if (_touch.CurrentCamera != null)
                {
                    _touch.CurrentCamera.OnImageCaptured -= new EventHandler<CameraEventArgs>(OnImageCaptured);
                    _touch.CurrentCamera.Dispose();
                    //_touch.RefreshCameraList();
                }
            }
            catch
            {
                return;
            }
        }

        private void OnImageCaptured(object sender, CameraEventArgs args)
        {
            Bitmap bitmap = args.Image;
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pictureBox.Image = bitmap;
                    ReadBarcode(bitmap);
                });
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region Button Event

        // Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check ID format
            try
            {
                int.Parse(txtUsername.Text);
            }
            catch
            {
                MessageBox.Show("Invalid ID format !", "Warning");
                return;
            }

            // Arguments
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            LoginBS loginBS = new LoginBS();
            if (bool.Parse(loginBS.Login(Username, Password)))
            {
                MessageBox.Show("Success");
            }
            else
                MessageBox.Show("Username or Password incorrect. Please try again.");
        }

        // Load Form
        private void btnSignup_Load(object sender, EventArgs e)
        {
            _touch = new TouchlessMgr();
            StartCamera();
        }

        // Close Form
        private void btnSignup_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopCamera();
        }

        // Load File Button
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                //dlg.Filter = "bmp files (*.bmp)|*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = null;
                    try
                    {
                        bitmap = new Bitmap(dlg.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("File not supported.");
                        return;
                    }
                    pictureBox.Image = new Bitmap(dlg.FileName);
                    ReadBarcode((Bitmap)pictureBox.Image);
                }
            }
        }

        // Forget Password
        private void lbForgetPassword_Click(object sender, EventArgs e)
        {
            threadForm = new Thread(openFormForgetPassword);
            threadForm.SetApartmentState(ApartmentState.STA);
            threadForm.Start();
        }

        // Sign In
        private void lbSignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignin frmSignin = new frmSignin();
            this.Hide();
            frmSignin.ShowDialog();
            this.Show();
        }
        #endregion

        #region Other Function
        private void openFormForgetPassword()
        {
            Application.Run(new frmForgetPassword());
        }

        // Login with Scanner
        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            string Username = txtResult.Text;
            LoginBS loginBS = new LoginBS();
            if (bool.Parse(loginBS.Login(Username)))
            {
                MessageBox.Show("Success");
            }
        }
        #endregion
    }
}