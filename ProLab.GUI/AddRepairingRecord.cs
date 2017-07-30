using System;
using System.Data;
using System.Windows.Forms;
using ProLab.GUI.Models;

namespace ProLab.GUI
{
    public partial class AddRepairingRecord : Form
    {
        public string Plaka { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }

        Vehicle vehicle = new Vehicle();

        private Body _body;
        private Electric _electric;
        private Engine _engine;
        private Tire _tire;

        public AddRepairingRecord(string plaka, string marka, string model)
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
            _body = new Body
            {
                RepairMan = txb_kprtUsta.Text,
                Status = Status.RepairingHasntStartedYet,
                ChangingPart = txb_kprtDegisen.Text,
                ChangingPrice = txb_kprtDegisenFiyat.Text,
                PaintingPart = txb_kprtBoyanan.Text,
                PaintingPrice = txb_kprtBoyananFiyat.Text,
                LaborCost = txb_kprtIscilik.Text
            };
        }
        
        private void btn_elkEkle_Click(object sender, EventArgs e)
        {
            _electric = new Electric
            {
                RepairMan = txb_elkUsta.Text,
                Status = Status.RepairingHasntStartedYet,
                ChangingPart = txb_elkDegisen.Text,
                ChangingPrice = txb_elkDegisenFiyat.Text,
                LaborCost = txb_elkIscilik.Text
            };
        }

        private void btn_mtrEkle_Click(object sender, EventArgs e)
        {
            _engine = new Engine
            {
                RepairMan = txb_mtrUsta.Text,
                Status = Status.RepairingHasntStartedYet,
                ChangingPart = txb_mtrDegisen.Text,
                ChangingPrice = txb_mtrDegisenFiyat.Text,
                RepairingPart = txb_mtrTamirEdilen.Text,
                RepairingPrice = txb_mtrTamirEdilenFiyat.Text,
                LaborCost = txb_mtrIscilik.Text
            };
        }

        private void btn_lastikEkle_Click(object sender, EventArgs e)
        {
            _tire = new Tire
            {
                RepairMan = txb_lastikUsta.Text,
                Status = Status.RepairingHasntStartedYet,
                ChangingTire = txb_lastikDegisen.Text,
                Piece = txb_lastikDegisenAdet.Text,
                Cost = txb_lastikIscilik.Text,
                LaborCost = txb_lastikIscilik.Text
            };
        }

        private void btn_kaydiTamamla_Click(object sender, EventArgs e)
        {
            vehicle.AddRepairing(_body);
            vehicle.AddRepairing(_electric);
            vehicle.AddRepairing(_engine);
            vehicle.AddRepairing(_tire);

            HomePage homePage = new HomePage("kullanici1");

            //Hide();
            //homePage.Show();
        }
    }
}
