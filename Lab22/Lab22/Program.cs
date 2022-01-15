using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab22
{
	class Program
	{
		/*ЗАДАНИЕ 22. ПАРАЛЛЕЛЬНОЕ ПРОГРАММИРОВАНИЕ И БИБЛИОТЕКА TPL
			Сформировать массив случайных целых чисел (размер задается пользователем).
			Вычислить сумму чисел массива и максимальное число в массиве.
			Реализовать решение задачи с использованием механизма задач продолжения.
			*/
		static void Main()
		{
			Console.WriteLine("Введите количество элементов массива:\t");
			int elCount = Convert.ToInt32(Console.ReadLine());
			int[] array = new int[elCount];
			Random rnd = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rnd.Next(0, 50);
			}
			Console.WriteLine("\nЭлементы массива:\n");
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i]}|");
			}
			Func<int> func1 = new Func<int>(() => Sum(array));
			Task<int> task1 = new Task<int>(func1);


			Action<Task, object> actionTask = new Action<Task, object>(Max);
			Task task2 = task1.ContinueWith(actionTask, array);
			task1.Start();
			Console.WriteLine($"\n\tСумма чисел в массиве равна: {task1.Result}");
			//Console.WriteLine("\nМетод Main - закончил работать");
			Console.ReadLine();
		}
		static int Sum(int[] array)
		{
			//Console.WriteLine("\n\nМетод Sum - начал работать");
			int sum = 0;
			foreach (int a in array)
			{
				sum += a;
			}
			//Console.WriteLine("\nМетод Sum - закончил работать");
			return sum;
		}
		static void Max(Task task, object a)
		{
			//Console.WriteLine("\nМетод Max - начал работать");
			int[] array = (int[])a;
			int max = array[0];
			foreach (int x in array)
			{
				if (x > max)
					max = x;
			}
			Console.WriteLine($"\n\tМаксимальное число в массиве равно: {max}");
			//Console.WriteLine("\nМетод Max - закончил работать");
		}
	}
}
