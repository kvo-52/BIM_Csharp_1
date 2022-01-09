using lab17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ЗАДАНИЕ 17. ОБОБЩЕННЫЕ ТИПЫ (GENERICS)
            Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
            Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета.
            Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
            Создать несколько экземпляров класса, параметризированного различными типами.
            Заполнить его поля и вывести информацию об экземпляре класса на печать.
            */
            Console.WriteLine("Выберите тип номера счёта\nНажмите клавишу <Enter> - если номер счета цифровой\nНажмите любую клавишу - если номер счета буквенно-цифровой");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Введите номер счета:");
                long newNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Введите баланс:");
                decimal balance = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Введите ФИО владельца:");
                string owner = Convert.ToString(Console.ReadLine());
                lab17.Account<long> accInt = new lab17.Account<long>(newNumber, balance, owner);
                Print<long>(newNumber, balance, owner);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Введите номер счета:");
                string newNumber = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите баланс:");
                decimal balance = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Введите ФИО владельца:");
                string owner = Convert.ToString(Console.ReadLine());
                Account<string> accInt = new Account<string>(newNumber, balance, owner);
                Print<string>(newNumber, balance, owner);
            }
            Console.ReadKey();
        }
        static void Print<T>(T newNumber, decimal balance, string owner)
        {
            Console.Clear();
            Console.WriteLine($"Здраствуйте {owner}, на Вашем счете №{newNumber}: {balance} $");
        }
    }
}