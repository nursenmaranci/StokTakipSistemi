namespace StokTakipSistemi
{
    partial class StokHareketleri
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmbHareket = new ComboBox();
            cmbUrun = new ComboBox();
            txtMiktar = new TextBox();
            txtBirimFiyat = new TextBox();
            cmbMusteri = new ComboBox();
            cmbTedarikci = new ComboBox();
            dtpTarih = new DateTimePicker();
            txtAciklama = new TextBox();
            dataGridView1 = new DataGridView();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(500, 46);
            label2.TabIndex = 2;
            label2.Text = "STOK HAREKETLERİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 3;
            label1.Text = "Hareket Türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 4;
            label3.Text = "Ürün Seçimi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 163);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 5;
            label4.Text = "Miktar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 206);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 6;
            label5.Text = "Birim Fiyat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 259);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 7;
            label6.Text = "Müşteri";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 305);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 8;
            label7.Text = "Tadarikçi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 351);
            label8.Name = "label8";
            label8.Size = new Size(53, 25);
            label8.TabIndex = 9;
            label8.Text = "Tarih ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 397);
            label9.Name = "label9";
            label9.Size = new Size(83, 25);
            label9.TabIndex = 10;
            label9.Text = "Açıklama";
            // 
            // cmbHareket
            // 
            cmbHareket.FormattingEnabled = true;
            cmbHareket.Items.AddRange(new object[] { "Girdi", "Çıktı", "İade" });
            cmbHareket.Location = new Point(149, 58);
            cmbHareket.Name = "cmbHareket";
            cmbHareket.Size = new Size(182, 33);
            cmbHareket.TabIndex = 11;
            cmbHareket.SelectedIndexChanged += cmbHareketTuru_SelectedIndexChanged;
            // 
            // cmbUrun
            // 
            cmbUrun.FormattingEnabled = true;
            cmbUrun.Location = new Point(149, 107);
            cmbUrun.Name = "cmbUrun";
            cmbUrun.Size = new Size(182, 33);
            cmbUrun.TabIndex = 12;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(149, 157);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(182, 31);
            txtMiktar.TabIndex = 13;
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(149, 200);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(182, 31);
            txtBirimFiyat.TabIndex = 14;
            // 
            // cmbMusteri
            // 
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(149, 251);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(182, 33);
            cmbMusteri.TabIndex = 15;
            // 
            // cmbTedarikci
            // 
            cmbTedarikci.FormattingEnabled = true;
            cmbTedarikci.Location = new Point(149, 297);
            cmbTedarikci.Name = "cmbTedarikci";
            cmbTedarikci.Size = new Size(182, 33);
            cmbTedarikci.TabIndex = 16;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(149, 351);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(182, 31);
            dtpTarih.TabIndex = 17;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(149, 394);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(182, 31);
            txtAciklama.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(401, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(989, 425);
            dataGridView1.TabIndex = 19;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(149, 449);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(182, 34);
            btnKaydet.TabIndex = 20;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // StokHareketleri
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 577);
            Controls.Add(btnKaydet);
            Controls.Add(dataGridView1);
            Controls.Add(txtAciklama);
            Controls.Add(dtpTarih);
            Controls.Add(cmbTedarikci);
            Controls.Add(cmbMusteri);
            Controls.Add(txtBirimFiyat);
            Controls.Add(txtMiktar);
            Controls.Add(cmbUrun);
            Controls.Add(cmbHareket);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "StokHareketleri";
            Text = "StokHareketleri";
            Load += StokHareketleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cmbHareket;
        private ComboBox cmbUrun;
        private TextBox txtMiktar;
        private TextBox txtBirimFiyat;
        private ComboBox cmbMusteri;
        private ComboBox cmbTedarikci;
        private DateTimePicker dtpTarih;
        private TextBox txtAciklama;
        private DataGridView dataGridView1;
        private Button btnKaydet;
    }
}