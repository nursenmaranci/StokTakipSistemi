namespace StokTakipSistemi
{
    partial class UrunEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUrunKodu = new Label();
            lblUrunAdi = new Label();
            lblBirim = new Label();
            lblKDV = new Label();
            lblKritik = new Label();
            groupUrunEkle = new GroupBox();
            txtAciklama = new TextBox();
            lblAciklama = new Label();
            btnUrunKaydet = new Button();
            dataGridView1 = new DataGridView();
            cmbTedarikci = new ComboBox();
            lblTedarikci = new Label();
            txtKritikSeviye = new TextBox();
            txtKDVOrani = new TextBox();
            txtBirimFiyati = new TextBox();
            txtUrunAdi = new TextBox();
            txtUrunKodu = new TextBox();
            groupUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblUrunKodu
            // 
            lblUrunKodu.AutoSize = true;
            lblUrunKodu.Location = new Point(21, 61);
            lblUrunKodu.Name = "lblUrunKodu";
            lblUrunKodu.Size = new Size(97, 25);
            lblUrunKodu.TabIndex = 0;
            lblUrunKodu.Text = "Ürün Kodu";
            // 
            // lblUrunAdi
            // 
            lblUrunAdi.AutoSize = true;
            lblUrunAdi.Location = new Point(21, 109);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.Size = new Size(82, 25);
            lblUrunAdi.TabIndex = 1;
            lblUrunAdi.Text = "Ürün Adı";
            // 
            // lblBirim
            // 
            lblBirim.AutoSize = true;
            lblBirim.Location = new Point(21, 189);
            lblBirim.Name = "lblBirim";
            lblBirim.Size = new Size(98, 25);
            lblBirim.TabIndex = 2;
            lblBirim.Text = "Birim Fiyatı";
            // 
            // lblKDV
            // 
            lblKDV.AutoSize = true;
            lblKDV.Location = new Point(21, 237);
            lblKDV.Name = "lblKDV";
            lblKDV.Size = new Size(94, 25);
            lblKDV.TabIndex = 3;
            lblKDV.Text = "KDV Oranı";
            // 
            // lblKritik
            // 
            lblKritik.AutoSize = true;
            lblKritik.Location = new Point(21, 276);
            lblKritik.Name = "lblKritik";
            lblKritik.Size = new Size(106, 25);
            lblKritik.TabIndex = 4;
            lblKritik.Text = "Kritik Seviye";
            // 
            // groupUrunEkle
            // 
            groupUrunEkle.BackColor = SystemColors.ActiveCaption;
            groupUrunEkle.Controls.Add(txtAciklama);
            groupUrunEkle.Controls.Add(lblAciklama);
            groupUrunEkle.Controls.Add(btnUrunKaydet);
            groupUrunEkle.Controls.Add(dataGridView1);
            groupUrunEkle.Controls.Add(cmbTedarikci);
            groupUrunEkle.Controls.Add(lblTedarikci);
            groupUrunEkle.Controls.Add(txtKritikSeviye);
            groupUrunEkle.Controls.Add(txtKDVOrani);
            groupUrunEkle.Controls.Add(txtBirimFiyati);
            groupUrunEkle.Controls.Add(txtUrunAdi);
            groupUrunEkle.Controls.Add(txtUrunKodu);
            groupUrunEkle.Controls.Add(lblUrunAdi);
            groupUrunEkle.Controls.Add(lblKritik);
            groupUrunEkle.Controls.Add(lblUrunKodu);
            groupUrunEkle.Controls.Add(lblKDV);
            groupUrunEkle.Controls.Add(lblBirim);
            groupUrunEkle.Location = new Point(-2, 12);
            groupUrunEkle.Name = "groupUrunEkle";
            groupUrunEkle.Size = new Size(1286, 478);
            groupUrunEkle.TabIndex = 5;
            groupUrunEkle.TabStop = false;
            groupUrunEkle.Text = "Ürün Ekleme";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(124, 146);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(150, 31);
            txtAciklama.TabIndex = 15;
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Location = new Point(21, 149);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(83, 25);
            lblAciklama.TabIndex = 14;
            lblAciklama.Text = "Açıklama";
            // 
            // btnUrunKaydet
            // 
            btnUrunKaydet.Location = new Point(312, 321);
            btnUrunKaydet.Name = "btnUrunKaydet";
            btnUrunKaydet.Size = new Size(112, 34);
            btnUrunKaydet.TabIndex = 13;
            btnUrunKaydet.Text = "Kaydet";
            btnUrunKaydet.UseVisualStyleBackColor = true;
            btnUrunKaydet.Click += btnUrunKaydet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(560, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(647, 288);
            dataGridView1.TabIndex = 12;
            // 
            // cmbTedarikci
            // 
            cmbTedarikci.FormattingEnabled = true;
            cmbTedarikci.Location = new Point(124, 318);
            cmbTedarikci.Name = "cmbTedarikci";
            cmbTedarikci.Size = new Size(151, 33);
            cmbTedarikci.TabIndex = 11;
            // 
            // lblTedarikci
            // 
            lblTedarikci.AutoSize = true;
            lblTedarikci.Location = new Point(21, 321);
            lblTedarikci.Name = "lblTedarikci";
            lblTedarikci.Size = new Size(79, 25);
            lblTedarikci.TabIndex = 10;
            lblTedarikci.Text = "Tedarikçi";
            // 
            // txtKritikSeviye
            // 
            txtKritikSeviye.Location = new Point(124, 275);
            txtKritikSeviye.Name = "txtKritikSeviye";
            txtKritikSeviye.Size = new Size(150, 31);
            txtKritikSeviye.TabIndex = 9;
            // 
            // txtKDVOrani
            // 
            txtKDVOrani.Location = new Point(124, 232);
            txtKDVOrani.Name = "txtKDVOrani";
            txtKDVOrani.Size = new Size(150, 31);
            txtKDVOrani.TabIndex = 8;
            // 
            // txtBirimFiyati
            // 
            txtBirimFiyati.Location = new Point(125, 187);
            txtBirimFiyati.Name = "txtBirimFiyati";
            txtBirimFiyati.Size = new Size(150, 31);
            txtBirimFiyati.TabIndex = 7;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(124, 106);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(150, 31);
            txtUrunAdi.TabIndex = 6;
            // 
            // txtUrunKodu
            // 
            txtUrunKodu.Location = new Point(124, 58);
            txtUrunKodu.Name = "txtUrunKodu";
            txtUrunKodu.Size = new Size(150, 31);
            txtUrunKodu.TabIndex = 5;
            // 
            // UrunEkleme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 491);
            Controls.Add(groupUrunEkle);
            Name = "UrunEkleme";
            Text = "Ürün Ekleme";
            Load += UrunEkleme_Load;
            groupUrunEkle.ResumeLayout(false);
            groupUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUrunKodu;
        private Label lblUrunAdi;
        private Label lblBirim;
        private Label lblKDV;
        private Label lblKritik;
        private GroupBox groupUrunEkle;
        private ComboBox cmbTedarikci;
        private Label lblTedarikci;
        private TextBox txtKritikSeviye;
        private TextBox txtKDVOrani;
        private TextBox txtBirimFiyati;
        private TextBox txtUrunAdi;
        private TextBox txtUrunKodu;
        private DataGridView dataGridView1;
        private Button btnUrunKaydet;
        private TextBox txtAciklama;
        private Label lblAciklama;
    }
}