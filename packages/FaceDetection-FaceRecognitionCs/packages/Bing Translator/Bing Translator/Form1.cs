using System;
using System.Speech;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Bing_Translator
{
    public partial class Form1 : Form
    {
        private bool isVnToEng = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_translate_Click(object sender, EventArgs e)
        {
            string strTranslatedText = null;
            try
            {
                TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                client = new TranslatorService.LanguageServiceClient();
                strTranslatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", txt_input.Text, "", "en");
                txt_output.Text = strTranslatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {
            string temp = txt_input.Text;
            SpeechSynthesizer reader = new SpeechSynthesizer();
            reader.Speak(txt_input.Text);
        }
    }
}
