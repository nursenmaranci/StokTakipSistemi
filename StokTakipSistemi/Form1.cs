namespace StokTakipSistemi
{
    public partial class StokTakip : Form
    {
        public StokTakip()
        {
            InitializeComponent();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            UrunEkleme f2 = new UrunEkleme();
            f2.ShowDialog(); 
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            MusteriEkleme f3 = new MusteriEkleme();
            f3.ShowDialog();
        }

        private void btnTedarikci_Click(object sender, EventArgs e)
        {
            TedarikciEkleme f4 = new TedarikciEkleme();
            f4.ShowDialog();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            StokHareketleri f5 = new StokHareketleri();
            f5.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Raporlama f6 = new Raporlama();
            f6.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
