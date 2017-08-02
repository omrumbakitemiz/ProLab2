using System;
using System.Windows.Forms;

namespace ProLab.GUI
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa homePage = new AnaSayfa(txtbox_kullaniciAdi.Text);

            Hide();

            homePage.Show();
        }
    }
}
