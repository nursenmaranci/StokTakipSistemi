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
    public partial class MusteriEkleme : Form
    {
        public MusteriEkleme()
        {
            InitializeComponent();
        }

        private void MusteriListele()
        {
            string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=1475;Encrypt=true;TrustServerCertificate=true;";
            string query = "SELECT * FROM Musteriler"; 

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt); 
                dataGridView1.DataSource = dt; 
            }
        }


        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string MusteriAdi = txtMusteriAd.Text;
                string MusteriAdresi = txtMusteriAdres.Text;
                string MusteriNumara = txtMusteriNumara.Text;
                string MusteriFirma = txtMusteriFirma.Text;
                string MusteriVergi = txtMusteriVergi.Text;


                string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=1475;Encrypt=true;TrustServerCertificate=true;";
                string query = "INSERT INTO Musteriler (MusteriAdi, MusteriAdresi, MusteriNumara, FirmaAdi, VergiNo) VALUES (@MusteriAdi, @MusteriAdresi, @MusteriNumara, @FirmaAdi, @VergiNo)";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MusteriAdi", MusteriAdi);
                        cmd.Parameters.AddWithValue("@MusteriAdresi", MusteriAdresi);
                        cmd.Parameters.AddWithValue("@MusteriNumara", MusteriNumara);
                        cmd.Parameters.AddWithValue("@FİrmaAdi", MusteriFirma);
                        cmd.Parameters.AddWithValue("@VergiNo", MusteriVergi);


                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Müşteri başarıyla kaydedildi.");
                        MusteriListele();
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
