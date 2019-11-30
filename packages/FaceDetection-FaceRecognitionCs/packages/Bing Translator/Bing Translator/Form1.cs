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
                if (!isVnToEng)
                    strTranslatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", txt_input.Text, "", "en");
                else
                    strTranslatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", txt_input.Text, "", "vi");
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

        private void btnSwap_Click(object sender, EventArgs e)
        {
            txt_input.Clear();
            txt_output.Clear();
            if (!isVnToEng)
            {
                pbxENG.Image = Image.FromFile("vietnam_127px.png");
                pbxVN.Image = Image.FromFile("great_britain_127px.png");
                isVnToEng = true;
            }
            else
            {
                isVnToEng = false;
                pbxVN.Image = Image.FromFile("vietnam_127px.png");
                pbxENG.Image = Image.FromFile("great_britain_127px.png");
            }
        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {
            string temp = txt_input.Text;
            SpeechSynthesizer reader = new SpeechSynthesizer();
            if (isVnToEng)
                reader.Speak(txt_input.Text);
            else
                reader.Speak(txt_output.Text);
        }
    }
}
