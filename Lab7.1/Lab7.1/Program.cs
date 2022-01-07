using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
// Домашнее задание  7.1 Два треугольника заданы длинами своих сторон.
// Определить, площадь какого из них больше
// (создать метод для вычисления  площади  треугольника по длинам его сторон).
// Для решения задачи можно использовать формулу Герона.
//
Console.WriteLine();
            int N = 2;                // количество проверяемых треугольников
            int[] a = new int[N];     // массив сторон а   
            int[] b = new int[N];     // массив сторон b
            int[] c = new int[N];     // массив сторон с
                                      // Ввод значений с клавиатуры
                                      // Предполагается, что стороны a, b, c образуют треугольник
            for (int i = 0; i < N; i++)
            {
                Console.Write("Введите сторону a треугольника {0}, a{0}:  ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите сторону b треугольника {0}, b{0}:  ", i + 1);
                b[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите сторону c треугольника {0}, c{0}:  ", i + 1);
                c[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            // Вводим массив S для значений
            double[] S = new double[N];
            // Вводим счетчики
            double maxS = 0;               // для максимальнной площади треугольника
                                           // Вычисляем площадь каждого треугольника, выбираем большую
            for (int i = 0; i < N; i++)
            {
                GetS(a[i], b[i], c[i], out S[i]);
                if (S[i] > maxS)
                {
                    Console.WriteLine("Площадь треугольника {1} равняется {0:f2}", S[i], i + 1);
                    maxS = S[i];
                }
                else
                {
                    Console.WriteLine("Треугольник {0} не треугольник", i + 1);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Максимальная площадь треугольника равняется {0:f}", maxS);
            Console.WriteLine();
            Console.Write("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
        }

        private static void GetS(int a, int b, int c, out double S)
        {
            int p = (a + b + c) / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
