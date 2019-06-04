namespace Bertani
{
    partial class LahankuTambahForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LahankuTambahForm));
            this.panelControl = new System.Windows.Forms.Panel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEstimasiPanen = new System.Windows.Forms.Label();
            this.lblEstimasiKeuntungan = new System.Windows.Forms.Label();
            this.cbKomoditas = new System.Windows.Forms.ComboBox();
            this.tbLuasLahan = new System.Windows.Forms.TextBox();
            this.tbHasilperHektar = new System.Windows.Forms.TextBox();
            this.tbHargaBibit = new System.Windows.Forms.TextBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.tbBiayaPerawatan = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbDaerah = new System.Windows.Forms.ComboBox();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Orange;
            this.panelControl.Controls.Add(this.lblJudul);
            this.panelControl.Controls.Add(this.btn_Close);
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(350, 20);
            this.panelControl.TabIndex = 0;
            this.panelControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(2, 2);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(111, 16);
            this.lblJudul.TabIndex = 19;
            this.lblJudul.Text = "Tambah Lahan";
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(335, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(10, 10);
            this.btn_Close.TabIndex = 19;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Komoditas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Luas Lahan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Target per Hektar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tanggal Penanaman";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Harga Total Bibit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Biaya Perawatan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Estimasi Panen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Estimasi Keuntungan";
            // 
            // lblEstimasiPanen
            // 
            this.lblEstimasiPanen.AutoSize = true;
            this.lblEstimasiPanen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimasiPanen.Location = new System.Drawing.Point(157, 259);
            this.lblEstimasiPanen.Name = "lblEstimasiPanen";
            this.lblEstimasiPanen.Size = new System.Drawing.Size(12, 16);
            this.lblEstimasiPanen.TabIndex = 9;
            this.lblEstimasiPanen.Text = "-";
            // 
            // lblEstimasiKeuntungan
            // 
            this.lblEstimasiKeuntungan.AutoSize = true;
            this.lblEstimasiKeuntungan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimasiKeuntungan.Location = new System.Drawing.Point(157, 285);
            this.lblEstimasiKeuntungan.Name = "lblEstimasiKeuntungan";
            this.lblEstimasiKeuntungan.Size = new System.Drawing.Size(12, 16);
            this.lblEstimasiKeuntungan.TabIndex = 10;
            this.lblEstimasiKeuntungan.Text = "-";
            // 
            // cbKomoditas
            // 
            this.cbKomoditas.FormattingEnabled = true;
            this.cbKomoditas.Items.AddRange(new object[] {
            "Beras",
            "Bawang Merah",
            "Bawang Putih",
            "Cabai Merah",
            "Cabai Rawit",
            "Gula"});
            this.cbKomoditas.Location = new System.Drawing.Point(160, 40);
            this.cbKomoditas.Name = "cbKomoditas";
            this.cbKomoditas.Size = new System.Drawing.Size(158, 21);
            this.cbKomoditas.TabIndex = 11;
            // 
            // tbLuasLahan
            // 
            this.tbLuasLahan.Location = new System.Drawing.Point(160, 71);
            this.tbLuasLahan.Name = "tbLuasLahan";
            this.tbLuasLahan.Size = new System.Drawing.Size(138, 20);
            this.tbLuasLahan.TabIndex = 12;
            // 
            // tbHasilperHektar
            // 
            this.tbHasilperHektar.Location = new System.Drawing.Point(160, 101);
            this.tbHasilperHektar.Name = "tbHasilperHektar";
            this.tbHasilperHektar.Size = new System.Drawing.Size(138, 20);
            this.tbHasilperHektar.TabIndex = 13;
            // 
            // tbHargaBibit
            // 
            this.tbHargaBibit.Location = new System.Drawing.Point(160, 163);
            this.tbHargaBibit.Name = "tbHargaBibit";
            this.tbHargaBibit.Size = new System.Drawing.Size(158, 20);
            this.tbHargaBibit.TabIndex = 14;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(160, 132);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(158, 20);
            this.dtpTanggal.TabIndex = 15;
            // 
            // tbBiayaPerawatan
            // 
            this.tbBiayaPerawatan.Location = new System.Drawing.Point(160, 196);
            this.tbBiayaPerawatan.Name = "tbBiayaPerawatan";
            this.tbBiayaPerawatan.Size = new System.Drawing.Size(158, 20);
            this.tbBiayaPerawatan.TabIndex = 16;
            // 
            // btnHitung
            // 
            this.btnHitung.BackColor = System.Drawing.SystemColors.Control;
            this.btnHitung.Location = new System.Drawing.Point(172, 335);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 17;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = false;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.Control;
            this.btnTambah.Location = new System.Drawing.Point(263, 335);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 18;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hektar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ton";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Lokasi";
            // 
            // cbDaerah
            // 
            this.cbDaerah.FormattingEnabled = true;
            this.cbDaerah.Items.AddRange(new object[] {
            "Banten",
            "Jawa Barat",
            "DKI Jakarta",
            "Jawa Tengah",
            "DI Yogyakarta",
            "Jawa Timur",
            "Bali"});
            this.cbDaerah.Location = new System.Drawing.Point(160, 227);
            this.cbDaerah.Name = "cbDaerah";
            this.cbDaerah.Size = new System.Drawing.Size(158, 21);
            this.cbDaerah.TabIndex = 22;
            // 
            // LahankuTambahForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(350, 370);
            this.Controls.Add(this.cbDaerah);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.tbBiayaPerawatan);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.tbHargaBibit);
            this.Controls.Add(this.tbHasilperHektar);
            this.Controls.Add(this.tbLuasLahan);
            this.Controls.Add(this.cbKomoditas);
            this.Controls.Add(this.lblEstimasiKeuntungan);
            this.Controls.Add(this.lblEstimasiPanen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LahankuTambahForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LahankuTambahForm";
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEstimasiPanen;
        private System.Windows.Forms.Label lblEstimasiKeuntungan;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ComboBox cbKomoditas;
        private System.Windows.Forms.TextBox tbLuasLahan;
        private System.Windows.Forms.TextBox tbHasilperHektar;
        private System.Windows.Forms.TextBox tbHargaBibit;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.TextBox tbBiayaPerawatan;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbDaerah;
    }
}