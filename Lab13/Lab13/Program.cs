using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
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
            string address = Console.ReadLine();
            Console.Write("Длина: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ширина: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Высота: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Количество этажей: ");
            int numberOfFloors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Building b = new Building(address, length, width, height);
            Console.Write("Вывод данных класса Building: \n");
            b.Print();
            Console.WriteLine();

            MultiBuilding mb = new MultiBuilding(address, length, width, height, numberOfFloors);
            Console.Write("Вывод данных класса MultiBuilding: \n");
            mb.Print();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine($"Адрес: {Address}\nДлина: {Length}\nШирина: {Width}\nВысота: {Height}");
        }
    }
    sealed class MultiBuilding : Building
    {
        public int NumberOfFloors { get; set; }

        public MultiBuilding(string address, double length, double width, double height, int numberOfFloors)
            : base(address, length, width, height)
        {
            NumberOfFloors = numberOfFloors;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"Количество этажей: {NumberOfFloors}");
        }
    }
}