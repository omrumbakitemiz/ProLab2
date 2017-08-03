using System;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ProLab.GUI.Data.Context;

namespace ProLab.GUI
{
    public partial class AracArama : Form
    {
        private string _plaka;
        private TamirhaneDBContext ctx;

        public AracArama()
        {
            InitializeComponent();
        }

        private void btn_kayitAra_Click(object sender, EventArgs e)
        {
            _plaka = txb_araPlaka.Text;

            ctx = new TamirhaneDBContext();

            var list = ctx.Araclar.ToList();

            var kaporta = list.Where(p => p.Plaka == _plaka).SelectMany(x => x.KaportaIslemleri).ToList();
            var elektrik = list.Where(p => p.Plaka == _plaka).SelectMany(x => x.ElektrikIslemleri).ToList();
            var motor = list.Where(p => p.Plaka == _plaka).SelectMany(x => x.MotorIslemleri).ToList();
            var lastik = list.Where(p => p.Plaka == _plaka).SelectMany(x => x.LastikIslemleri).ToList();

            dataGridView1.DataSource = kaporta;
            dataGridView2.DataSource = elektrik;
            dataGridView3.DataSource = motor;
            dataGridView4.DataSource = lastik;
            

            var list1 = ctx.Araclar.ToList();

            var data = list1.Where(p => p.Plaka == txb_araPlaka.Text);
            var islemler = data.Select(x => x.KaportaIslemleri).ToList();
            var tarih = data.Select(x => x.Tarih).ToList();
            
            var data2 = ctx.Araclar.Where(t => t.Tarih == tarih[0]);
        }

        private void btn_secimSayfasınaGit_Click(object sender, EventArgs e)
        {
            Hide();

            SecimSayfasi secimSayfasi = new SecimSayfasi();
            secimSayfasi.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
