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

        private void button1_Click(object sender, EventArgs e)
        {
            SecimSayfasi anaSayfa = new SecimSayfasi();

            Hide();

            anaSayfa.Show();
        }
    }
}
