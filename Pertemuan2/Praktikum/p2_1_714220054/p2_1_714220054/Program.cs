using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_1_714220054
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Masukkan angka pertama:");
            float angka1 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Masukkan angka pertama:");
            float angka2 = Convert.ToInt32(Console.ReadLine());

            float penjumlahan;
            float pengurangan;
            float perkalian;
            float pembagian;

            penjumlahan = angka1 + angka2;
            pengurangan = angka1 - angka2;
            perkalian = angka1 * angka2;
            pembagian = angka1 / angka2;
            
            
            Console.WriteLine("{0} + {1} = {2}", angka1, angka2, penjumlahan);
            Console.WriteLine("{0} - {1} = {2}", angka1, angka2, pengurangan);
            Console.WriteLine("{0} * {1} = {2}", angka1, angka2, perkalian);
            Console.WriteLine("{0} / {1} = {2}", angka1, angka2, pembagian);
            
        }
    }
}
