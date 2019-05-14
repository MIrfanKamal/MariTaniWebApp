namespace Bertani
{
    partial class HargaPasar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HargaPasar));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.dtpTanggalKe = new System.Windows.Forms.DateTimePicker();
            this.dtpTanggalDari = new System.Windows.Forms.DateTimePicker();
            this.cbDaerah = new System.Windows.Forms.ComboBox();
            this.cbKomoditasHP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.crtHargaPasar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtHargaPasar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Komoditas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Daerah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Informasi Harga Pangan Pasar Tradisional";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnTampilkan);
            this.panel1.Controls.Add(this.dtpTanggalKe);
            this.panel1.Controls.Add(this.dtpTanggalDari);
            this.panel1.Controls.Add(this.cbDaerah);
            this.panel1.Controls.Add(this.cbKomoditasHP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 63);
            this.panel1.TabIndex = 3;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTampilkan.BackgroundImage")));
            this.btnTampilkan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTampilkan.FlatAppearance.BorderSize = 0;
            this.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampilkan.Location = new System.Drawing.Point(825, 17);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(30, 30);
            this.btnTampilkan.TabIndex = 8;
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // dtpTanggalKe
            // 
            this.dtpTanggalKe.Location = new System.Drawing.Point(584, 31);
            this.dtpTanggalKe.MaxDate = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
            this.dtpTanggalKe.MinDate = new System.DateTime(2018, 5, 22, 0, 0, 0, 0);
            this.dtpTanggalKe.Name = "dtpTanggalKe";
            this.dtpTanggalKe.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggalKe.TabIndex = 7;
            this.dtpTanggalKe.Value = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
            // 
            // dtpTanggalDari
            // 
            this.dtpTanggalDari.Location = new System.Drawing.Point(378, 31);
            this.dtpTanggalDari.MaxDate = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
            this.dtpTanggalDari.MinDate = new System.DateTime(2018, 5, 22, 0, 0, 0, 0);
            this.dtpTanggalDari.Name = "dtpTanggalDari";
            this.dtpTanggalDari.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggalDari.TabIndex = 4;
            this.dtpTanggalDari.Value = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
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
            this.cbDaerah.Location = new System.Drawing.Point(169, 30);
            this.cbDaerah.Name = "cbDaerah";
            this.cbDaerah.Size = new System.Drawing.Size(192, 21);
            this.cbDaerah.TabIndex = 6;
            // 
            // cbKomoditasHP
            // 
            this.cbKomoditasHP.FormattingEnabled = true;
            this.cbKomoditasHP.Items.AddRange(new object[] {
            "Beras",
            "Bawang Merah",
            "Bawang Putih",
            "Cabai Merah",
            "Cabai Rawit",
            "Gula"});
            this.cbKomoditasHP.Location = new System.Drawing.Point(15, 30);
            this.cbKomoditasHP.Name = "cbKomoditasHP";
            this.cbKomoditasHP.Size = new System.Drawing.Size(148, 21);
            this.cbKomoditasHP.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tanggal Selesai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tanggal Mulai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(522, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 2;
            // 
            // crtHargaPasar
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.crtHargaPasar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtHargaPasar.Legends.Add(legend1);
            this.crtHargaPasar.Location = new System.Drawing.Point(13, 123);
            this.crtHargaPasar.Name = "crtHargaPasar";
            this.crtHargaPasar.Size = new System.Drawing.Size(830, 305);
            this.crtHargaPasar.TabIndex = 4;
            this.crtHargaPasar.Text = "chart1";
            // 
            // HargaPasar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crtHargaPasar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "HargaPasar";
            this.Size = new System.Drawing.Size(877, 441);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtHargaPasar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpTanggalKe;
        private System.Windows.Forms.DateTimePicker dtpTanggalDari;
        private System.Windows.Forms.ComboBox cbDaerah;
        private System.Windows.Forms.ComboBox cbKomoditasHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtHargaPasar;
        private System.Windows.Forms.Button btnTampilkan;
    }
}
