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
            if (textBox1.Text == "")
            {
                epWarning.SetError(textBox1, "Menu tidak boleh kosong!");
            }
            else
            {


                if ((textBox1.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(textBox1, "");
                    epWrong.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "Betul Betul Betul!");
                }
                else
                {
                    epWrong.SetError(textBox1, "Inputan hanya boleh huruf!");
                    epWarning.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string groupBox1 = "";

            if (checkBox1.Checked)
            {
                groupBox1 += "Cash";
            }
            if (checkBox2.Checked)
            {
                groupBox1 += "Debit Card";
            }

            else if (string.IsNullOrEmpty(groupBox1))
            {
                MessageBox.Show("Anda harus memilih metode pembayaran.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Pesanan: " + textBox1.Text + "\nKuantitas: " + textBox2 + "\nMetode Pembayaran: " + groupBox1 , "\nInformasi",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void textBox2_Leave(object sender, EventArgs e)
        {
            
            
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                epWarning.SetError(textBox2, "Kuantitas tidak boleh kosong!");
            }
            else
            {
                if ((textBox2.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(textBox2, "Betul!");
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "");
                }
                else
                {
                    epCorrect.SetError(textBox2, "");
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "Inputan hanya boleh angka!");
                }
            }
        }
    }
}
    
