using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            // Домашнее задание к занятию 3 "Алгоритмы с ветвлением"
            // Задача 3. Определяем  возраст в годах
            //
            Console.WriteLine();
            // Ввод возраста
            Console.Write("Введите возраст от 20 до 69    ");
            int age = Convert.ToInt32(Console.ReadLine());
            // Проверка корректности ввода
            for (; age < 20 || age > 69;)
            {
                Console.WriteLine("Чило выходит за рамки диапазона {0}:", age);
                Console.Write("Введите корректный возраст от 20 до 69   ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            // Определяем количество десятков
            int des = age / 10;
            // Определяем как прописывать десятки
            switch (des)
            {
                case 2:
                    {
                        Console.Write("двадцать ");
                        break;
                    }
                case 3:
                    {
                        Console.Write("тридцать ");
                        break;
                    }
                case 4:
                    {
                        Console.Write("сорок ");
                        break;
                    }
                case 5:
                    {
                        Console.Write("пятьдесят ");
                        break;
                    }
                case 6:
                    {
                        Console.Write("шестьдесят ");
                        break;
                    }
                default:
                    {
                        Console.Write("");
                        break;
                    }
            }
            // Определяем количество едениц
            int edin = age - 10 * des;
            // Определяем как прописывать еденицы
            switch (edin)
            {
                case 1:
                    {
                        Console.Write("один ");
                        break;
                    }
                case 2:
                    {
                        Console.Write("два ");
                        break;
                    }
                case 3:
                    {
                        Console.Write("три ");
                        break;
                    }
                case 4:
                    {
                        Console.Write("четыре ");
                        break;
                    }
                case 5:
                    {
                        Console.Write("пять ");
                        break;
                    }
                case 6:
                    {
                        Console.Write("шесть ");
                        break;
                    }
                case 7:
                    {
                        Console.Write("семь ");
                        break;
                    }
                case 8:
                    {
                        Console.Write("восемь ");
                        break;
                    }
                case 9:
                    {
                        Console.Write("девять ");
                        break;
                    }
                default:
                    {
                        Console.Write("");
                        break;
                    }
            }
            // Определяем окончания
            if (edin == 1)
                Console.Write("год");
            if (((edin) >= 2) && (edin) <= 4)
                Console.Write("года");
            if (((edin) == 0) || ((edin) >= 5) && ((edin) <= 9))
                Console.Write("лет");
            Console.WriteLine();
            Console.WriteLine();
            // Завершение программы
            Console.Write("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
