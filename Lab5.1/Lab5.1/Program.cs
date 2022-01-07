using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание  5.1 "Массивы"
            // Задача 1. Среднеарифметическое одномерного масссива из 7 элементов.
            Console.WriteLine();
            // Ввод констнаты с размерностью массива
            const int n = 7;
            // Ввод переменной для вычисления суммы значений и вывода порядкового номера элемента
            float S = 0;
            int k = 0;
            // Создание одноменого массива из n элементов
            int[] arrayA = new int[n];
            // Заполнение массива с клавиатуры
            foreach (int a in arrayA)
            {
                k += 1;
                Console.Write("Введите значение {0} ", k);
                int i = Convert.ToInt32(Console.ReadLine());
                S += i;
            }
            // Вывод на экран среднего арифмитического элементов
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое значение {0,4:f2}", S / n);
            Console.WriteLine();
            Console.Write("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
