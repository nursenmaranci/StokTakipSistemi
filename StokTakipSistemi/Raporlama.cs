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
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }


        private void Raporlama_Load(object sender, EventArgs e)
        {
            UrunleriYukle();

            dtpBaslangic.Value = DateTime.Now.AddDays(-7);
            dtpBitis.Value = DateTime.Now;
        }

        private void UrunleriYukle()
        {
            string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=****;Encrypt=true;TrustServerCertificate=true;";
            string query = "SELECT UrunID, UrunAdi FROM Urunler";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbUrun.DataSource = dt;
                cmbUrun.DisplayMember = "UrunAdi";
                cmbUrun.ValueMember = "UrunID";
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=****;Encrypt=true;TrustServerCertificate=true;";
                string query = "SELECT HareketTuru, UrunID, TedarikciID, MusteriID, Tarih, Miktar, BirimFiyati, Aciklama FROM StokHareketleri WHERE 1=1";

                if (!string.IsNullOrEmpty(cmbHareketTuru.Text))
                    query += " AND HareketTuru = @HareketTuru";

                if (cmbUrun.SelectedValue != null && !string.IsNullOrEmpty(cmbUrun.SelectedValue.ToString()))
                    query += " AND UrunID = @UrunID";

                query += " AND Tarih BETWEEN @Baslangic AND @Bitis";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);

                    if (!string.IsNullOrEmpty(cmbHareketTuru.Text))
                        cmd.Parameters.AddWithValue("@HareketTuru", cmbHareketTuru.Text);

                    if (cmbUrun.SelectedValue != null && !string.IsNullOrEmpty(cmbUrun.SelectedValue.ToString()))
                        cmd.Parameters.AddWithValue("@UrunID", cmbUrun.SelectedValue);

                    cmd.Parameters.AddWithValue("@Baslangic", dtpBaslangic.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Bitis", dtpBitis.Value.ToString("yyyy-MM-dd"));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Belirtilen kriterlere uygun veri bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    }

