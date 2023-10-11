using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714220054
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Masukan Nilai N:");
            Console.ReadLine();
            Console.Write("ANAK AYAM TURUN: ");
           
            

            int jumlahAyam = Convert.ToInt32(Console.ReadLine()); // Jumlah awal anak ayam
            if (jumlahAyam < 0 || jumlahAyam >= 11)
            {
                Console.WriteLine("Nilat tidak dapat kurang dari 0 dan lebih dari 10");
            }
            else 
            {
                for (int turun = jumlahAyam; turun <= 10; turun--)
                {
                    if (turun > 1)
                    {
                        Console.WriteLine("Anak ayam turun   {0}, mati satu tinggal {1}", turun, turun - 1);
                    }
                    else if (turun == 1)
                    {
                        Console.WriteLine("Anak ayam turun {0}, mati satu tinggal INDUKNYA", turun);
                    }
             }
                
                
            }
            /*do
            {


                Console.Clear();
                Console.WriteLine("ANAK AYAM TURUN ");
                
                    int turun = Convert.ToInt32(Console.ReadLine());

                    int[] grade = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };



                    if (turun == 10)
                        
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah {1}", turun, grade[1]);
                    }
                    else if (turun == 9)
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah {1}", turun, grade[2]);
                    }
                    else if (turun == 8)
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah {1}", turun, grade[3]);
                    }
                    else if (turun == 7)
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah {1}", turun, grade[4]);
                    }
                    else if (turun == 6)
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah {1}", turun, grade[5]);
                    }
                    else if (turun == 5)
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah {1}", turun, grade[6]);
                    }
                    else if (turun == 4)
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah {1}", turun, grade[7]);
                    }
                    else if (turun == 3)
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah {1}", turun, grade[8]);
                    }
                    else if (turun == 2)
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah {1}", turun, grade[9]);
                    }
                    else if (turun > 0 && turun < 10)
                    {
                        Console.WriteLine("Nilai tidak boleh dibawah 0 atau diatas 10");
                    }
                    else
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggalah induknya", turun);
                    }
                    Console.WriteLine("\nIngin mengulang kembali (Y/T)?"); 
    
                }
            
                
            
            while (Console.ReadLine() == "Y"); 
            
        */
        }
    }
}
