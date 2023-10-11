using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_714220054
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("MENU PERSEGI PANJANG");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Htiung Keliling");
                Console.Write("Menu Pilihan: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("MENGHITUNG LUAS PERSEGI PANJANG");
                    Console.Write("Masukan Panjang: ");
                    float angka1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Masukan Lebar: ");
                    float angka2 = Convert.ToInt32(Console.ReadLine());

                    float hitung_luas = angka1 * angka2;
                    Console.WriteLine("{0} * {1} = {2}", angka1, angka2, hitung_luas);
                }
                else if (input == 2)
                {
                    Console.WriteLine("MENGHITUNG KELILING PERSEGI PANJANG");
                    Console.Write("Masukan Panjang: ");
                    float angka1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Masukan Lebar: ");
                    float angka2 = Convert.ToInt32(Console.ReadLine());


                    float hitung_keliling = 2 * angka1 + 2 * angka2;
                    Console.WriteLine("(2*{0}) + (2*{1}) = {2}", angka1, angka2, hitung_keliling);
                }
                else if (input >= 3)
                {
                    Console.WriteLine("Maaf menu tidak tersedia!");
                }

                Console.Write("\nIngin mengulang kembali (Y/T)?");

            }

            while (Console.ReadLine() == "Y");
        }
    }
}
