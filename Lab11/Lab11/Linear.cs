using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
            struct Equation
        {
            public double k;
            public double b;

            public Equation(double k = 0, double b = 0)
            {
                this.k = k;
                this.b = b;
            }
            public void Root()
            {
                double x = (-b) / k;
                if (b >= 0)
                {
                    Console.WriteLine($"\nВ уравнении: {k}x + {b} = 0, x = {x}");
                }
                if (b < 0)
                {
                    Console.WriteLine($"\nВ уравнении: {k}x - {-b} = 0, x = {x}");
                }
            }
        }
    }
