using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 8.2. Сумма случайных чисел во вновь созданном файле
            string path = "I:/BIM/HomeWork/Lab8.2/Task_8-2.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            StreamWriter sw = new StreamWriter(path);
            int[] number = new int[10];
            Random random = new Random();
            foreach (int a in number)
            {
                sw.WriteLine("{0} ", random.Next(0, 10));
            }
            sw.Close();


            int[] sum = File.ReadAllLines(path).Select(int.Parse).ToArray();
            int sum1 = sum.Sum();


            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine(sum1);

            Console.ReadKey();

        }
    }
}
