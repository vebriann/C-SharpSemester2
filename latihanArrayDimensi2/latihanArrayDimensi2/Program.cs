using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace latihanArrayDimensi2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 2];

            Console.Clear();
            Console.WriteLine("Belajar array dimensi 2 dengan inputan");
            Console.WriteLine("Menggunakan methode row mayor order \n");
            Console.WriteLine("Input matriks: ");

            // looping untuk inputan matriks
            for (int i =0; i < 2; i++)
            {
                for (int j =0; j < 2; j++)
                {
                Console.Write($"Input Array [{i}][{j}] : ");
                array[i,j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Output Matriks");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Array [{i}][{j}] Bernilai : {array[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}