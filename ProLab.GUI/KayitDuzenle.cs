using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProLab.GUI.Data.Context;

namespace ProLab.GUI
{
    public partial class KayitDuzenle : Form
    {
        private string _plaka;

        public KayitDuzenle()
        {
            InitializeComponent();
        }

        private void btn_kayitGetir_Click(object sender, EventArgs e)
        {
            TamirhaneDBContext ctx = new TamirhaneDBContext();

            _plaka = txb_aracPlaka.Text;
            var data = ctx.Araclar.First(u => u.Plaka == _plaka);

        }
    }
}
