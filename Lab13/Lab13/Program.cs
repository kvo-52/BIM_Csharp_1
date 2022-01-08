using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача 13. Наследование
              Задан класс Building, который описывает здание. Класс содержит следующие элементы:
                адрес здания;
                длина здания;
                ширина здания;
                высота здания.
              В классе Building нужно реализовать следующие методы:
                конструктор с 4 параметрами;
                свойства get/set для доступа к полям класса;
                метод Print(), который выводит информацию о здании.
              Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:
                конструктор с 5 параметрами – реализует вызов конструктора базового класса;
                свойство get/set доступа к внутреннему полю класса;
                метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
                Класс MultiBuilding сделать таким, что не может быть унаследован.*/

            Console.WriteLine("Введите данные по зданию:");
            Console.Write("\nАдрес: ");
            string adress = Console.ReadLine();
            Console.Write("Длина: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ширина: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Высота: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Количество этажей: ");
            int numberOfFloors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Building b = new Building(adress, length, width, height);
            Console.Write("Вывод данных  Building: \n");
            b.Print();
            Console.WriteLine();

            MultiBuilding mb = new MultiBuilding(adress, length, width, height, numberOfFloors);
            Console.Write("Вывод данных MultiBuilding: \n");
            mb.Print();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
  }