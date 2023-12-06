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

namespace P7_1_714220054
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(450, 235);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOke_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if(string.IsNullOrWhiteSpace(txtNama.Text)) 
            {
                errorMessage += "Nama belum diisi\n";
            }

            if (string.IsNullOrWhiteSpace(txtProdi.Text))
            {
                errorMessage += "Prodi belum diisi\n";
            }

            else if (!Regex.IsMatch(txtProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus berformat [Strata]-[Prodi]\n";
            }

            if (string.IsNullOrWhiteSpace(txtKelas.Text))
            {
                errorMessage += "Kelas belum diisi\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                this.Size = new Size(527, 451);
            }

            else
            {
                MessageBox.Show(
                   errorMessage,
                   "Informasi data Submit",
                   MessageBoxButtons.OK, MessageBoxIcon.Information
                   );
            }

            
        }

        private void rbSenin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSenin.Checked)
            {
                cbKuliah.Enabled = true; cbKuliah.Checked = true;
                cbTravelling.Enabled = false; cbTravelling.Checked = false;
                cbTidur.Enabled = false; cbTidur.Checked = false;
                
            }
        }

        private void rbMinggu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMinggu.Checked)
            {
                 cbKuliah.Enabled = false; cbKuliah.Checked = false; 
                cbTravelling.Enabled = true; cbTravelling.Checked = true;
                cbTidur.Enabled = true; cbTidur.Checked = true;

            }
        }

        private void btnTutuform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetform_Click(object sender, EventArgs e)
        {
            //untuk mereset satu2
            //txtNama.Text = null;
            //txtProdi.Text = null;
            //txtKelas.Text = null;

            //untuk mereset semua form dengan looping
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox) control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                //penggunaan pada combox
                else if (control is ComboBox)
                    ((ComboBox) control).SelectedIndex = -1;
            }
            this.Size = new Size(450, 235);
        }
    }
}
