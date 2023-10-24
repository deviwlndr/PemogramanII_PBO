using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220054
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kucing kucing = new Kucing("Muezza", "Putih", "Angora");
            Kucing kitten = new Kitten("Whiskers", "Coklat", "Maine Coon", 3);

            kucing.InfoKucing();
            kitten.InfoKucing();
        }
    }
    
    
    
}


