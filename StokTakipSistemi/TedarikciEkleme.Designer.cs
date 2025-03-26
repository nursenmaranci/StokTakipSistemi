namespace StokTakipSistemi
{
    partial class TedarikciEkleme
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
            txtTedarikciAd = new TextBox();
            txtTedarikciAdres = new TextBox();
            txtTedarikciNumara = new TextBox();
            dataGridView1 = new DataGridView();
            btnTedarikciEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 19);
            label2.Name = "label2";
            label2.Size = new Size(495, 46);
            label2.TabIndex = 1;
            label2.Text = "TEDARİKÇİ EKLEME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 91);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 2;
            label1.Text = "Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 139);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 3;
            label3.Text = "Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 185);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 4;
            label4.Text = "Numara";
            // 
            // txtTedarikciAd
            // 
            txtTedarikciAd.Location = new Point(148, 91);
            txtTedarikciAd.Name = "txtTedarikciAd";
            txtTedarikciAd.Size = new Size(150, 31);
            txtTedarikciAd.TabIndex = 5;
            // 
            // txtTedarikciAdres
            // 
            txtTedarikciAdres.Location = new Point(148, 139);
            txtTedarikciAdres.Name = "txtTedarikciAdres";
            txtTedarikciAdres.Size = new Size(150, 31);
            txtTedarikciAdres.TabIndex = 6;
            // 
            // txtTedarikciNumara
            // 
            txtTedarikciNumara.Location = new Point(148, 179);
            txtTedarikciNumara.Name = "txtTedarikciNumara";
            txtTedarikciNumara.Size = new Size(150, 31);
            txtTedarikciNumara.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(383, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(731, 178);
            dataGridView1.TabIndex = 8;
            // 
            // btnTedarikciEkle
            // 
            btnTedarikciEkle.Location = new Point(148, 235);
            btnTedarikciEkle.Name = "btnTedarikciEkle";
            btnTedarikciEkle.Size = new Size(150, 34);
            btnTedarikciEkle.TabIndex = 9;
            btnTedarikciEkle.Text = "Ekle";
            btnTedarikciEkle.UseVisualStyleBackColor = true;
            btnTedarikciEkle.Click += btnTedarikciEkle_Click;
            // 
            // TedarikciEkleme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 382);
            Controls.Add(btnTedarikciEkle);
            Controls.Add(dataGridView1);
            Controls.Add(txtTedarikciNumara);
            Controls.Add(txtTedarikciAdres);
            Controls.Add(txtTedarikciAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "TedarikciEkleme";
            Text = "Tedarikçi Ekleme";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtTedarikciAd;
        private TextBox txtTedarikciAdres;
        private TextBox txtTedarikciNumara;
        private DataGridView dataGridView1;
        private Button btnTedarikciEkle;
    }
}