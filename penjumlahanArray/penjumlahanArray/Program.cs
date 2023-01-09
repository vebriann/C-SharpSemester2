using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace penjumlahanArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrik1 = new int[2, 2];
            int[,] matrik2 = new int[2, 2];
            int[,] hasil = new int[2, 2];
            int x, y;
            Console.Clear();

            // input matrik 1 
            Console.WriteLine("Input matriks 1");
            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    Console.Write($"Input nilai matriks [{a}] [{b}] : ");
                    matrik1[a, b] = int.Parse(Console.ReadLine());
                }
            }

            // input matrik 2 
            Console.WriteLine();
            Console.WriteLine("Input matriks 2");
            for (int c = 0; c < 2; c++)
            {
                for (int d = 0; d < 2; d++)
                {
                    Console.Write($"Input nilai matriks [{c}] [{d}] : ");
                    matrik2[c, d] = int.Parse(Console.ReadLine());
                }
            }

            // cetak matriks 1
            Console.WriteLine();
            for (x = 0; x < 2; x++)
            {
                for (y = 0; y < 2; y++)
                {
                    Console.Write($"Cetak Matriks 1 Baris [{x}] column [{y}] bernilai {matrik1[x, y]}");
                    Console.WriteLine();
                }
            }

            // cetak matriks 2
            Console.WriteLine();
            for (x = 0; x < 2; x++)
            {
                for (y = 0; y < 2; y++)
                {
                    Console.Write($"Cetak Matriks 2 Baris [{x}] column [{y}] bernilai {matrik2[x, y]} ");
                    Console.WriteLine();
                }
            }



            // hasil perhitungan
            Console.WriteLine();
            Console.Write("==== Hasil Penjumlahan matriks ====");
            Console.WriteLine();

            // proses penjumlahan
            for (x = 0; x < 2; x++)
            {
                for (y = 0; y < 2; y++)
                {
                    hasil[x, y] = matrik1[x, y] + matrik2[x, y];
                }
            }

            // output hasil
            for (x = 0; x < 2; x++)
            {
                for (y = 0; y < 2; y++)
                {
                    Console.Write($"Hasil= {hasil[x, y]} ");
                }
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}