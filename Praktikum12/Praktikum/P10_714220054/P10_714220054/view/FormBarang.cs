using MySql.Data.MySqlClient;
using P10_714220054.controller;
using P10_714220054.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P10_714220054.view
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang m_barang = new M_barang();
        string id_barang;

        
        public FormBarang()
        {
           
            InitializeComponent();
        }
        public void Tampil()
        {

            //Query DB Get MGS
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");
            //mengubah nama header tabel
            DataBarang.Columns[0].HeaderText = "ID";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Harga";
            
        }
        
        
        private void DataBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Pastikan bahwa sel memiliki nilai dan indeks kolom adalah 2 (kolom harga)
            if (e.Value != null && e.ColumnIndex == 2)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }
        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }

        public void ResetForm()
        {

            tbNamaBarang.Text = "";
            tbHarga.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNamaBarang.Text == "" || tbHarga.Text == "" )
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Barang barang = new Barang();
                {
                    m_barang.Nama_barang = tbNamaBarang.Text;
                    m_barang.Harga = tbHarga.Text;
                   
                    barang.Insert(m_barang);

                    ResetForm();
                    Tampil();
                }

            }
        }
        

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            id_barang = DataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNamaBarang.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbHarga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbNamaBarang.Text == "" || tbHarga.Text == "" )
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Barang barang = new Barang();
                {
                    m_barang.Nama_barang = tbNamaBarang.Text;
                    m_barang.Harga = tbHarga.Text;

                    barang.Update(m_barang, id_barang);

                    ResetForm();
                    Tampil();
                }
            }
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            //memanggil method tampil
            Tampil();

            DataBarang.CellFormatting += DataBarang_CellFormatting;

        }
        
        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        public void RefreshForm()
        {
            ResetForm();
            Tampil();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Barang barang = new Barang();
                barang.Delete(id_barang);
                ResetForm();
                Tampil();
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB seacrh data
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE id_barang LIKE '%" + tbCariData.Text + "%' OR nama_barang LIKE '%" + tbCariData.Text + "%'");
        }

    }
}
