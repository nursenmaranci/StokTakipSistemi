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
    public partial class TedarikciEkleme : Form
    {
        public TedarikciEkleme()
        {
            InitializeComponent();
        }

        private void TedarikciListele()
        {
            string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=****;Encrypt=true;TrustServerCertificate=true;";
            string query = "SELECT * FROM Tedarikciler"; 

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt); 
                dataGridView1.DataSource = dt; 
            }
        }

        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string TedarikciAdi = txtTedarikciAd.Text;
                string TedarikciAdres = txtTedarikciAdres.Text;
                string TedarikciNumara = txtTedarikciNumara.Text;

                string connectionString = "Server=NURSEN;Database=StokTakip;User Id=sa;Password=****;Encrypt=true;TrustServerCertificate=true;";
                string query = "INSERT INTO Tedarikciler (TedarikciAdi, TedarikciAdres, TedarikciNumara) VALUES (@TedarikciAdi, @TedarikciAdres, @TedarikciNumara)";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@TedarikciAdi", TedarikciAdi);
                        cmd.Parameters.AddWithValue("@TedarikciAdres", TedarikciAdres);
                        cmd.Parameters.AddWithValue("@TedarikciNumara", TedarikciNumara);



                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Müşteri başarıyla kaydedildi.");
                        TedarikciListele();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
