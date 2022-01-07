using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание 7.2. Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
            Console.WriteLine();
            // Вводим сторону куба x
            Console.Write("Введите сторону куба x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            // Вводим переменные для объема и площади
            double V, S;
            // Считаем объем и площадь куба при помощи метода
            GetVS(x, out V, out S);
            Console.WriteLine();
            // Выводим результат
            Console.WriteLine("Объем куба со стороной {1} равен {0:0,0}", V, x);
            Console.WriteLine("Площадь сторон куба со стороной {1} равна {0:0,0}", S, x);
            Console.WriteLine();
            Console.Write("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
        }

        private static void GetVS(int a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = 6 * Math.Pow(a, 2);
        }
    }
}
