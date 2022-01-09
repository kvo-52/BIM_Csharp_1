using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 5.5. Двумерный массив. 1 и 0
            Console.WriteLine("Введите количество элементов массива N:\t");
            int Count = int.Parse(Console.ReadLine());
            int[,] array = new int[Count, Count];
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count; j++)
                {
                    array[i, j] = 1 - (i + j) % 2;
                }
            }
            Console.WriteLine("\nЭлементы массива:\n");
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count; j++)
                {
                    Console.Write("{0, 4} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}