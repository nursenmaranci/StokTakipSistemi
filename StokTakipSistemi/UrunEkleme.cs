using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class UrunEkleme : Form
    {
        public UrunEkleme()
        {
            InitializeComponent();
        }
        private void UrunEkleme_Load(object sender, EventArgs e)
        {
            UrunleriListele(); 
            TedarikcileriDoldur(); 
        }
        private void TedarikcileriDoldur()
        {
            string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=1475;Encrypt=true;TrustServerCertificate=true;";
            string query = "SELECT TedarikciID, TedarikciAdi FROM Tedarikciler";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTedarikci.DataSource = dt; 
                cmbTedarikci.DisplayMember = "TedarikciAdi"; 
                cmbTedarikci.ValueMember = "TedarikciID"; 
            }
        }
        private void UrunleriListele()
        {
            string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=1475;Encrypt=true;TrustServerCertificate=true;";
            string query = "SELECT * FROM Urunler"; 

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt); 
                dataGridView1.DataSource = dt; 
            }
        }
        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string urunKodu = txtUrunKodu.Text;
                string urunAdi = txtUrunAdi.Text;
                string aciklama = txtAciklama.Text;
                decimal birimFiyat;
                decimal.TryParse(txtBirimFiyati.Text, out birimFiyat);
                decimal kdvOrani;
                decimal.TryParse(txtKDVOrani.Text, out kdvOrani);
                int tedarikciID;
                int.TryParse(cmbTedarikci.SelectedValue?.ToString(), out tedarikciID);
                int kritikSeviye;
                int.TryParse(txtKritikSeviye.Text, out kritikSeviye);

                if (string.IsNullOrWhiteSpace(urunKodu) || string.IsNullOrWhiteSpace(urunAdi))
                {
                    MessageBox.Show("Ürün Kodu ve Ürün Adı alanları boş bırakılamaz.");
                    return;
                }

                string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=1475;Encrypt=true;TrustServerCertificate=true;";
                string query = "INSERT INTO Urunler (UrunKodu, UrunAdi, Aciklama, BirimFiyati, KDVOrani, TedarikciID, KritikSeviye) VALUES (@UrunKodu, @UrunAdi, @Aciklama," +
                    " @BirimFiyati, @KDVOrani, @TedarikciID, @KritikSeviye)";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UrunKodu", urunKodu);
                        cmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                        cmd.Parameters.AddWithValue("@Aciklama", aciklama);
                        cmd.Parameters.AddWithValue("@BirimFiyati", birimFiyat);
                        cmd.Parameters.AddWithValue("@KDVOrani", kdvOrani);
                        cmd.Parameters.AddWithValue("@TedarikciID", tedarikciID);
                        cmd.Parameters.AddWithValue("@KritikSeviye", kritikSeviye);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Ürün başarıyla kaydedildi.");
                        UrunleriListele(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}


