using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Домашнее задание  6.1 Ввести с клавиатуры предложение.
           // Предложение представляет собой слова, разделенные пробелом.
          // Знаки препинания не используются.Найти самое длинное слово в строке.
            Console.WriteLine();
            // Вводим фразу с клавиатуры
            string stringStart = Console.ReadLine();
            Console.WriteLine();
            // Разбиваем фразу на слова. Считаем количество слов в предложении
            // Создаем массив из длин слов и находим самое длинное слово
            string[] stingArray = stringStart.Split();
            int SumWord = 0;
            int[] arrayLength = new int[SumWord];
            int max = 0;
            int slovo = 0;    
            
            foreach (string s in stingArray)
            {    
                SumWord++;
               
                int n = Convert.ToInt32(s.Length);
                if (n > max || n==max )
                    max = n;
               Console.Write("{0} ", s);
               
             }
            Console.Write("Самое длинное слово: ", slovo);
            Console.WriteLine();
            Console.WriteLine("Количество знаков в самом длинном слове равно {0}", max);
            Console.WriteLine();
            Console.WriteLine("Количество слов в предложении равно {0}", SumWord);
            Console.WriteLine();
            Console.Write("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
