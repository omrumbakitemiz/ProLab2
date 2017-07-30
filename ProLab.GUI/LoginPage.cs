using System;
using System.Windows.Forms;

namespace ProLab.GUI
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(txtbox_kullaniciAdi.Text);

            Hide();

            homePage.Show();
        }
    }
}
