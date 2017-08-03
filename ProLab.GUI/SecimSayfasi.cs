using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProLab.GUI
{
    public partial class SecimSayfasi : Form
    {
        public SecimSayfasi()
        {
            InitializeComponent();
        }

        private void btn_kayitEkleEkrani_Click(object sender, EventArgs e)
        {
            Hide();

            TamirKaydıEkle tamirKaydıEkle = new TamirKaydıEkle();
            tamirKaydıEkle.Show();
        }

        private void btn_kayitGoruntule_Click(object sender, EventArgs e)
        {
            AracArama aracArama = new AracArama();

            Hide();
            aracArama.Show();
        }
    }
}
