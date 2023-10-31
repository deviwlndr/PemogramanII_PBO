using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_714220031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.WriteLine("Menu Pilihan:");
                Console.WriteLine("1. Hitung Luas Persegi Panjang");
                Console.WriteLine("2. Hitung Keliling Persegi Panjang");

                Console.Write("Menu Pilihan : ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    // Menghitung Luas Persegi Panjang
                    Console.Write("Masukkan panjang: ");
                    double panjang = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Masukkan lebar: ");
                    double lebar = Convert.ToDouble(Console.ReadLine());

                    double luas = panjang * lebar;
                    Console.WriteLine($"Luas Persegi Panjang: {luas}");
                }

                else if (input == "2")
                {
                    // Menghitung Keliling Persegi Panjang
                    Console.Write("Masukkan panjang: ");
                    double panjang = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Masukkan lebar: ");
                    double lebar = Convert.ToDouble(Console.ReadLine());

                    double keliling = 2 * (panjang + lebar);
                    Console.WriteLine($"Keliling Persegi Panjang: {keliling}");
                }
                else
                {
                    Console.WriteLine("Menu tidak tersedia");
                }

                Console.Write("\nIngin mengulang kembali (Y/T)? ");
            }

            while (Console.ReadLine() == "Y");
        }
    }
}
