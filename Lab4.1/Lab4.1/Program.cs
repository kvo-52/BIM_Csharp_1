using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание 4 "Алгоритмы с циклами"
// Часть 1. Задача 1. Квадратный корень числа
// Вводим переменную до тела цикла
            int number;
            // Вводим число, проверяем, что ввели число
            while (true)
            {
                Console.WriteLine();
                Console.Write("Введите любое число:  ");
                string text = Console.ReadLine();
                if (int.TryParse(text, out number))
                {
                    Console.WriteLine();
                    Console.WriteLine("Вы ввели значение {0}", number);
                    Console.WriteLine();
                    break;
                }
                Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
            }
            // Вводим счетчик итерации и переменную для суммы, присваиваем им нулевые значения
            number = Math.Abs(number);
            int sumN2 = 0;
            int numN = 0;
            // Организовываем цикл. Для получения нечетного ряда ставим начальное значние счетчика 1, изменение счетчика равное 2
            for (int i = 1; i < (2 * number); i += 2)
            {
                numN += 1;
                sumN2 += i;
                Console.WriteLine("Квадрат числа {1} равен {0}", sumN2, numN);
            }
              Console.WriteLine();
            // Завершение программы
            Console.Write("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
