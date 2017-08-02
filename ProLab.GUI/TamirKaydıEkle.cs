using System;
using System.Collections;
using System.Windows.Forms;
using ProLab.GUI.Data.Context;
using ProLab.GUI.Data.Models;

namespace ProLab.GUI
{
    public partial class TamirKaydıEkle : Form
    {
        public string Plaka { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }

        private KaportaIslemi _kaporta;
        private ElektrikIslemi _elektrik;
        private MotorIslemi _motor;
        private LastikIslemi _lastik;

        public TamirKaydıEkle(string plaka, string marka, string model)
        {
            Plaka = plaka;
            Model = model;
            Marka = marka;
            InitializeComponent();
        }

        private void AddRepairingRecord_Load(object sender, EventArgs e)
        {
            lbl_plaka.Text = Plaka;
            lbl_marka.Text = Marka;
            lbl_model.Text = Model;
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
                Iscilik = txb_kprtIscilik.Text
            };
        }
        
        private void btn_elkEkle_Click(object sender, EventArgs e)
        {
            _elektrik = new ElektrikIslemi
            {
                Usta = txb_elkUsta.Text,
                Durum = Durum.TamirBaslamadi,
                DegisenParca = txb_elkDegisen.Text,
                DegisenParcaFiyat = txb_elkDegisenFiyat.Text,
                Iscilik = txb_elkIscilik.Text
            };
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
                Iscilik = txb_mtrIscilik.Text
            };
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
        }

        private void btn_kaydiTamamla_Click(object sender, EventArgs e)
        {
            KaportaIslemi kaporta = new KaportaIslemi
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

            ElektrikIslemi elektrik = new ElektrikIslemi
            {
                Usta = txb_elkUsta.Text,
                Durum = Durum.TamirBaslamadi,
                DegisenParca = txb_elkDegisen.Text,
                DegisenParcaFiyat = txb_elkDegisenFiyat.Text,
                Fiyat = txb_elkFiyat.Text,
                Iscilik = txb_elkIscilik.Text
            };

            MotorIslemi motor = new MotorIslemi
            {
                Usta = txb_mtrUsta.Text,
                Durum = Durum.TamirBaslamadi,
                DegisenParca = txb_mtrDegisen.Text,
                DegisenParcaFiyat = txb_mtrDegisenFiyat.Text,
                TamirEdilenParca = txb_mtrTamirEdilen.Text,
                TamirEdilenFiyat = txb_mtrTamirEdilenFiyat.Text,
                Fiyat = txb_mtrFiyat.Text,
                Iscilik = txb_mtrIscilik.Text
            };

            LastikIslemi lastik = new LastikIslemi
            {
                Usta = txb_lastikUsta.Text,
                Durum = Durum.TamirBaslamadi,
                LastikMarka = txb_lastikDegisen.Text,
                Adet = txb_lastikDegisenAdet.Text,
                Fiyat = txb_lastikIscilik.Text,
                Iscilik = txb_lastikIscilik.Text
            };

            Arac arac = new Arac
            {
                Plaka = "41AB1234",
                Model = "2012",
                Marka = "BMW",
                Tarih = DateTime.Now
            };

            arac.TamirEkle(kaporta);
            arac.TamirEkle(elektrik);
            arac.TamirEkle(motor);
            arac.TamirEkle(lastik);

            TamirhaneDBContext islemModel = new TamirhaneDBContext();
            islemModel.Araclar.Add(arac);
            islemModel.SaveChanges();
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
    }
}
