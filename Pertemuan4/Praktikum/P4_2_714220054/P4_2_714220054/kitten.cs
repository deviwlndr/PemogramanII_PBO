using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220054
{   // Ini adalah kelas turunan "Kitten" yang mewarisi dari kelas "Kucing".
    public class Kitten : Kucing
    {
        // Properti Umur
        public int Umur { get; set; }

        // Constructor "Kitten" digunakan untuk menginisialisasi objek "Kitten" dengan parameter tambahan (Umur).
        public Kitten(string nama, string warna, string ras, int umur) : base(nama, warna, ras)
        {
            Umur = umur;
        }

        //polymorphism
        // Ini adalah metode "InfoKucing" yang dioverride dari kelas dasar "Kucing" dan akan digunakan untuk menampilkan informasi tentang kitten.
        public override void InfoKucing()
        {
            Console.WriteLine("Ini adalah kitten:");
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Warna: {Warna}");
            Console.WriteLine($"Ras: {Ras}");
            Console.WriteLine($"Umur: {Umur} bulan");
        }
    }


}
