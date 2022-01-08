using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ЗАДАНИЕ 14. АБСТРАКТНЫЕ КЛАССЫ
              Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:
                абстрактное свойство - название животного.
                В классе Animal нужно определить следующие методы:
                конструктор, устанавливающий значение по умолчанию для названия;
                абстрактный метод Say(), который выводит звук, который издает животное;
                неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
              Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:
                свойство – название животного;
                метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.
                Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.*/

            Console.WriteLine("Введите имя кошки:");
            string catName = Console.ReadLine();
            Console.WriteLine("\nВведите имя собаки:");
            string dogName = Console.ReadLine();
            Cat cat = new Cat(catName);
            cat.ShowInfo();
            Dog dog = new Dog(dogName);
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
   
   
}