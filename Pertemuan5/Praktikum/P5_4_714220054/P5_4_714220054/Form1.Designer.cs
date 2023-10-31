namespace P5_4_714220054
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
            this.label1 = new System.Windows.Forms.Label();
            this.jeniskelamin = new System.Windows.Forms.Label();
            this.tanggallahir = new System.Windows.Forms.Label();
            this.textnama = new System.Windows.Forms.TextBox();
            this.cb_jk = new System.Windows.Forms.ComboBox();
            this.tgl = new System.Windows.Forms.DateTimePicker();
            this.gp_kelas = new System.Windows.Forms.GroupBox();
            this.gp_jadwal = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.cb_biola = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gp_kelas.SuspendLayout();
            this.gp_jadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // jeniskelamin
            // 
            this.jeniskelamin.AutoSize = true;
            this.jeniskelamin.Location = new System.Drawing.Point(334, 157);
            this.jeniskelamin.Name = "jeniskelamin";
            this.jeniskelamin.Size = new System.Drawing.Size(106, 20);
            this.jeniskelamin.TabIndex = 1;
            this.jeniskelamin.Text = "Jenis Kelamin";
            // 
            // tanggallahir
            // 
            this.tanggallahir.AutoSize = true;
            this.tanggallahir.Location = new System.Drawing.Point(335, 217);
            this.tanggallahir.Name = "tanggallahir";
            this.tanggallahir.Size = new System.Drawing.Size(105, 20);
            this.tanggallahir.TabIndex = 2;
            this.tanggallahir.Text = "Tanggal Lahir";
            this.tanggallahir.Click += new System.EventHandler(this.label3_Click);
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(538, 85);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(263, 26);
            this.textnama.TabIndex = 3;
            this.textnama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cb_jk
            // 
            this.cb_jk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_jk.FormattingEnabled = true;
            this.cb_jk.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cb_jk.Location = new System.Drawing.Point(539, 149);
            this.cb_jk.Name = "cb_jk";
            this.cb_jk.Size = new System.Drawing.Size(196, 28);
            this.cb_jk.TabIndex = 4;
            this.cb_jk.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tgl
            // 
            this.tgl.Location = new System.Drawing.Point(538, 211);
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(263, 26);
            this.tgl.TabIndex = 5;
            // 
            // gp_kelas
            // 
            this.gp_kelas.Controls.Add(this.cb_biola);
            this.gp_kelas.Controls.Add(this.checkBox8);
            this.gp_kelas.Controls.Add(this.checkBox2);
            this.gp_kelas.Controls.Add(this.checkBox3);
            this.gp_kelas.Controls.Add(this.checkBox4);
            this.gp_kelas.Controls.Add(this.checkBox5);
            this.gp_kelas.Controls.Add(this.checkBox6);
            this.gp_kelas.Controls.Add(this.checkBox7);
            this.gp_kelas.Location = new System.Drawing.Point(161, 295);
            this.gp_kelas.Name = "gp_kelas";
            this.gp_kelas.Size = new System.Drawing.Size(314, 274);
            this.gp_kelas.TabIndex = 7;
            this.gp_kelas.TabStop = false;
            this.gp_kelas.Text = "Pilihan Kelas";
            // 
            // gp_jadwal
            // 
            this.gp_jadwal.Controls.Add(this.radioButton1);
            this.gp_jadwal.Controls.Add(this.radioButton3);
            this.gp_jadwal.Controls.Add(this.radioButton4);
            this.gp_jadwal.Controls.Add(this.radioButton2);
            this.gp_jadwal.Location = new System.Drawing.Point(588, 295);
            this.gp_jadwal.Name = "gp_jadwal";
            this.gp_jadwal.Size = new System.Drawing.Size(340, 274);
            this.gp_jadwal.TabIndex = 8;
            this.gp_jadwal.TabStop = false;
            this.gp_jadwal.Text = "Pilihan Jadwal";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(238, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Senin && Rabu, 14:00 - 16:00 ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(246, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Selasa && Kamis, 14:00 - 16:00";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 162);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(249, 24);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Sabtu && Minggu, 14:00 - 16:00";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(23, 230);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(187, 24);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Minggu, 13:00 - 17:00";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // cb_biola
            // 
            this.cb_biola.AutoSize = true;
            this.cb_biola.Location = new System.Drawing.Point(6, 38);
            this.cb_biola.Name = "cb_biola";
            this.cb_biola.Size = new System.Drawing.Size(70, 24);
            this.cb_biola.TabIndex = 13;
            this.cb_biola.Text = "Biola";
            this.cb_biola.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 101);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(70, 24);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Gitar";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 167);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(116, 24);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Saxophone";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 236);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(108, 24);
            this.checkBox4.TabIndex = 16;
            this.checkBox4.Text = "Konduktor";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(195, 38);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(75, 24);
            this.checkBox5.TabIndex = 17;
            this.checkBox5.Text = "Piano";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(195, 101);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(74, 24);
            this.checkBox6.TabIndex = 18;
            this.checkBox6.Text = "Drum";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(195, 167);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(75, 24);
            this.checkBox7.TabIndex = 19;
            this.checkBox7.Text = "Vokal";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(195, 236);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(107, 24);
            this.checkBox8.TabIndex = 20;
            this.checkBox8.Text = "Komposer";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(300, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Tampilkan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(695, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "Selesai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(377, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 33);
            this.label4.TabIndex = 23;
            this.label4.Text = "FORM PENDAFTARAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1100, 632);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gp_jadwal);
            this.Controls.Add(this.gp_kelas);
            this.Controls.Add(this.tgl);
            this.Controls.Add(this.cb_jk);
            this.Controls.Add(this.textnama);
            this.Controls.Add(this.tanggallahir);
            this.Controls.Add(this.jeniskelamin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gp_kelas.ResumeLayout(false);
            this.gp_kelas.PerformLayout();
            this.gp_jadwal.ResumeLayout(false);
            this.gp_jadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label jeniskelamin;
        private System.Windows.Forms.Label tanggallahir;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.ComboBox cb_jk;
        private System.Windows.Forms.DateTimePicker tgl;
        private System.Windows.Forms.GroupBox gp_kelas;
        private System.Windows.Forms.CheckBox cb_biola;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.GroupBox gp_jadwal;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}

