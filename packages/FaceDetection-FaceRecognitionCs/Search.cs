using System;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            wb_Video.Navigate("google.com");
        }
    }
}
