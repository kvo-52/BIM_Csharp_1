using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
        /* ЗАДАНИЕ 15. ИНТЕРФЕЙСЫ
          Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
            метод void setStart(int x) - устанавливает начальное значение
            метод int getNext() - возвращает следующее число ряда
            метод void reset() - выполняет сброс к начальному значению
          Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
          В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.*/

        m1:
            Console.WriteLine("Введите начальное значение прогрессии:");
            int startValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите шаг арифметической прогрессии:");
            int stepValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите шаг геометрической прогрессии:");
            int denomValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите количество членов прогрессий:");
            int number = Convert.ToInt32(Console.ReadLine());
            ArithProgression ap = new ArithProgression(startValue, stepValue);
            GeomProgression gp = new GeomProgression(startValue, denomValue);
            Console.WriteLine("\nАрифметическая прогрессия:\n");
            Console.Write($"\t{startValue} ");
            for (int i = 0; i < number - 1; i++)
            {
                Console.Write($"\t{ap.getNext()} ");
            }
            Console.WriteLine();
            Console.WriteLine("\nГеометрическая прогрессия:\n");
            Console.Write($"\t{startValue} ");
            for (int i = 0; i < number - 1; i++)
            {
                Console.Write($"\t{gp.getNext()} ");
            }
            Console.WriteLine("\n\nНажмите <Enter>, если хотите сбросить результат и начать заново\nДля выхода, нажмите любую клавишу...");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}