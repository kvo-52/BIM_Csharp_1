using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"I:\BIM\HomeWork";
            string[] dirs = Directory.GetDirectories(path);
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
                string[] dirs1 = Directory.GetDirectories(s);
                foreach (string s1 in dirs1)
                {
                    Console.WriteLine("\t" + s1);
                }
                string[] files1 = Directory.GetFiles(s);
                Console.WriteLine();
                foreach (string sf1 in files1)
                {
                    Console.WriteLine("\t" + sf1);
                }
            }
            Console.ReadKey();
        }
    }
}
