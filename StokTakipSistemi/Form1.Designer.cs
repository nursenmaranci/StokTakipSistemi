namespace StokTakipSistemi
{
    partial class StokTakip
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnUrun = new Button();
            btnStok = new Button();
            btnRapor = new Button();
            btnMusteri = new Button();
            btnTedarikci = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dutch801 XBd BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(826, 87);
            label1.TabIndex = 0;
            label1.Text = "STOK TAKİP SİSTEMİ";
            // 
            // btnUrun
            // 
            btnUrun.Location = new Point(31, 148);
            btnUrun.Name = "btnUrun";
            btnUrun.Size = new Size(246, 204);
            btnUrun.TabIndex = 1;
            btnUrun.Text = "Ürün Yönetimi";
            btnUrun.UseVisualStyleBackColor = true;
            btnUrun.Click += btnUrun_Click;
            // 
            // btnStok
            // 
            btnStok.Location = new Point(299, 148);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(246, 204);
            btnStok.TabIndex = 2;
            btnStok.Text = "Stok Hareketleri";
            btnStok.UseVisualStyleBackColor = true;
            btnStok.Click += btnStok_Click;
            // 
            // btnRapor
            // 
            btnRapor.Location = new Point(565, 148);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(246, 204);
            btnRapor.TabIndex = 3;
            btnRapor.Text = "Raporlar";
            btnRapor.UseVisualStyleBackColor = true;
            btnRapor.Click += btnRapor_Click;
            // 
            // btnMusteri
            // 
            btnMusteri.Location = new Point(163, 367);
            btnMusteri.Name = "btnMusteri";
            btnMusteri.Size = new Size(246, 204);
            btnMusteri.TabIndex = 4;
            btnMusteri.Text = "Müşteri Ekleme";
            btnMusteri.UseVisualStyleBackColor = true;
            btnMusteri.Click += btnMusteri_Click;
            // 
            // btnTedarikci
            // 
            btnTedarikci.Location = new Point(431, 367);
            btnTedarikci.Name = "btnTedarikci";
            btnTedarikci.Size = new Size(246, 204);
            btnTedarikci.TabIndex = 5;
            btnTedarikci.Text = "Tedarikçi Ekleme";
            btnTedarikci.UseVisualStyleBackColor = true;
            btnTedarikci.Click += btnTedarikci_Click;
            // 
            // StokTakip
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 625);
            Controls.Add(btnTedarikci);
            Controls.Add(btnMusteri);
            Controls.Add(btnRapor);
            Controls.Add(btnStok);
            Controls.Add(btnUrun);
            Controls.Add(label1);
            Name = "StokTakip";
            Text = "Stok Takip Sistemi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUrun;
        private Button btnStok;
        private Button btnRapor;
        private Button btnMusteri;
        private Button btnTedarikci;
    }
}
