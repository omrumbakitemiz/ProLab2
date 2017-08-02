using System;
using System.Data;
using System.Windows.Forms;

namespace ProLab.GUI
{
    public partial class DetaySayfası : Form
    {
        //private void GetGenelDurum()
        //{
        //    Arac vehicle1 = new Arac();

        //    DataTable dataTableKaporta = new DataTable("Kaporta");
        //    DataTable dataTableElektrik = new DataTable("Elektrik");
        //    DataTable dataTableMotor = new DataTable("Motor");
        //    DataTable dataTableLastik = new DataTable("Lastik");

        //    dataTableKaporta.Columns.Add(new DataColumn("Değişen Parça"));
        //    dataTableKaporta.Columns.Add(new DataColumn("Değişen Parça Fiyatı"));
        //    dataTableKaporta.Columns.Add(new DataColumn("Boyanan Parça"));
        //    dataTableKaporta.Columns.Add(new DataColumn("Boyanan Parça Fiyatı"));
        //    dataTableKaporta.Columns.Add(new DataColumn("İşçilik"));
        //    dataTableKaporta.Columns.Add(new DataColumn("Usta"));

        //    dataTableElektrik.Columns.Add("Değişen Parça");
        //    dataTableElektrik.Columns.Add("Değişen Parça Fiyatı");
        //    dataTableElektrik.Columns.Add("İşçilik");
        //    dataTableElektrik.Columns.Add("Usta");

        //    dataTableMotor.Columns.Add("Değişen Parça");
        //    dataTableMotor.Columns.Add("Değişen Parça Fiyatı");
        //    dataTableMotor.Columns.Add("Tamir Edilen Parça");
        //    dataTableMotor.Columns.Add("Tamir Edilen Parça Fiyatı");
        //    dataTableMotor.Columns.Add("İşçilik");
        //    dataTableMotor.Columns.Add("Usta");

        //    dataTableLastik.Columns.Add("Değişen Lastik");
        //    dataTableLastik.Columns.Add("Değişen Lastik Sayısı");
        //    dataTableLastik.Columns.Add("Değişen Lastik Fiyatı");
        //    dataTableLastik.Columns.Add("İşçilik");
        //    dataTableLastik.Columns.Add("Usta");

        //    DataRow rowKaporta = dataTableKaporta.NewRow();
        //    DataRow rowElektrik = dataTableElektrik.NewRow();
        //    DataRow rowMotor = dataTableMotor.NewRow();
        //    DataRow rowLastik = dataTableLastik.NewRow();

        //    rowKaporta[0] = vehicle1.KaportaTamiri.DegisenParca;
        //    rowKaporta[1] = vehicle1.KaportaTamiri.DegisenParcaFiyat;
        //    rowKaporta[2] = vehicle1.KaportaTamiri.BoyananParca;
        //    rowKaporta[3] = vehicle1.KaportaTamiri.BoyananParcaFiyat;
        //    rowKaporta[4] = vehicle1.KaportaTamiri.Iscilik;
        //    rowKaporta[5] = vehicle1.KaportaTamiri.Usta;

        //    rowElektrik[0] = vehicle1.ElektrikTamiri.DegisenParca;
        //    rowElektrik[1] = vehicle1.ElektrikTamiri.DegisenParcaFiyat;
        //    rowElektrik[2] = vehicle1.ElektrikTamiri.Iscilik;
        //    rowElektrik[3] = vehicle1.ElektrikTamiri.Usta;

        //    rowMotor[0] = vehicle1.MotorTamiri.DegisenParca;
        //    rowMotor[1] = vehicle1.MotorTamiri.DegisenParcaFiyat;
        //    rowMotor[2] = vehicle1.MotorTamiri.TamirEdilenParca;
        //    rowMotor[3] = vehicle1.MotorTamiri.TamirEdilenParcaFiyat;
        //    rowMotor[4] = vehicle1.MotorTamiri.Iscilik;
        //    rowMotor[5] = vehicle1.MotorTamiri.Usta;

        //    rowLastik[0] = vehicle1.LastikTamiri.DegisenLastik;
        //    rowLastik[1] = vehicle1.LastikTamiri.Adet;
        //    rowLastik[2] = vehicle1.LastikTamiri.Ucret;
        //    rowLastik[3] = vehicle1.LastikTamiri.Iscilik;
        //    rowLastik[4] = vehicle1.LastikTamiri.Usta;

        //    dataTableKaporta.Rows.Add(rowKaporta);
        //    dataTableElektrik.Rows.Add(rowElektrik);
        //    dataTableMotor.Rows.Add(rowMotor);
        //    dataTableLastik.Rows.Add(rowLastik);

        //    DetaySayfası detailsPage = new DetaySayfası();

        //    dataGridView1.DataSource = dataTableKaporta;
        //    dataGridView2.DataSource = dataTableElektrik;
        //    dataGridView3.DataSource = dataTableMotor;
        //    dataGridView4.DataSource = dataTableLastik;
        //}

        public DetaySayfası()
        {
            InitializeComponent();
        }

        private void btn_kayitAra_Click(object sender, EventArgs e)
        {
            //GetGenelDurum();
        }

        private void DetailsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
