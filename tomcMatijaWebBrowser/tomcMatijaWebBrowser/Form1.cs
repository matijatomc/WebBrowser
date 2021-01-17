using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomcMatijaWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void BtnNaprijed_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnIdi_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(txtAdresa.Text);
        }

        private void BtnGmail_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.gmail.com");
        }

        private void btnWebmail_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://webmail.carnet.hr/login.php");
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            webBrowser.Print();
        }
    }
}
