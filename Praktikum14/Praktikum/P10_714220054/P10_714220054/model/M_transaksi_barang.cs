using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_714220054.model
{
    class M_transaksi_barang
    {
        string id_barang, qyt, total;

        public M_transaksi_barang() 
        {
            
        }

        public M_transaksi_barang(string id_barang, string qyt, string total)
        {
            this.Id_barang = id_barang;
            this.Qyt = qyt;
            this.Total = total;
        }

        public string Id_barang { get => id_barang; set => id_barang = value; }
        public string Qyt { get => qyt; set => qyt = value; }
        public string Total { get => total; set => total = value; }
    }
}
