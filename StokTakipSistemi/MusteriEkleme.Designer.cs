namespace StokTakipSistemi
{
    partial class MusteriEkleme
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
            label1 = new Label();
            lblMusteriAdi = new Label();
            lblMusteriAdresi = new Label();
            lblMusteriNumarası = new Label();
            lblMusteriFirma = new Label();
            lblMusteriVergi = new Label();
            txtMusteriAd = new TextBox();
            txtMusteriAdres = new TextBox();
            txtMusteriNumara = new TextBox();
            txtMusteriFirma = new TextBox();
            txtMusteriVergi = new TextBox();
            btnMusteriEkle = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(374, 46);
            label1.TabIndex = 0;
            label1.Text = "MÜŞTERİ EKLE";
            // 
            // lblMusteriAdi
            // 
            lblMusteriAdi.AutoSize = true;
            lblMusteriAdi.Location = new Point(15, 93);
            lblMusteriAdi.Name = "lblMusteriAdi";
            lblMusteriAdi.Size = new Size(35, 25);
            lblMusteriAdi.TabIndex = 1;
            lblMusteriAdi.Text = "Ad";
            // 
            // lblMusteriAdresi
            // 
            lblMusteriAdresi.AutoSize = true;
            lblMusteriAdresi.Location = new Point(15, 143);
            lblMusteriAdresi.Name = "lblMusteriAdresi";
            lblMusteriAdresi.Size = new Size(58, 25);
            lblMusteriAdresi.TabIndex = 2;
            lblMusteriAdresi.Text = "Adres";
            // 
            // lblMusteriNumarası
            // 
            lblMusteriNumarası.AutoSize = true;
            lblMusteriNumarası.Location = new Point(15, 186);
            lblMusteriNumarası.Name = "lblMusteriNumarası";
            lblMusteriNumarası.Size = new Size(75, 25);
            lblMusteriNumarası.TabIndex = 3;
            lblMusteriNumarası.Text = "Numara";
            // 
            // lblMusteriFirma
            // 
            lblMusteriFirma.AutoSize = true;
            lblMusteriFirma.Location = new Point(15, 232);
            lblMusteriFirma.Name = "lblMusteriFirma";
            lblMusteriFirma.Size = new Size(56, 25);
            lblMusteriFirma.TabIndex = 4;
            lblMusteriFirma.Text = "Firma";
            // 
            // lblMusteriVergi
            // 
            lblMusteriVergi.AutoSize = true;
            lblMusteriVergi.Location = new Point(15, 274);
            lblMusteriVergi.Name = "lblMusteriVergi";
            lblMusteriVergi.Size = new Size(132, 25);
            lblMusteriVergi.TabIndex = 5;
            lblMusteriVergi.Text = "Vergi Numarası";
            // 
            // txtMusteriAd
            // 
            txtMusteriAd.Location = new Point(98, 87);
            txtMusteriAd.Name = "txtMusteriAd";
            txtMusteriAd.Size = new Size(206, 31);
            txtMusteriAd.TabIndex = 6;
            // 
            // txtMusteriAdres
            // 
            txtMusteriAdres.Location = new Point(98, 137);
            txtMusteriAdres.Name = "txtMusteriAdres";
            txtMusteriAdres.Size = new Size(206, 31);
            txtMusteriAdres.TabIndex = 7;
            // 
            // txtMusteriNumara
            // 
            txtMusteriNumara.Location = new Point(98, 180);
            txtMusteriNumara.Name = "txtMusteriNumara";
            txtMusteriNumara.Size = new Size(204, 31);
            txtMusteriNumara.TabIndex = 8;
            // 
            // txtMusteriFirma
            // 
            txtMusteriFirma.Location = new Point(98, 226);
            txtMusteriFirma.Name = "txtMusteriFirma";
            txtMusteriFirma.Size = new Size(204, 31);
            txtMusteriFirma.TabIndex = 9;
            // 
            // txtMusteriVergi
            // 
            txtMusteriVergi.Location = new Point(152, 268);
            txtMusteriVergi.Name = "txtMusteriVergi";
            txtMusteriVergi.Size = new Size(150, 31);
            txtMusteriVergi.TabIndex = 10;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Location = new Point(329, 268);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(112, 34);
            btnMusteriEkle.TabIndex = 11;
            btnMusteriEkle.Text = "Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = true;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(493, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(770, 233);
            dataGridView1.TabIndex = 12;
            // 
            // MusteriEkleme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 347);
            Controls.Add(dataGridView1);
            Controls.Add(btnMusteriEkle);
            Controls.Add(txtMusteriVergi);
            Controls.Add(txtMusteriFirma);
            Controls.Add(txtMusteriNumara);
            Controls.Add(txtMusteriAdres);
            Controls.Add(txtMusteriAd);
            Controls.Add(lblMusteriVergi);
            Controls.Add(lblMusteriFirma);
            Controls.Add(lblMusteriNumarası);
            Controls.Add(lblMusteriAdresi);
            Controls.Add(lblMusteriAdi);
            Controls.Add(label1);
            Name = "MusteriEkleme";
            Text = "Müşteri Ekleme";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMusteriAdi;
        private Label lblMusteriAdresi;
        private Label lblMusteriNumarası;
        private Label lblMusteriFirma;
        private Label lblMusteriVergi;
        private TextBox txtMusteriAd;
        private TextBox txtMusteriAdres;
        private TextBox txtMusteriNumara;
        private TextBox txtMusteriFirma;
        private TextBox txtMusteriVergi;
        private Button btnMusteriEkle;
        private DataGridView dataGridView1;
    }
}