using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220054
    //field dan property
{   // Ini adalah kelas dasar "Kucing" yang memiliki tiga properti:
    public class Kucing
    {
        // Properti Nama
        public string Nama { get; set; }
        // Properti Warna
        public string Warna { get; set; }
        // Properti Ras
        public string Ras { get; set; }

        // Constructor "Kucing" digunakan untuk menginisialisasi objek "Kucing" dengan tiga parameter.
        public Kucing(string nama, string warna, string ras)
        {
            Nama = nama;
            Warna = warna;
            Ras = ras;
        }

        // Ini adalah metode "InfoKucing" yang akan digunakan untuk menampilkan informasi tentang kucing.
        public virtual void InfoKucing()
        {
            Console.WriteLine("Ini adalah kucing:");
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Warna: {Warna}");
            Console.WriteLine($"Ras: {Ras}");
        }
    }


}