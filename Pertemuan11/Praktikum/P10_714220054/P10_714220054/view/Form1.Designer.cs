namespace P10_714220054
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbnpm = new System.Windows.Forms.Label();
            this.lbnama = new System.Windows.Forms.Label();
            this.lbangkatan = new System.Windows.Forms.Label();
            this.lbalamat = new System.Windows.Forms.Label();
            this.angkatan = new System.Windows.Forms.ComboBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.npm = new System.Windows.Forms.TextBox();
            this.nohp = new System.Windows.Forms.TextBox();
            this.lbnohp = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnrefres = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataMahasiswa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1123, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Data Mahasiswa";
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(6, 25);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.RowHeadersWidth = 62;
            this.DataMahasiswa.RowTemplate.Height = 28;
            this.DataMahasiswa.Size = new System.Drawing.Size(1111, 305);
            this.DataMahasiswa.TabIndex = 0;
            this.DataMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMahasiswa_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbnpm);
            this.groupBox2.Controls.Add(this.lbnama);
            this.groupBox2.Controls.Add(this.lbangkatan);
            this.groupBox2.Controls.Add(this.lbalamat);
            this.groupBox2.Controls.Add(this.angkatan);
            this.groupBox2.Controls.Add(this.lbemail);
            this.groupBox2.Controls.Add(this.npm);
            this.groupBox2.Controls.Add(this.nohp);
            this.groupBox2.Controls.Add(this.lbnohp);
            this.groupBox2.Controls.Add(this.nama);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.alamat);
            this.groupBox2.Location = new System.Drawing.Point(12, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 503);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Data Mahasiswa";
            // 
            // lbnpm
            // 
            this.lbnpm.AutoSize = true;
            this.lbnpm.Location = new System.Drawing.Point(17, 62);
            this.lbnpm.Name = "lbnpm";
            this.lbnpm.Size = new System.Drawing.Size(43, 20);
            this.lbnpm.TabIndex = 3;
            this.lbnpm.Text = "NPM";
            // 
            // lbnama
            // 
            this.lbnama.AutoSize = true;
            this.lbnama.Location = new System.Drawing.Point(17, 128);
            this.lbnama.Name = "lbnama";
            this.lbnama.Size = new System.Drawing.Size(51, 20);
            this.lbnama.TabIndex = 4;
            this.lbnama.Text = "Nama";
            // 
            // lbangkatan
            // 
            this.lbangkatan.AutoSize = true;
            this.lbangkatan.Location = new System.Drawing.Point(17, 208);
            this.lbangkatan.Name = "lbangkatan";
            this.lbangkatan.Size = new System.Drawing.Size(78, 20);
            this.lbangkatan.TabIndex = 5;
            this.lbangkatan.Text = "Angkatan";
            // 
            // lbalamat
            // 
            this.lbalamat.AutoSize = true;
            this.lbalamat.Location = new System.Drawing.Point(17, 271);
            this.lbalamat.Name = "lbalamat";
            this.lbalamat.Size = new System.Drawing.Size(59, 20);
            this.lbalamat.TabIndex = 6;
            this.lbalamat.Text = "Alamat";
            // 
            // angkatan
            // 
            this.angkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.angkatan.FormattingEnabled = true;
            this.angkatan.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.angkatan.Location = new System.Drawing.Point(185, 208);
            this.angkatan.Name = "angkatan";
            this.angkatan.Size = new System.Drawing.Size(364, 28);
            this.angkatan.TabIndex = 15;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(17, 374);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(48, 20);
            this.lbemail.TabIndex = 7;
            this.lbemail.Text = "Email";
            // 
            // npm
            // 
            this.npm.Location = new System.Drawing.Point(185, 62);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(364, 26);
            this.npm.TabIndex = 9;
            // 
            // nohp
            // 
            this.nohp.Location = new System.Drawing.Point(185, 440);
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(364, 26);
            this.nohp.TabIndex = 14;
            // 
            // lbnohp
            // 
            this.lbnohp.AutoSize = true;
            this.lbnohp.Location = new System.Drawing.Point(17, 446);
            this.lbnohp.Name = "lbnohp";
            this.lbnohp.Size = new System.Drawing.Size(55, 20);
            this.lbnohp.TabIndex = 8;
            this.lbnohp.Text = "No HP";
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(185, 128);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(364, 26);
            this.nama.TabIndex = 10;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(185, 374);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(364, 26);
            this.email.TabIndex = 13;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(185, 271);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(364, 68);
            this.alamat.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnhapus);
            this.groupBox3.Controls.Add(this.btnrefres);
            this.groupBox3.Controls.Add(this.btnubah);
            this.groupBox3.Controls.Add(this.btnsimpan);
            this.groupBox3.Location = new System.Drawing.Point(679, 519);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 338);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnhapus.Location = new System.Drawing.Point(19, 266);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(437, 36);
            this.btnhapus.TabIndex = 19;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnrefres
            // 
            this.btnrefres.Location = new System.Drawing.Point(19, 49);
            this.btnrefres.Name = "btnrefres";
            this.btnrefres.Size = new System.Drawing.Size(437, 34);
            this.btnrefres.TabIndex = 16;
            this.btnrefres.Text = "Refresh";
            this.btnrefres.UseVisualStyleBackColor = true;
            this.btnrefres.Click += new System.EventHandler(this.btnrefres_Click);
            // 
            // btnubah
            // 
            this.btnubah.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnubah.Location = new System.Drawing.Point(19, 192);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(437, 35);
            this.btnubah.TabIndex = 18;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = false;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsimpan.Location = new System.Drawing.Point(19, 118);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(437, 34);
            this.btnsimpan.TabIndex = 17;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 878);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ulbi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbnpm;
        private System.Windows.Forms.Label lbnama;
        private System.Windows.Forms.Label lbangkatan;
        private System.Windows.Forms.Label lbalamat;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbnohp;
        private System.Windows.Forms.TextBox npm;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox nohp;
        private System.Windows.Forms.ComboBox angkatan;
        private System.Windows.Forms.Button btnrefres;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.DataGridView DataMahasiswa;
    }
}

