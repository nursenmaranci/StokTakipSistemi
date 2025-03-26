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
    public partial class StokHareketleri : Form
    {
        public StokHareketleri()
        {
            InitializeComponent();
        }

        private void TedarikcileriDoldur()
        {
            string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=****;Encrypt=true;TrustServerCertificate=true;";
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

        private void UrunDoldur()
        {
            string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=****;Encrypt=true;TrustServerCertificate=true;";
            string query = "SELECT UrunID, UrunAdi FROM Urunler"; 

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                cmbUrun.DataSource = dt; 
                cmbUrun.DisplayMember = "UrunAdi"; 
                cmbUrun.ValueMember = "UrunID"; 
            }
        }
        private void MusterileriDoldur()
        {
            string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=****;Encrypt=true;TrustServerCertificate=true;";
            string query = "SELECT MusteriID, MusteriAdi FROM Musteriler"; 

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbMusteri.DataSource = dt; 
                cmbMusteri.DisplayMember = "MusteriAdi"; 
                cmbMusteri.ValueMember = "MusteriID"; 
            }
        }


        private void StokHareketleriListele()
        {
            string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=****;Encrypt=true;TrustServerCertificate=true;";
            string query = "SELECT * FROM StokHareketleri"; 

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt); 
                dataGridView1.DataSource = dt; 
            }
        }

        private void cmbHareketTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHareket.SelectedItem == null)
                return;

            string hareketTuru = cmbHareket.SelectedItem.ToString();

            if (hareketTuru == "Girdi")
            {
                txtBirimFiyat.Enabled = true;
                cmbTedarikci.Enabled = true;
                cmbMusteri.Enabled = false;
            }
            else if (hareketTuru == "Çıktı")
            {
                txtBirimFiyat.Enabled = false;
                cmbTedarikci.Enabled = false;
                cmbMusteri.Enabled = true;
            }
            else if (hareketTuru == "İade")
            {
                txtBirimFiyat.Enabled = false;
                cmbTedarikci.Enabled = true;
                cmbMusteri.Enabled = true;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string hareketTuru = cmbHareket.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(hareketTuru))
            {
                MessageBox.Show("Hareket türünü seçmelisiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string urunID = cmbUrun.Enabled ? cmbUrun.SelectedValue?.ToString() : null;
            if (string.IsNullOrEmpty(urunID))
            {
                MessageBox.Show("Ürün seçmelisiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? tedarikciID = cmbTedarikci.Enabled ? (int?)cmbTedarikci.SelectedValue : null;
            int? musteriID = cmbMusteri.Enabled ? (int?)cmbMusteri.SelectedValue : null;

            string tarih = dtpTarih.Value.ToString("yyyy-MM-dd");
            string miktar = txtMiktar.Text;
            if (string.IsNullOrEmpty(miktar))
            {
                MessageBox.Show("Miktar alanını doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string birimFiyati = txtBirimFiyat.Enabled ? txtBirimFiyat.Text : null;
            string aciklama = txtAciklama.Text;

            string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=****;Encrypt=true;TrustServerCertificate=true;";
            string query = "INSERT INTO StokHareketleri (HareketTuru, UrunID, TedarikciID, MusteriID, Tarih, Miktar, BirimFiyati, Aciklama) " +
                           "VALUES (@HareketTuru, @UrunID, @TedarikciID, @MusteriID, @Tarih, @Miktar, @BirimFiyati, @Aciklama)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@HareketTuru", hareketTuru);
                    cmd.Parameters.AddWithValue("@UrunID", (object)urunID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TedarikciID", (object)tedarikciID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MusteriID", (object)musteriID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Tarih", tarih);
                    cmd.Parameters.AddWithValue("@Miktar", miktar);
                    cmd.Parameters.AddWithValue("@BirimFiyati", (object)birimFiyati ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Aciklama", aciklama);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stok hareketi başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StokHareketleriListele();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void StokHareketleri_Load(object sender, EventArgs e)
        {
            StokHareketleriListele(); 
            TedarikcileriDoldur(); 
            MusterileriDoldur();
            UrunDoldur();
        }
    }
}


 
