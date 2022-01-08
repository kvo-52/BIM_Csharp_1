using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class Circle
    {
        public static double len;
        public static double sq;

        public static void Length(double radius)
        {
            len = 2 * Math.PI * radius;
            Console.WriteLine("Длина окружности L = {0:00}", len);
        }
        public static void Square(double radius)
        {
            sq = Math.PI * radius * radius;
            Console.WriteLine("Площадь круга S = {0:00}", sq);
        }
        public static void Point(double x, double y, double radius)
        {
            if (radius >= Math.Sqrt(x * x + y * y))
            {
                Console.WriteLine("Точка находится внутри круга");
            }
            else
            {
                Console.WriteLine("Точка находится за пределами круга");
            }
        }
    }
}
