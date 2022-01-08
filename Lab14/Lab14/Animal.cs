using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.Write($"\nПривет, меня зовут {Name}, ");
            Say();
        }
    }
    class Cat : Animal
    {
        string name;
        public Cat(string name)
            : base(name)
        {

        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void Say()
        {
            Console.Write("Мяу!");
        }
    }
    class Dog : Animal
    {
        string name;
        public Dog(string name)
            : base(name)
        {

        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void Say()
        {
            Console.Write("Гав!");
        }
    }
}
