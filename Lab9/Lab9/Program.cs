using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 9.1. Калькулятор
            Console.WriteLine("Вас приветствует калькулятор!");
            int x = UserInput("Введите первое целое число. X=");
            int y = UserInput("Введите второе целое число. Y=");
            Console.WriteLine("Введите код операции:");
            Console.WriteLine("    1 - сложение\n    2 - вычитание\n    3 - произведение\n    4 - частное");
            Console.Write("Ваш выбор: ");
            string oper = Console.ReadLine();
            switch (oper)
            {
                case "1":
                    try
                    {
                        Console.WriteLine($"{x} + {y} = {x + y}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "2":
                    try
                    {
                        Console.WriteLine($"{x} - {y} = {x - y}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "3":
                    try
                    {
                        Console.WriteLine($"{x} * {y} = {x * y}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "4":
                    try
                    {
                        if (y == 0)
                        {
                            Console.WriteLine($"{x} / {y} = {x / y}");
                        }
                        double x1 = Convert.ToDouble(x);
                        double y1 = Convert.ToDouble(y);
                        Console.WriteLine($"{x1} / {y1} = {x1 / y1}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Деление на 0!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Нет операции с указанным номером");
                    break;
            }
            Console.ReadKey();
        }
        static int UserInput(string num)
        {
            Console.Write(num);
            int res = 1;
            try
            {
                res = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Неверный формат.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
            return res;

        }
    }
}
