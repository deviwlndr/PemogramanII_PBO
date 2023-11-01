using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714220054
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "textbox Huruf tidak boleh kosong!");
            }
            else
            {


                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul Betul Betul!");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }

        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "textbox Huruf tidak boleh kosong!");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtAngka, "Betul!");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                }
                else
                {
                    epCorrect.SetError(txtAngka, "");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "Inputan hanya boleh angka!");
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "textbox Huruf tidak boleh kosong!");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka1, "textbox Huruf tidak boleh kosong!");
            }
            else
            {
                if (int.TryParse(txtAngka1.Text, out int angka1) && int.TryParse(txtAngka2.Text, out int angka2))
                {
                    if (angka1 > angka2)
                    {
                        epCorrect.SetError(txtAngka1, "Betul!");
                        epWarning.SetError(txtAngka1, "");
                        epWrong.SetError(txtAngka1, "");
                    }
                    else
                    {
                        epCorrect.SetError(txtAngka1, "");
                        epWarning.SetError(txtAngka1, "");
                        epWrong.SetError(txtAngka1, "Angka1 harus lebih besar dari Angka2.");
                    }
                }
                else
                {
                    epCorrect.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "Inputan hanya boleh angka!");
                }
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "textbox Huruf tidak boleh kosong!");
            }
            else
            {
                if (int.TryParse(txtAngka1.Text, out int angka1) && int.TryParse(txtAngka2.Text, out int angka2))
                {
                    if (angka1 > angka2)
                    {
                        epCorrect.SetError(txtAngka2, "Betul!");
                        epWarning.SetError(txtAngka2, "");
                        epWrong.SetError(txtAngka2, "");
                    }
                    else
                    {
                        epCorrect.SetError(txtAngka2, "");
                        epWarning.SetError(txtAngka2, "");
                        epWrong.SetError(txtAngka2, "Angka2 harus lebih kecil dari Angka1.");
                    }
                }
                else
                {
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "Inputan hanya boleh angka!");
                }
            }
        }
    }
}
