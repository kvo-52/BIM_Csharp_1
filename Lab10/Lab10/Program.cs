using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lab 10. Класс
              Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
              Реализовать класс, в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных.
              Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы.
              Создать объект на основе разработанного класса. Осуществить использование объекта в программе.*/
            Console.WriteLine("Преобразователь значения угла из градусов в радианы");
            Console.WriteLine("\n Введите значение угла в градусах:");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение угла в минутах:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение угла в секундах:");
            int sec = Convert.ToInt32(Console.ReadLine());
            Angle ang = new Angle(gradus, min, sec);
            ang.ToRadians();
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            set
            {
                if (value >= -360 && value <= 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение угла в градусах должно быть от -360, до 360 включительно");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value <= 60 && value >= -60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение угла в минутах должно быть от -60, до 60 включительно");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value <= 60 && value >= -60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение угла в секундах должно быть от -60, до 60 включительно");
                }
            }
            get
            {
                return sec;
            }
        }

        public Angle(int gradus, int min = 0, int sec = 0)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public Angle(int gradus)
        {
            Gradus = gradus;
            Min = 0;
            Sec = 0;
        }
        public void ToRadians()
        {
            double rad = Math.PI / 180 * (gradus + min / 60 + sec / 3600);
            Console.OutputEncoding = Encoding.UTF8;
            string pi = "\u03c0";
            double res = rad / Math.PI;
            double res1 = rad % Math.PI;
            if (res1 == 0)
            {
                if (res == 1)
                {
                    Console.WriteLine($"\n Угол {gradus}° {min}\' {sec}\" равен {pi} рад");
                }
                else
                {
                    Console.WriteLine($"\n Угол {gradus}° {min}\' {sec}\" равен {res}{pi} рад");
                }
            }
            else
            {
                Console.WriteLine($"\nУгол {gradus}° {min}\' {sec}\" равен {String.Format("{0:0.00}", rad / Math.PI)}{pi} рад");
            }
        }
    }
}