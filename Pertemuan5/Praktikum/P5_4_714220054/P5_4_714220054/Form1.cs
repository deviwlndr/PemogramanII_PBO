using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220054
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jeniskelamin = cb_jk.SelectedItem.ToString();
            DateTime tanggallahir = tgl.Value;
            string gp_kelas = "";
            string gp_jadwal = "";
           

            if (cb_biola.Checked)
            {
                gp_kelas += "Biola";
            }
            if (checkBox2.Checked)
            {
                gp_kelas += "Gitar";
            }
            if (checkBox3.Checked)
            {
                gp_kelas += "Saxophone";
            }
            if (checkBox4.Checked)
            {
                gp_kelas += "Konduktor";
            }
            if (checkBox5.Checked)
            {
                gp_kelas += "Piano";
            }
            if (checkBox6.Checked)
            {
                gp_kelas += "Drum";
            }
            if (checkBox7.Checked)
            {
                gp_kelas += "Vokal";
            }
            if (checkBox8.Checked)
            {
                gp_kelas += "Komposer";
            }
            else if (string.IsNullOrEmpty(gp_kelas))
            {
                MessageBox.Show("Anda harus memilih kelas.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            

            if (radioButton1.Checked)
            {
                gp_jadwal = "Senin & Rabu, 14:00 - 16:00";
            }
            if (radioButton2.Checked)
            {
                gp_jadwal = "Selasa & Kamis, 14:00 - 16:00";
            }
            if (radioButton3.Checked)
            {
                gp_jadwal = "Sabtu & Minggu, 14:00 - 16:00";
            }
            if (radioButton4.Checked)
            {
                gp_jadwal = "Minggu, 13:00 - 17:00";
            }
            else if (string.IsNullOrEmpty(gp_jadwal))
            {
                MessageBox.Show("Anda harus memilih kelas.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            MessageBox.Show(
                "Nama : " + textnama.Text +
                "\nJenis Kelamin : " + jeniskelamin +
                "\nTanggal Kelahiran : " + tanggallahir.ToString("dd MMMM yyyyy") +
                "\nPilihan Kelas : " + gp_kelas +
                "\nPilihan Jadwal : " + gp_jadwal ,
                
                "\nInformasi Pendaftaran",
           
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
