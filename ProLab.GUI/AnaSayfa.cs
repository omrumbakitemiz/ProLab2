using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProLab.GUI
{
    public partial class AnaSayfa : Form
    {
        public string KullaniciAdi { get; set; }

        public AnaSayfa(string kullaniciAdi)
        {
            InitializeComponent();
            this.KullaniciAdi = kullaniciAdi;
        }

        static string conString = "Server=tcp:prolabtamirhane.database.windows.net,1433;" +
            "Initial Catalog=RepairShop;" +
            "Persist Security Info=False;" +
            "User ID=omrumbakitemiz;" +
            "Password=MRM_bk2608;" +
            "MultipleActiveResultSets=False;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "Connection Timeout=30;";

        SqlConnection baglanti = new SqlConnection(conString);

        private void Kayit_Getir()
        {
            baglanti.Open();

            string kayit1 = "SELECT * FROM VehicleInfo";
            string kayit2 = "SELECT * FROM VehicleRepairOperations";

            SqlCommand komut1 = new SqlCommand(kayit1, baglanti);
            SqlCommand komut2 = new SqlCommand(kayit2, baglanti);

            SqlDataAdapter adapter1 = new SqlDataAdapter(komut1);
            SqlDataAdapter adapter2 = new SqlDataAdapter(komut2);

            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);

            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);

            dataGridView1.DataSource = dt1;
            dataGridView2.DataSource = dt2;

            baglanti.Close();
        }

        private void Kayit_Ekle()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into VehicleInfo (Plate, Manufacturer, Model) VALUES (@Plate, @Manufacturer, @Model)";
                    command.Parameters.AddWithValue("@Plate", "41AB2222");
                    command.Parameters.AddWithValue("@Manufacturer", "BMW");
                    command.Parameters.AddWithValue("@Model", "2000");

                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show($"Error : {e.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            //Kayit_Ekle();
            //Kayit_Getir();
        }

        private void btn_kayitEkleEkrani_Click(object sender, EventArgs e)
        {
            AracEkle addRecord = new AracEkle(KullaniciAdi);

            Hide();
            addRecord.Show();
        }

        private void btn_kayitGoruntule_Click(object sender, EventArgs e)
        {
            DetaySayfası detailsPage = new DetaySayfası();

            Hide();
            detailsPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kayit_Getir();
        }
    }
}
