﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;
using Emgu.CV.CvEnum;

namespace MultiFaceRec
{
    public partial class FrmPrincipal : Form
    {
        #region Variables
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer Sarah = new SpeechSynthesizer();
        SpeechRecognitionEngine startlistening = new SpeechRecognitionEngine();
        int RecTimeOut = 0;

        Thread threadMessger;

        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels= new List<string>();
        List<string> NamePersons = new List<string>();        int ContTrain, NumLabels, t;
        string name, names = null;
        #endregion

        public FrmPrincipal()
        {
            InitializeComponent();
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int i = 1; i < NumLabels+1; i++)
                {
                    LoadFaces = "face" + i + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[i]);
                }
            
            }
            catch
            {
                MessageBox.Show("Mời nhập dữ liệu gương mặt", "Data Load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

		public FrmPrincipal(string temp)
		{
			InitializeComponent();
			this.Name = temp;
			//Load haarcascades for face detection
			face = new HaarCascade("haarcascade_frontalface_default.xml");
			try
			{
				//Load of previus trainned faces and labels for each image
				string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
				string[] Labels = Labelsinfo.Split('%');
				NumLabels = Convert.ToInt16(Labels[0]);
				ContTrain = NumLabels;
				string LoadFaces;

				for (int i = 1; i < NumLabels + 1; i++)
				{
					LoadFaces = "face" + i + ".bmp";
					trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
					labels.Add(Labels[i]);
				}

			}
			catch
			{
				//MessageBox.Show(e.ToString());
				MessageBox.Show("Mời nhập dữ liệu gương mặt", "Data Load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

		}

        private void Default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            int ranNum;
            string speech = e.Result.Text;
            if (speech == "Hello") Sarah.SpeakAsync("JAVIS is here sir");
            if (speech == "How are you") Sarah.SpeakAsync("I'm working normally");
            if (speech == "What time is it") Sarah.SpeakAsync(DateTime.Now.ToString("h mm tt"));
            if (speech == "Good bye JAVIS")
            {
                Sarah.SpeakAsync("Good bye sir, good day");
                Thread.Sleep(1000);
                Environment.Exit(1);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
		{

		}

		private void btn_Gmail_Click(object sender, EventArgs e)
		{
            Sarah.SpeakAsync("Gmail is now online");
            Gmail_Form Form = new Gmail_Form();
			Form.ShowDialog();
		}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Sarah.SpeakAsync("Accessing Google");
            wbView.Navigate("google.com");
        }

        public static void CallFacebook(string email, string password, string user_receive)
        {
            try
            {
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                ChromeOptions options = new ChromeOptions();
                options.AddArgument(Application.StartupPath + "chromedriver.exe");
                options.AddArguments("--incognito");
                options.AddArgument(@"--start-maximized");
                options.AddArgument(@"--disable-infobars");
                options.AddArgument("--disable-user-media-security=true");
                options.AddArgument("--use-fake-ui-for-media-stream=1");

                var driver = new ChromeDriver(driverService, options);


                driver.Navigate().GoToUrl("https://www.messenger.com/login.php");
                Thread.Sleep(1000);
                //driver.Manage().Window.Minimize();
                IWebElement query = driver.FindElement(By.CssSelector("#email"));
                query.SendKeys(email);

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                query = driver.FindElement(By.CssSelector("#pass"));
                query.SendKeys(password);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Thread.Sleep(500);

                query = driver.FindElement(By.CssSelector("#loginbutton"));
                query.Click();
                Thread.Sleep(1000);
                driver.Navigate().GoToUrl("https://www.messenger.com/t/" + user_receive);
                Thread.Sleep(1000);
                query = driver.FindElement(By.XPath(".//*[@data-testid='startVoiceCall']"));
                query.Click();
                Thread.Sleep(5000);
                driver.Quit();
            }
            catch
            {

            }
        }

        private void btnMess_Click(object sender, EventArgs e)
        {
            Sarah.SpeakAsync("Calling Admin");
            Loading();
            threadMessger = new Thread(openMessager);
            threadMessger.SetApartmentState(ApartmentState.STA);
            threadMessger.Start();
        }

        private void Loading()
        {
            Thread thread = new Thread(loadingx);
            thread.Start();
        }

        private void loadingx()
        {
      //      pbxLoading.Visible = true;
            for(int i=0;i<3;i++)
            {
                Thread.Sleep(1000);
            }
            pbxLoading.Visible = false;
        }

        private void openMessager()
        {
            CallFacebook("", "", "");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Sarah.SpeakAsync("Accessing Facebook");
            wbView.Navigate("Facebook.com");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
		{
            Sarah.SpeakAsync("Hi sir. Allow me to introduce myself, I am JAVIS, the virtual artificial intelligence. And I'm here to assist you with the variety of tasks as best as I can, 24 hours a day, 7 days a week.");
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands.txt")))));
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);
            _recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(_recognizer_SpeechRecognized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);

            startlistening.SetInputToDefaultAudioDevice();
            startlistening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands.txt")))));
            startlistening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(startlistening_SpeechRecognized);
            pbxLoading.Visible = false;
            wbView.Navigate("lms.hcmute.edu.vn");
        }

        private void _recognizer_SpeechRecognized(object sender, SpeechDetectedEventArgs e)
        {
            RecTimeOut = 0;
        }

        private void startlistening_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
            if (speech == "Hi")
            {
                startlistening.RecognizeAsyncCancel();
                Sarah.SpeakAsync("Mother fucker, I'm here");
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Sarah.SpeakAsync("Accessing School Dashboard");
            wbView.Navigate("lms.hcmute.edu.vn");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Sarah.SpeakAsync("Accessing Online Portal");
            wbView.Navigate("online.hcmute.edu.vn");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Sarah.SpeakAsync("Accessing Google Free Station");
            System.Diagnostics.Process.Start("http://localhost:3000/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sarah.SpeakAsync("Camera is on");
            System.Diagnostics.Process.Start(@"http://192.168.1.10:4747/video");
        }

        private void tmrSpeaking_Tick(object sender, EventArgs e)
        {
            if (RecTimeOut == 10)
            {
                _recognizer.RecognizeAsyncCancel();
            }
            else if (RecTimeOut == 11)
            {
                tmrSpeaking.Stop();
                startlistening.RecognizeAsync(RecognizeMode.Multiple);
                RecTimeOut = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Initialize the capture device
            grabber = new Emgu.CV.Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            button1.Enabled = false;
            Sarah.SpeakAsync("Webcam is activated");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Trained face counter
                ContTrain = ContTrain + 1;

                //Get a gray frame from capture device
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                //resize face detected image for force to compare the same size with the 
                //test image with cubic interpolation type method
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(textBox1.Text);

                //Show face added in gray scale
                imageBox1.Image = TrainedFace;

                //Write the number of triained faces in a file text for further load
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //Write the labels of triained faces in a file text for further load
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }

                Sarah.SpeakAsync("Welcome " + textBox1.Text);
            }
            catch
            {
                Sarah.SpeakAsync("Sorry, Your face has not been determined");
            }
        }
		void FrameGrabber(object sender, EventArgs e)
		{
			label3.Text = "0";
			//label4.Text = "";
			NamePersons.Add("");


			//Get the current frame form capture device
			currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

			//Convert it to Grayscale
			gray = currentFrame.Convert<Gray, Byte>();

			//Face Detector
			MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
		  face,
		  1.2,
		  10,
		  Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
		  new Size(20, 20));

			//Action for each element detected
			foreach (MCvAvgComp f in facesDetected[0])
			{
				t = t + 1;
				result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
				//draw the face detected in the 0th (gray) channel with blue color
				currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


				if (trainingImages.ToArray().Length != 0)
				{
					//TermCriteria for face recognition with numbers of trained images like maxIteration
					MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

					//Eigen face recognizer
					EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
					   trainingImages.ToArray(),
					   labels.ToArray(),
					   3000,
					   ref termCrit);

					name = recognizer.Recognize(result);

					//Draw the label for each face detected and recognized
					currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

				}

				NamePersons[t - 1] = name;
				NamePersons.Add("");
				//Set the number of faces detected on the scene
				label3.Text = facesDetected[0].Length.ToString();

			}
			t = 0;

			//Names concatenation of persons recognized
			for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
			{
				names = names + NamePersons[nnn] + ", ";
			}
			//Show the faces procesed and recognized
			imageBoxFrameGrabber.Image = currentFrame;
			label4.Text = names;
			names = "";
			//Clear the list(vector) of names
			NamePersons.Clear();

		}
    }
}