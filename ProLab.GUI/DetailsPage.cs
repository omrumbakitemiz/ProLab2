using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProLab.GUI.Models;

namespace ProLab.GUI
{
    public partial class DetailsPage : Form
    {
        private void GetGenelDurum()
        {
            Vehicle vehicle1 = new Vehicle();

            DataTable dataTableKaporta = new DataTable("Kaporta");
            DataTable dataTableElektrik = new DataTable("Elektrik");
            DataTable dataTableMotor = new DataTable("Motor");
            DataTable dataTableLastik = new DataTable("Lastik");

            dataTableKaporta.Columns.Add(new DataColumn("Değişen Parça"));
            dataTableKaporta.Columns.Add(new DataColumn("Değişen Parça Fiyatı"));
            dataTableKaporta.Columns.Add(new DataColumn("Boyanan Parça"));
            dataTableKaporta.Columns.Add(new DataColumn("Boyanan Parça Fiyatı"));
            dataTableKaporta.Columns.Add(new DataColumn("İşçilik"));
            dataTableKaporta.Columns.Add(new DataColumn("Usta"));

            dataTableElektrik.Columns.Add("Değişen Parça");
            dataTableElektrik.Columns.Add("Değişen Parça Fiyatı");
            dataTableElektrik.Columns.Add("İşçilik");
            dataTableElektrik.Columns.Add("Usta");

            dataTableMotor.Columns.Add("Değişen Parça");
            dataTableMotor.Columns.Add("Değişen Parça Fiyatı");
            dataTableMotor.Columns.Add("Tamir Edilen Parça");
            dataTableMotor.Columns.Add("Tamir Edilen Parça Fiyatı");
            dataTableMotor.Columns.Add("İşçilik");
            dataTableMotor.Columns.Add("Usta");

            dataTableLastik.Columns.Add("Değişen Lastik");
            dataTableLastik.Columns.Add("Değişen Lastik Sayısı");
            dataTableLastik.Columns.Add("Değişen Lastik Fiyatı");
            dataTableLastik.Columns.Add("İşçilik");
            dataTableLastik.Columns.Add("Usta");

            DataRow rowKaporta = dataTableKaporta.NewRow();
            DataRow rowElektrik = dataTableElektrik.NewRow();
            DataRow rowMotor = dataTableMotor.NewRow();
            DataRow rowLastik = dataTableLastik.NewRow();

            rowKaporta[0] = vehicle1.BodyJob.ChangingPart;
            rowKaporta[1] = vehicle1.BodyJob.ChangingPrice;
            rowKaporta[2] = vehicle1.BodyJob.PaintingPart;
            rowKaporta[3] = vehicle1.BodyJob.PaintingPrice;
            rowKaporta[4] = vehicle1.BodyJob.LaborCost;
            rowKaporta[5] = vehicle1.BodyJob.RepairMan;

            rowElektrik[0] = vehicle1.ElectricJob.ChangingPart;
            rowElektrik[1] = vehicle1.ElectricJob.ChangingPrice;
            rowElektrik[2] = vehicle1.ElectricJob.LaborCost;
            rowElektrik[3] = vehicle1.ElectricJob.RepairMan;

            rowMotor[0] = vehicle1.EngineJob.ChangingPart;
            rowMotor[1] = vehicle1.EngineJob.ChangingPrice;
            rowMotor[2] = vehicle1.EngineJob.RepairingPart;
            rowMotor[3] = vehicle1.EngineJob.RepairingPrice;
            rowMotor[4] = vehicle1.EngineJob.LaborCost;
            rowMotor[5] = vehicle1.EngineJob.RepairMan;

            rowLastik[0] = vehicle1.TireJob.ChangingTire;
            rowLastik[1] = vehicle1.TireJob.Piece;
            rowLastik[2] = vehicle1.TireJob.Cost;
            rowLastik[3] = vehicle1.TireJob.LaborCost;
            rowLastik[4] = vehicle1.TireJob.RepairMan;

            dataTableKaporta.Rows.Add(rowKaporta);
            dataTableElektrik.Rows.Add(rowElektrik);
            dataTableMotor.Rows.Add(rowMotor);
            dataTableLastik.Rows.Add(rowLastik);

            DetailsPage detailsPage = new DetailsPage();

            dataGridView1.DataSource = dataTableKaporta;
            dataGridView2.DataSource = dataTableElektrik;
            dataGridView3.DataSource = dataTableMotor;
            dataGridView4.DataSource = dataTableLastik;
        }

        public DetailsPage()
        {
            InitializeComponent();
        }

        private void btn_kayitAra_Click(object sender, EventArgs e)
        {
            GetGenelDurum();
        }

        private void DetailsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
