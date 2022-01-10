using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab19
{
	class Computer
	{
		public int Id { get; set; }
		public string Mark { get; set; }
		public string Type { get; set; }
		public int Fr { get; set; }
		public int RAM { get; set; }
		public int HDD { get; set; }
		public int Video { get; set; }
		public decimal Price { get; set; }
		public int Stock { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			/*ЗАДАНИЕ 19. LINQ
			Модель компьютера характеризуется кодом и названием марки компьютера, типом процессора, частотой работы процессора,
			объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров,
			имеющихся в наличии. Создать список, содержащий 6-10 записей с различным набором значений характеристик.
			Определить:
			- все компьютеры с указанным процессором. Название процессора запросить у пользователя;
			- все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
			- вывести весь список, отсортированный по увеличению стоимости;
			- вывести весь список, сгруппированный по типу процессора;
			- найти самый дорогой и самый бюджетный компьютер;
			- есть ли хотя бы один компьютер в количестве не менее 30 штук?
			*/
			List<Computer> listComps = new List<Computer>()
				{
					new Computer(){ Id=1, Mark="Acer", Type="Intel Core i7", Fr=4100, RAM=64, HDD=2000, Video=12, Price=75000, Stock=12},
					new Computer(){ Id=2, Mark="HP", Type="AMD Ryzen", Fr=3000, RAM=16, HDD=1000, Video=4, Price=35000, Stock=23},
					new Computer(){ Id=3, Mark="HP", Type="AMD Ryzen", Fr=3500, RAM=32, HDD=1500, Video=8, Price=55000, Stock=14},
					new Computer(){ Id=4, Mark="Lenovo", Type="AMD Athlon", Fr=2700, RAM=16, HDD=500, Video=4, Price=37000, Stock=16},
					new Computer(){ Id=5, Mark="Lenovo", Type="AMD Athlon", Fr=3200, RAM=32, HDD=750, Video=8, Price=42000, Stock=30},
					new Computer(){ Id=6, Mark="DELL", Type="Intel Core i5", Fr=2500, RAM=16, HDD=1000, Video=12, Price=38000, Stock=7},
					new Computer(){ Id=7, Mark="DELL", Type="Intel Core i5", Fr=3100, RAM=16, HDD=1000, Video=8, Price=34000, Stock=22},
					new Computer(){ Id=8, Mark="ASUS", Type="Intel Core i7", Fr=3600, RAM=32, HDD=1500, Video=16, Price=39000, Stock=6},
					new Computer(){ Id=9, Mark="ASUS", Type="Intel Core i5", Fr=2800, RAM=32, HDD=1000, Video=8, Price=36000, Stock=5},
					new Computer(){ Id=10, Mark="ASUS", Type="Intel Core i7", Fr=3800, RAM=64, HDD=2000, Video=16, Price=120000, Stock=2},
				};


			Console.WriteLine("Введите характеристики компьютера:");

			Console.WriteLine("Название процессора (AMD Ryzen, AMD Athlon, Intel Core i5, Intel Core i7):");
			string type = Console.ReadLine();
			List<Computer> comps = listComps
				.Where(c => c.Type == type)
				.ToList();
			Console.WriteLine();
			foreach (Computer c in comps)
				Console.WriteLine($"{c.Id} {c.Mark} {c.Type} {c.Fr} {c.RAM} {c.HDD} {c.Video} {c.Price} {c.Stock}");
			Console.ReadKey();


			Console.Clear();
			Console.WriteLine("Объём ОЗУ, Гб:");
			int ram = Convert.ToInt32(Console.ReadLine());
			List<Computer> comps2 = listComps
				.Where(c => c.RAM >= ram)
				.ToList();
			Console.WriteLine();
			foreach (Computer c in comps2)
				Console.WriteLine($"{c.Id} {c.Mark} {c.Type} {c.Fr} {c.RAM} {c.HDD} {c.Video} {c.Price} {c.Stock}");
			Console.ReadKey();


			Console.Clear();
			Console.WriteLine("Cписок, по увеличению стоимости:");
			var compsPrice = listComps
				.OrderBy(c => c.Price)
				.ToList();
			Console.WriteLine();
			foreach (var c in compsPrice)
				Console.WriteLine($"{c.Id} {c.Mark} {c.Type} {c.Fr} {c.RAM} {c.HDD} {c.Video} {c.Price} {c.Stock}");
			Console.ReadKey();


			Console.Clear();
			Console.WriteLine("Cписок, сгруппированный по типу процессора:\n");
			var compsType = from Computer in listComps
							group Computer by Computer.Type;
			foreach (IGrouping<string, Computer> c in compsType)
			{
				Console.WriteLine(c.Key);
				foreach (var t in c)
					Console.WriteLine($"{t.Id} {t.Mark} {t.Type} {t.Fr} {t.RAM} {t.HDD} {t.Video} {t.Price} {t.Stock}");
				Console.WriteLine();
			}
			Console.ReadKey();


			Console.Clear();
			Console.WriteLine("Самый дорогой компьютер:");
			var compMax = listComps
				.Max(c => c.Price);
			Console.WriteLine(compMax);


			Console.WriteLine("\nСамый дешевый компьютер:");
			var compMin = listComps
				.Min(c => c.Price);
			Console.WriteLine(compMin);


			Console.WriteLine("\nПроверка наличия на складе компьюеторв определенной конфигурации в количестве более 30 штук:");
			bool compsStock = listComps
				.Any(c => c.Stock > 30);
			if (compsStock)
				Console.WriteLine("\nНа складе есть более 30 компьютеров, определенной конфигурации");
			else
				Console.WriteLine("\nК сожалению на складе нет такого такого количества компьютеров, определенной конфигурации");
			Console.ReadKey();
		}
	}
}
