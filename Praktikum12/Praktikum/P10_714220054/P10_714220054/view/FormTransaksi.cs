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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P10_714220054.view
{
    public partial class FormTransaksi : Form
    {
        Koneksi koneksi = new Koneksi();
        M_transaksi_barang m_transaksi_barang = new M_transaksi_barang();
        string id_transaksi;
        string id_barang;

        public FormTransaksi()
        {
            InitializeComponent();

        }
        public void Tampil()
        {
            DataTransaksi.DataSource = koneksi.ShowData("SELECT " +
                "t_transaksi.id_transaksi, t_barang.id_barang, nama_barang, harga, qty, total " +
                "FROM t_transaksi " +
                "JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang");

            // Mengubah nama header tabel
            DataTransaksi.Columns[0].HeaderText = "ID Transaksi";
            DataTransaksi.Columns[1].HeaderText = "ID Barang";
            DataTransaksi.Columns[2].HeaderText = "Nama Barang";
            DataTransaksi.Columns[3].HeaderText = "Harga";
            DataTransaksi.Columns[4].HeaderText = "Quantity";
            DataTransaksi.Columns[5].HeaderText = "Total Harga";
        }


        public void ResetForm()
        {
            idbarang.SelectedIndex = -1;
            namabarang.Text = "";
            hargabarang.Text = "";
            qyt.Text = "";
            total.Text = "";
            tbCariData.Text = "";
        }

        
        private void CalculateAndDisplayTotal()
        {
            if (decimal.TryParse(hargabarang.Text, out decimal harga) && decimal.TryParse(qyt.Text, out decimal quantity))
            {
                decimal numericTotal = harga * quantity;
                total.Text = numericTotal.ToString("C"); // Menampilkan total dalam format mata uang
            }
            else
            {
                total.Text = "0"; // Atau dapat disesuaikan sesuai kebutuhan
            }
        }

        private bool IsValidInput()
        {
            // Validasi input sesuai kebutuhan, misalnya, pastikan ID barang dipilih
            return idbarang.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(qyt.Text);
        }

        private void qyt_TextChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayTotal();
        }

        private void hargabarang_TextChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayTotal();
        }



        private void btnubah_Click(object sender, EventArgs e)
        {
            if (idbarang.SelectedIndex == -1 || namabarang.Text == "" || hargabarang.Text == "" || qyt.Text == "" || total.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (IsValidInput())
            {
                Transaksi trxbarang = new Transaksi();
                m_transaksi_barang.Id_barang = idbarang.Text;
                m_transaksi_barang.Qyt = qyt.Text;

                // Hitung total berdasarkan Harga Satuan Barang x Quantity
                if (decimal.TryParse(hargabarang.Text, out decimal harga) && decimal.TryParse(qyt.Text, out decimal quantity))
                {
                    decimal numericTotal = harga * quantity;
                    m_transaksi_barang.Total = numericTotal.ToString();
                }
                else
                {
                    MessageBox.Show("Harga atau Quantity tidak valid", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Jangan lanjutkan jika Harga atau Quantity tidak valid
                }

                trxbarang.Update(m_transaksi_barang, id_transaksi);
                ResetForm();
                Tampil();
            }
        }


        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataBarang();
            GetNamaBarang();
            GetHargaBarang();

            qyt.TextChanged += qyt_TextChanged;
            hargabarang.TextChanged += hargabarang_TextChanged;
            idbarang.SelectedIndexChanged += idbarang_SelectedIndexChanged;
            
        }

        public void GetDataBarang()
        {
            //ambil data id barang dari table (t_barang) untuk mengisi data pada comcoboc id barang
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang");
            while (reader.Read())
            {
                idbarang.Items.Add(reader.GetString("id_barang"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void GetNamaBarang()
        {
            //ambil data nama barang ketika combobox id barang dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama_barang FROM t_barang WHERE id_barang = '" + idbarang.Text + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    namabarang.Text = reader.GetString(0);
                }
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void GetHargaBarang()
        {
            //ambil data harga barang ketika combobox id barang dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT harga FROM t_barang WHERE id_barang = '" + idbarang.Text + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    hargabarang.Text = reader.GetString(0);
                }
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void DataTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            id_barang = DataTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            namabarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            hargabarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            qyt.Text = DataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            // Hitung total dan tampilkan di TextBox total
            CalculateAndDisplayTotal();
        }

        

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (idbarang.SelectedIndex == -1 || namabarang.Text == "" || hargabarang.Text == "" || qyt.Text == ""|| total.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (IsValidInput())
            {
                Transaksi trxbarang = new Transaksi();
                m_transaksi_barang.Id_barang = idbarang.Text;
                m_transaksi_barang.Qyt = qyt.Text;
                
                // Hitung total berdasarkan Harga Satuan Barang x Quantity
                if (decimal.TryParse(hargabarang.Text, out decimal harga) && decimal.TryParse(qyt.Text, out decimal quantity))
                {
                    decimal numericTotal = harga * quantity;
                    m_transaksi_barang.Total = numericTotal.ToString();
                }
                else
                {
                    MessageBox.Show("Harga atau Quantity tidak valid", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Jangan lanjutkan jika Harga atau Quantity tidak valid
                }
                trxbarang.Insert(m_transaksi_barang);
                ResetForm();
                Tampil();
            }
        }

        

        private void idbarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaBarang();
            GetHargaBarang();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void tbCariData_Click(object sender, EventArgs e)
        {
            // Query search data
            DataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, qty, total, t_transaksi.id_barang, nama_barang, harga " +
                "FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang " +
                "WHERE t_transaksi.id_barang LIKE '%" + tbCariData.Text + "%' " +
                "OR nama_barang LIKE '%" + tbCariData.Text + "%'");
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            // Panggil fungsi pencarian setiap kali teks berubah
            PerformSearch();
        }

        private void PerformSearch()
        {
            // Query search data
            DataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, qty, total, t_transaksi.id_barang, nama_barang, harga " +
                "FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang " +
                "WHERE t_transaksi.id_barang LIKE '%" + tbCariData.Text + "%' " +
                "OR nama_barang LIKE '%" + tbCariData.Text + "%'");
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Nilai nilai = new Nilai();
                nilai.Delete(id_transaksi);
                ResetForm();
                Tampil();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
