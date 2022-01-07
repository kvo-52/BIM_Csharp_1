using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну окружности");
            int L=Convert.ToInt32(Console.ReadLine());
            double R = L / (2 * 3.14);
            double S = 2 * 3.14 * R*R;
            Console.WriteLine("Радиус окружности={0}",R);
            Console.WriteLine("Площадь окружности={0}", S);
            Console.WriteLine("Для завершения нажмити любую клавишу");
            Console.ReadKey();                       
                }
    }
}
