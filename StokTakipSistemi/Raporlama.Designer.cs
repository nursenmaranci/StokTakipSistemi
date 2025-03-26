namespace StokTakipSistemi
{
    partial class Raporlama
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
            dataGridView1 = new DataGridView();
            lblHareket = new Label();
            label1 = new Label();
            cmbHareketTuru = new ComboBox();
            label2 = new Label();
            cmbUrun = new ComboBox();
            label3 = new Label();
            dtpBaslangic = new DateTimePicker();
            label4 = new Label();
            dtpBitis = new DateTimePicker();
            btnFiltrele = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(428, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(663, 426);
            dataGridView1.TabIndex = 0;
            // 
            // lblHareket
            // 
            lblHareket.AutoSize = true;
            lblHareket.Location = new Point(2, 64);
            lblHareket.Name = "lblHareket";
            lblHareket.Size = new Size(113, 25);
            lblHareket.TabIndex = 1;
            lblHareket.Text = "Hareket Türü";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 46);
            label1.TabIndex = 2;
            label1.Text = "RAPORLAMA";
            // 
            // cmbHareketTuru
            // 
            cmbHareketTuru.FormattingEnabled = true;
            cmbHareketTuru.Items.AddRange(new object[] { "Girdi", "Çıktı", "İade" });
            cmbHareketTuru.Location = new Point(139, 56);
            cmbHareketTuru.Name = "cmbHareketTuru";
            cmbHareketTuru.Size = new Size(182, 33);
            cmbHareketTuru.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 110);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 4;
            label2.Text = "Ürün";
            // 
            // cmbUrun
            // 
            cmbUrun.FormattingEnabled = true;
            cmbUrun.Location = new Point(139, 102);
            cmbUrun.Name = "cmbUrun";
            cmbUrun.Size = new Size(182, 33);
            cmbUrun.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 157);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 6;
            label3.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(138, 151);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(182, 31);
            dtpBaslangic.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 202);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 8;
            label4.Text = "Bitiş Tarihi";
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(138, 202);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(182, 31);
            dtpBitis.TabIndex = 9;
            // 
            // btnFiltrele
            // 
            btnFiltrele.Location = new Point(138, 251);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(188, 34);
            btnFiltrele.TabIndex = 10;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = true;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // Raporlama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 450);
            Controls.Add(btnFiltrele);
            Controls.Add(dtpBitis);
            Controls.Add(label4);
            Controls.Add(dtpBaslangic);
            Controls.Add(label3);
            Controls.Add(cmbUrun);
            Controls.Add(label2);
            Controls.Add(cmbHareketTuru);
            Controls.Add(label1);
            Controls.Add(lblHareket);
            Controls.Add(dataGridView1);
            Name = "Raporlama";
            Text = "Raporlama";
            Load += Raporlama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblHareket;
        private Label label1;
        private ComboBox cmbHareketTuru;
        private Label label2;
        private ComboBox cmbUrun;
        private Label label3;
        private DateTimePicker dtpBaslangic;
        private Label label4;
        private DateTimePicker dtpBitis;
        private Button btnFiltrele;
    }
}