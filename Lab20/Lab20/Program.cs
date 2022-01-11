using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab20
{
	class Program
	{
		delegate double Circle(double r);
		static void Main(string[] args)
		{
			/*ЗАДАНИЕ 20. ДЕЛЕГАТЫ, СОБЫТИЯ, ЛЯМБДЫ
			В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
			-       метод получает входным параметром переменную типа double;
			-       метод возвращает значение типа double, которое является результатом вычисления.
			Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
			-       длину окружности по формуле D = 2 * π* R;
			-       площадь круга по формуле S = π* R²;
			-       объем шара. Формула V = 4/3 * π * R³.
			Методы должны быть объявлены как статические.
			*/
			Console.WriteLine("Введите радиус окружности:");
			double radius = Convert.ToDouble(Console.ReadLine());
			Console.Clear();
			Console.WriteLine($"При радиусе окружности R={radius}:");
			Circle circle = new Circle(Length);
			circle += Area;
			circle += Volume;
			circle?.Invoke(radius);
			Console.ReadKey();
		}
		static double Length(double radius)
		{
			double length = 2 * Math.PI * radius;
			Console.WriteLine($"\nДлина окружности L={String.Format("{0:f}", length)};");
			return length;
		}
		static double Area(double radius)
		{
			double area = Math.PI * radius * radius;
			Console.WriteLine($"\nПлощадь круга S={String.Format("{0:f}", area)};");
			return area;
		}
		static double Volume(double radius)
		{
			double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
			Console.WriteLine($"\nОбъём шара V={String.Format("{0:f}", volume)}.");
			return volume;
		}
	}
}
