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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbnpm = new System.Windows.Forms.Label();
            this.lbnama = new System.Windows.Forms.Label();
            this.lbangkatan = new System.Windows.Forms.Label();
            this.lbalamat = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbnohp = new System.Windows.Forms.Label();
            this.tbnpm = new System.Windows.Forms.TextBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbnohp = new System.Windows.Forms.TextBox();
            this.cbangkatan = new System.Windows.Forms.ComboBox();
            this.btnrefres = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbnpm);
            this.groupBox2.Controls.Add(this.lbnama);
            this.groupBox2.Controls.Add(this.lbangkatan);
            this.groupBox2.Controls.Add(this.lbalamat);
            this.groupBox2.Controls.Add(this.cbangkatan);
            this.groupBox2.Controls.Add(this.lbemail);
            this.groupBox2.Controls.Add(this.tbnpm);
            this.groupBox2.Controls.Add(this.tbnohp);
            this.groupBox2.Controls.Add(this.lbnohp);
            this.groupBox2.Controls.Add(this.tbnama);
            this.groupBox2.Controls.Add(this.tbemail);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 503);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Data Mahasiswa";
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
            // lbnpm
            // 
            this.lbnpm.AutoSize = true;
            this.lbnpm.Location = new System.Drawing.Point(17, 62);
            this.lbnpm.Name = "lbnpm";
            this.lbnpm.Size = new System.Drawing.Size(43, 20);
            this.lbnpm.TabIndex = 3;
            this.lbnpm.Text = "NPM";
            this.lbnpm.Click += new System.EventHandler(this.label1_Click);
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
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(17, 374);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(48, 20);
            this.lbemail.TabIndex = 7;
            this.lbemail.Text = "Email";
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
            // tbnpm
            // 
            this.tbnpm.Location = new System.Drawing.Point(185, 62);
            this.tbnpm.Name = "tbnpm";
            this.tbnpm.Size = new System.Drawing.Size(364, 26);
            this.tbnpm.TabIndex = 9;
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(185, 128);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(364, 26);
            this.tbnama.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(185, 271);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(364, 68);
            this.textBox4.TabIndex = 12;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(185, 374);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(364, 26);
            this.tbemail.TabIndex = 13;
            // 
            // tbnohp
            // 
            this.tbnohp.Location = new System.Drawing.Point(185, 440);
            this.tbnohp.Name = "tbnohp";
            this.tbnohp.Size = new System.Drawing.Size(364, 26);
            this.tbnohp.TabIndex = 14;
            // 
            // cbangkatan
            // 
            this.cbangkatan.FormattingEnabled = true;
            this.cbangkatan.Location = new System.Drawing.Point(185, 208);
            this.cbangkatan.Name = "cbangkatan";
            this.cbangkatan.Size = new System.Drawing.Size(364, 28);
            this.cbangkatan.TabIndex = 15;
            // 
            // btnrefres
            // 
            this.btnrefres.Location = new System.Drawing.Point(19, 49);
            this.btnrefres.Name = "btnrefres";
            this.btnrefres.Size = new System.Drawing.Size(437, 34);
            this.btnrefres.TabIndex = 16;
            this.btnrefres.Text = "Refresh";
            this.btnrefres.UseVisualStyleBackColor = true;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
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
        private System.Windows.Forms.TextBox tbnpm;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbnohp;
        private System.Windows.Forms.ComboBox cbangkatan;
        private System.Windows.Forms.Button btnrefres;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.DataGridView DataMahasiswa;
    }
}

