using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace latihanArrayDimensi1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nama = new string[5];
            Console.WriteLine("Masukan 5 nama teman terdekat anda ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Masukan Nama Index Ke {i+1} : ");
                // ada sebuah variabel bernama nama[i] fungsi nama adalah sebagai variabel penampung array
                // fungsi i sebagai index untuk menyimpan data pada array
                // contohnya adalah inputan 1 berindex 2 maka di dalam nama harus di isi 2 contohnya nama[2]
                nama[i] = Console.ReadLine();
                

            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Teman Terdekat Anda Ke {i+1} Bernama {nama[i]}");
            } 
            Console.ReadLine();

        }
    }
}