using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P6_4_714220054
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label10.Text = textBox1.Text;
            string input = textBox1.Text;

            if (!string.IsNullOrEmpty(input))
            {
                // Ubah huruf pertama menjadi huruf besar (upper case)
                input = char.ToUpper(input[0]) + input.Substring(1).ToLower();

                // Perbarui teks dalam TextBox
                textBox1.Text = input;

                // Pindahkan kursor ke akhir teks
                textBox1.SelectionStart = input.Length;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = numericUpDown1.Value.ToString();
            int quantity = (int)numericUpDown1.Value;
            

            if (quantity == 0)
            {
                MessageBox.Show("Masukan kuantitas", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length >= 20)
            {
                e.Handled = true; // Mencegah karakter kedua dan seterusnya dimasukkan

            }
               
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Menu tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string groupBox1 = "";

            if (checkBox1.Checked)
            {
                groupBox1 = "Cash";
            }
            if (checkBox2.Checked)
            {
                groupBox1 = "Debit Card";
            }

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Input tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Pesanan: " + textBox1.Text + "\nKuantitas: " + numericUpDown1.Value + "\nMetode Pembayaran: " + groupBox1 , "\nInformasi",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
    
