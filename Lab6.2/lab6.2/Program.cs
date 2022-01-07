using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
 // Домашнее задание 6.2. Ввести с клавиатуры предложение.
// Предложение представляет собой слова, разделенные пробелом.
// Знаки препинания не используются.
// Составить программу, определяющую является ли строка палиндромом
// без учёта пробелов и регистра
// (пример палиндрома – «А роза упала на лапу Азора»).
//
            Console.WriteLine();
            // Вводим с клавиатуры фразу
            string stringStart = Console.ReadLine();
            // Понижаем регистр
            stringStart = stringStart.ToLower();
            // Разбиваем фразу на слова
            string[] stingArray = stringStart.Split();
            // Сшиваем слова в фразу для удаление пробелов
            string bigStrok = "";
            string probel = " ";
            foreach (string s in stingArray)
            {
                if (s != probel)
                {
                    bigStrok += s;
                }
            }
            // Разбиваем на буквы и переворачиваем
            char[] charArray = bigStrok.ToArray();
            char[] antiArray = new char[charArray.Length];
            int n = Convert.ToInt32(bigStrok.Length);
            for (int i = 0; i < n; i++)
            {
                int j = n - i - 1;
                antiArray[i] = charArray[j];
            }
            Console.WriteLine();
            // сравниваем два слова
            for (int i = 0; i < n; i++)
            {
                if (charArray[i] != antiArray[i])
                {
                    Console.WriteLine("Это не палиндром");
                    break;
                }
                else
                {
                    Console.WriteLine("Это палиндром. Бинго!)");
                    break;
                }
            }
            Console.WriteLine();
            Console.Write("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
