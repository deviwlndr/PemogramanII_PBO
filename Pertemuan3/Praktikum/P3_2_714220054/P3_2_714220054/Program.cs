using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714220031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Nilai N :");
            int N = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ANAK AYAM TURUN " + N);

            if (N <= 0 || N > 10)
            {
                Console.WriteLine("Nilai tidak boleh dibawah 0 atau diatas 10");
            }
            else
            {
                for (int i = N; i >= 1; i--)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("Anak ayam turun 1, mati satu tinggallah induknya");
                    }
                    else
                    {
                        Console.WriteLine($"Anak ayam turunlah {i}, mati satu tinggallah {i - 1}");
                    }
                }
            }
        }
    }
}