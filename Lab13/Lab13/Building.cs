using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Building
    {
        public string Adress { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Building(string adress, double length, double width, double height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine($"Адрес: {Adress}\nДлина: {Length}\nШирина: {Width}\nВысота: {Height}");
        }
    }
    sealed class MultiBuilding : Building
    {
        public int NumberOfFloors { get; set; }

        public MultiBuilding(string adress, double length, double width, double height, int numberOfFloors)
            : base(adress, length, width, height)
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
