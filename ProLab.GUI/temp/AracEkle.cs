using System;
using System.Windows.Forms;

namespace ProLab.GUI
{
    public partial class AracEkle : Form
    {
        public string KullaniciAdi { get; set; }
        public string Plaka { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }

        public AracEkle(string kullaniciAdi)
        {
            InitializeComponent();
            KullaniciAdi = kullaniciAdi;
            Plaka = txtbox_plaka.Text;
            Model = txtbox_model.Text;
            Marka = txtbox_marka.Text;
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            var check = true;
            /*
            #region Eksik bilgi kontrolü

            if (txtbox_plaka.Text == string.Empty ||
                txtbox_marka.Text == string.Empty ||
                txtbox_model.Text == string.Empty)
            {
                check = false;
                MessageBox.Show("Lütfen bilgileri eksiksiz girin.",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            #endregion
            */
            if (check)
            {
                TamirKaydıEkle addRepairingRecord = new TamirKaydıEkle();

                Hide();
                addRepairingRecord.Show();
            }
        }

        private void AddRecord_Load(object sender, EventArgs e)
        {
            lbl_kullaniciAdi.Text = $"Merhaba {KullaniciAdi}";
        }
    }
}
