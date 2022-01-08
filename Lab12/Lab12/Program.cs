using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача 12. Статические классы
              Разработать статический класс для работы с окружностью. 
              Класс должен содержать 3 метода:
              метод, определяющий длину окружности по заданному радиусу;
              метод, определяющий площадь круга по заданному радиусу;
              метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.*/
            Console.WriteLine("Введите радиуc окружности:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите значение координаты X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите значение координаты Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Circle.Length(radius);
            Circle.Square(radius);
            Circle.Point(x, y, radius);
            Console.ReadKey();
        }
    }
    
}