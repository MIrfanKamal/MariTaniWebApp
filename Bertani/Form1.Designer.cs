namespace Bertani
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTentangKami = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnHargaPasar = new System.Windows.Forms.Button();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.btnLahanku = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.hargaPasar = new Bertani.HargaPasar();
            this.catatan = new Bertani.Catatan();
            this.tentangKami = new Bertani.TentangKami();
            this.home = new Bertani.Home();
            this.tipsAndTrick = new Bertani.TipsAndTrick();
            this.panel1.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btnTentangKami);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btnHargaPasar);
            this.panel1.Controls.Add(this.btnTutorial);
            this.panel1.Controls.Add(this.btnLahanku);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 577);
            this.panel1.TabIndex = 0;
            // 
            // btnTentangKami
            // 
            this.btnTentangKami.FlatAppearance.BorderSize = 0;
            this.btnTentangKami.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTentangKami.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTentangKami.ForeColor = System.Drawing.Color.White;
            this.btnTentangKami.Location = new System.Drawing.Point(12, 255);
            this.btnTentangKami.Name = "btnTentangKami";
            this.btnTentangKami.Size = new System.Drawing.Size(165, 30);
            this.btnTentangKami.TabIndex = 8;
            this.btnTentangKami.Text = "      Tentang Kami";
            this.btnTentangKami.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTentangKami.UseVisualStyleBackColor = true;
            this.btnTentangKami.Click += new System.EventHandler(this.btnTentangKami_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Orange;
            this.sidePanel.Location = new System.Drawing.Point(0, 113);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 28);
            this.sidePanel.TabIndex = 7;
            // 
            // btnHargaPasar
            // 
            this.btnHargaPasar.FlatAppearance.BorderSize = 0;
            this.btnHargaPasar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHargaPasar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHargaPasar.ForeColor = System.Drawing.Color.White;
            this.btnHargaPasar.Location = new System.Drawing.Point(12, 147);
            this.btnHargaPasar.Name = "btnHargaPasar";
            this.btnHargaPasar.Size = new System.Drawing.Size(165, 30);
            this.btnHargaPasar.TabIndex = 6;
            this.btnHargaPasar.Text = "      Harga Pasar";
            this.btnHargaPasar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHargaPasar.UseVisualStyleBackColor = true;
            this.btnHargaPasar.Click += new System.EventHandler(this.btnHargaPasar_Click);
            // 
            // btnTutorial
            // 
            this.btnTutorial.FlatAppearance.BorderSize = 0;
            this.btnTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutorial.ForeColor = System.Drawing.Color.White;
            this.btnTutorial.Location = new System.Drawing.Point(12, 183);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(165, 30);
            this.btnTutorial.TabIndex = 5;
            this.btnTutorial.Text = "      Tutorial";
            this.btnTutorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutorial.UseVisualStyleBackColor = true;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // btnLahanku
            // 
            this.btnLahanku.FlatAppearance.BorderSize = 0;
            this.btnLahanku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLahanku.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLahanku.ForeColor = System.Drawing.Color.White;
            this.btnLahanku.Location = new System.Drawing.Point(12, 219);
            this.btnLahanku.Name = "btnLahanku";
            this.btnLahanku.Size = new System.Drawing.Size(165, 30);
            this.btnLahanku.TabIndex = 4;
            this.btnLahanku.Text = "      Lahanku";
            this.btnLahanku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLahanku.UseVisualStyleBackColor = true;
            this.btnLahanku.Click += new System.EventHandler(this.btnLahanku_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 111);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(165, 30);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "      Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Orange;
            this.panelControl.Controls.Add(this.btnMinimize);
            this.panelControl.Controls.Add(this.btnClose);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(177, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(877, 20);
            this.panelControl.TabIndex = 1;
            this.panelControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(840, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMinimize.Size = new System.Drawing.Size(10, 10);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(862, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(10, 10);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 99);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "MariTani";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.74999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(306, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 83);
            this.label4.TabIndex = 5;
            this.label4.Text = "MariTani";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // hargaPasar
            // 
            this.hargaPasar.Location = new System.Drawing.Point(177, 136);
            this.hargaPasar.Name = "hargaPasar";
            this.hargaPasar.Size = new System.Drawing.Size(877, 441);
            this.hargaPasar.TabIndex = 12;
            // 
            // catatan
            // 
            this.catatan.Location = new System.Drawing.Point(177, 136);
            this.catatan.Name = "catatan";
            this.catatan.Size = new System.Drawing.Size(877, 441);
            this.catatan.TabIndex = 13;
            // 
            // tentangKami
            // 
            this.tentangKami.Location = new System.Drawing.Point(177, 133);
            this.tentangKami.Name = "tentangKami";
            this.tentangKami.Size = new System.Drawing.Size(877, 441);
            this.tentangKami.TabIndex = 14;
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(177, 136);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(877, 441);
            this.home.TabIndex = 15;
            // 
            // tipsAndTrick
            // 
            this.tipsAndTrick.Location = new System.Drawing.Point(177, 136);
            this.tipsAndTrick.Name = "tipsAndTrick";
            this.tipsAndTrick.Size = new System.Drawing.Size(877, 441);
            this.tipsAndTrick.TabIndex = 16;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 577);
            this.Controls.Add(this.tipsAndTrick);
            this.Controls.Add(this.home);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tentangKami);
            this.Controls.Add(this.catatan);
            this.Controls.Add(this.hargaPasar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHargaPasar;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.Button btnLahanku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnTentangKami;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private Catatan catatan;
        private HargaPasar hargaPasar;
        private TentangKami tentangKami;
        private TipsAndTrick tipsAndTrick;
        private Home home;
    }
}

