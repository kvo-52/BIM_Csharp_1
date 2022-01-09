using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ЗАДАНИЕ 16. РАБОТА С JSON
            1.  Необходимо разработать программу для записи информации о товаре в текстовый файл в формате json.
            Разработать класс для моделирования объекта «Товар». Предусмотреть члены класса «Код товара» (целое число), «Название товара» (строка), «Цена товара» (вещественное число).
            Создать массив из 5-ти товаров, значения должны вводиться пользователем с клавиатуры.
            Сериализовать массив в json-строку, сохранить ее программно в файл «Products.json».
            2.  Необходимо разработать программу для получения информации о товаре из json-файла.
            Десериализовать файл «Products.json» из задачи 1. Определить название самого дорогого товара.
            */
            string path = "I:/BIM/HomeWork_Blok-1/Lab16/Products.json";
            string jsonStr;
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            StreamWriter sw = new StreamWriter(path);
            Product[] products = new Product[5];
            Console.WriteLine("Введите данные для 5 товаров\n");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Номер товара {i + 1}");
                Console.WriteLine($"Введите код товара:");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите название товара:");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine($"Введите цену товара:");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                Product prod = new Product(code, name, price);
                products[i] = prod;
                Console.WriteLine();
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            for (int i = 0; i < products.Length; i++)
            {
                jsonStr = JsonSerializer.Serialize(products[i], options);
                sw.Write(jsonStr);
            }
            sw.Close();
            StreamReader sr = new StreamReader(path);
            string jsonStrRead = sr.ReadToEnd();
            sr.Close();
            string str = jsonStrRead.Replace("{", "\t{");
            string[] strArr = str.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
            decimal maxPrice = 0;
            int count = 0;
            Product[] productsRead = new Product[5];
            for (int i = 0; i < strArr.Length; i++)
            {
                productsRead[i] = JsonSerializer.Deserialize<Product>(strArr[i], options);
                if (maxPrice < productsRead[i].Price)
                {
                    maxPrice = productsRead[i].Price;
                    count = i;
                }
            }
            Console.WriteLine($"{productsRead[count].Name} - самый дорогой товар");
            Console.ReadKey();
        }
    }
   }