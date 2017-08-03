using System;
using System.Collections;
using System.Windows.Forms;
using ProLab.GUI.Data.Context;
using ProLab.GUI.Data.Models;

namespace ProLab.GUI
{
    public partial class TamirKaydıEkle : Form
    {
        private KaportaIslemi _kaporta;
        private ElektrikIslemi _elektrik;
        private MotorIslemi _motor;
        private LastikIslemi _lastik;
        private Arac _arac;
        private TamirhaneDBContext _ctx;

        public TamirKaydıEkle()
        {
            InitializeComponent();
        }

        private void AddRepairingRecord_Load(object sender, EventArgs e)
        {   
            _ctx = new TamirhaneDBContext();

            lbl_plaka.Text = string.Empty;
            lbl_marka.Text = string.Empty;
            lbl_model.Text = string.Empty;
            lbl_tarih.Text = string.Empty;
        }

        private void btn_kprtEkle_Click(object sender, EventArgs e)
        {
            _kaporta = new KaportaIslemi
            {
                Usta = txb_kprtUsta.Text,
                Durum = Durum.TamirBaslamadi,
                DegisenParca = txb_kprtDegisen.Text,
                DegisenParcaFiyat = txb_kprtDegisenFiyat.Text,
                BoyananParca = txb_kprtBoyanan.Text,
                BoyananParcaFiyat = txb_kprtBoyananFiyat.Text,
                Fiyat = txb_kprFiyat.Text,
                Iscilik = txb_kprtIscilik.Text
            };
            
            _arac.TamirEkle(_kaporta);
        }
        
        private void btn_elkEkle_Click(object sender, EventArgs e)
        {
            _elektrik = new ElektrikIslemi
            {
                Usta = txb_elkUsta.Text,
                Durum = Durum.TamirBaslamadi,
                DegisenParca = txb_elkDegisen.Text,
                DegisenParcaFiyat = txb_elkDegisenFiyat.Text,
                Iscilik = txb_elkIscilik.Text,
                Fiyat = txb_elkFiyat.Text
            };

            _arac.TamirEkle(_elektrik);
        }

        private void btn_mtrEkle_Click(object sender, EventArgs e)
        {
            _motor = new MotorIslemi
            {
                Usta = txb_mtrUsta.Text,
                Durum = Durum.TamirBaslamadi,
                DegisenParca = txb_mtrDegisen.Text,
                DegisenParcaFiyat = txb_mtrDegisenFiyat.Text,
                TamirEdilenParca = txb_mtrTamirEdilen.Text,
                TamirEdilenFiyat = txb_mtrTamirEdilenFiyat.Text,
                Iscilik = txb_mtrIscilik.Text,
                Fiyat = txb_mtrFiyat.Text
            };

            _arac.TamirEkle(_motor);
        }

        private void btn_lastikEkle_Click(object sender, EventArgs e)
        {
            _lastik = new LastikIslemi
            {
                Usta = txb_lastikUsta.Text,
                Durum = Durum.TamirBaslamadi,
                LastikMarka = txb_lastikDegisen.Text,
                Adet = txb_lastikDegisenAdet.Text,
                Fiyat = txb_lastikIscilik.Text,
                Iscilik = txb_lastikIscilik.Text
            };
            
            _arac.TamirEkle(_lastik);
        }

        private void btn_kaydiTamamla_Click(object sender, EventArgs e)
        {
            _ctx.Araclar.Add(_arac);
            _ctx.SaveChanges();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            TextBoxTemizle();
        }

        private void TextBoxTemizle()
        {
            void Func(IEnumerable controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        Func(control.Controls);
            }

            Func(Controls);
        }

        private void btn_aracEkle_Click(object sender, EventArgs e)
        {
            _arac = new Arac()
            {
                Plaka = txb_plaka.Text,
                Model = txb_model.Text,
                Marka = txb_marka.Text,
                Tarih = DateTime.Now.ToString()
            };

            lbl_plaka.Text = _arac.Plaka;
            lbl_marka.Text = _arac.Marka;
            lbl_model.Text = _arac.Model;
            lbl_tarih.Text = _arac.Tarih;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            
            SecimSayfasi secimSayfasi = new SecimSayfasi();
            secimSayfasi.Show();
        }
    }
}
