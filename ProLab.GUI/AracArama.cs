using System;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ProLab.GUI.Data.Context;
using ProLab.GUI.Data.Models;

namespace ProLab.GUI
{
    public partial class AracArama : Form
    {
        private string _plaka;
        private TamirhaneDBContext _ctx;

        public AracArama()
        {
            InitializeComponent();
        }

        private void VeriSorgula()
        {
            _plaka = txb_aracPlaka.Text;

            _ctx = new TamirhaneDBContext();

            var list = _ctx.Araclar.ToList();

            var kaporta = list.Where(p => p.Plaka == _plaka).SelectMany(x => x.KaportaIslemleri).ToList();
            var elektrik = list.Where(p => p.Plaka == _plaka).SelectMany(x => x.ElektrikIslemleri).ToList();
            var motor = list.Where(p => p.Plaka == _plaka).SelectMany(x => x.MotorIslemleri).ToList();
            var lastik = list.Where(p => p.Plaka == _plaka).SelectMany(x => x.LastikIslemleri).ToList();

            dataGridView1.DataSource = kaporta;
            dataGridView2.DataSource = elektrik;
            dataGridView3.DataSource = motor;
            dataGridView4.DataSource = lastik;
        }

        private void btn_kayitAra_Click(object sender, EventArgs e)
        {
            VeriSorgula();
        }

        private void btn_secimSayfasınaGit_Click(object sender, EventArgs e)
        {
            Hide();

            SecimSayfasi secimSayfasi = new SecimSayfasi();
            secimSayfasi.Show();
        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            var islemId = Convert.ToInt32(txb_islemID.Text);
            var islemDurumutemp = txb_islemDurumu.Text;
            var islemDurumu = Durum.TamirBaslamadi;
            var islemAdi = comboBox_islemAdi.SelectedItem.ToString();

            #region İşlemDurumu Kontrolü
            if (islemDurumutemp == "0")
            {
                islemDurumu = Durum.TamirBaslamadi;
            }
            if (islemDurumutemp == "1")
            {
                islemDurumu = Durum.TamirEdiliyor;
            }
            if (islemDurumutemp == "2")
            {
                islemDurumu = Durum.TamirBitti;
            }
            
            #endregion

            #region İşlemAdi Kontrolü
            if (islemAdi == "Kaporta")
            {
                _ctx.KaportaIslemleri.First(p => p.KaportaIslemID == islemId).Durum = islemDurumu;
            }
            if (islemAdi == "Elektrik")
            {
                _ctx.ElektrikIslemleri.First(p => p.ElektrikIslemID == islemId).Durum = islemDurumu;
            }
            if (islemAdi == "Motor")
            {
                _ctx.MotorIslemleri.First(p => p.MotorIslemID == islemId).Durum = islemDurumu;
            }
            if (islemAdi == "Lastik")
            {
                _ctx.LastikIslemleri.First(p => p.LastikIslemID == islemId).Durum = islemDurumu;
            }
            #endregion

            _ctx.SaveChanges();

            VeriSorgula();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            _ctx = new TamirhaneDBContext();

            var islemAdi = comboBox_islemAdi.SelectedItem.ToString();
            var islemId = Convert.ToInt32(txb_islemID.Text);

            #region İşlemAdi'na Göre Silme İşlemleri
            if (islemAdi == "Kaporta")
            {
                _ctx.KaportaIslemleri.Remove(_ctx.KaportaIslemleri.First(p => p.KaportaIslemID == islemId));
            }
            if (islemAdi == "Elektrik")
            {   
                _ctx.ElektrikIslemleri.Remove(_ctx.ElektrikIslemleri.First(p => p.ElektrikIslemID == islemId));
            }
            if (islemAdi == "Motor")
            {   
                _ctx.MotorIslemleri.Remove(_ctx.MotorIslemleri.First(p => p.MotorIslemID == islemId));
            }
            if (islemAdi == "Lastik")
            {
                _ctx.LastikIslemleri.Remove(_ctx.LastikIslemleri.First(p => p.LastikIslemID == islemId));
            }
            #endregion

            _ctx.SaveChanges();

            VeriSorgula();
        }
    }
}
