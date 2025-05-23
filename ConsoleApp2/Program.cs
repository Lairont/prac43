using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        struct Notebook
        {
            public string Model;
            public string Brand;
            public decimal Price;

            public Notebook(string model, string brand, decimal price)
            {
                Model = model;
                Brand = brand;
                Price = price;

            }
            public void DisplayInfo()
            {
                Console.WriteLine("\nИнформация о ноутбуке:");
                Console.WriteLine($"Модель: {Model}");
                Console.WriteLine($"Производитель: {Brand}");
                Console.WriteLine($"Цена: {Price}");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите модель ноутбука: ");
            string model = Console.ReadLine();
            Console.Write("Введите производителя: ");
            string brand = Console.ReadLine();
            Console.Write("Введите цену: ");
            decimal price;

            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.Write("Ошибка! Введите числовое значение цены: ");
            }

            Notebook notebook = new Notebook(model, brand, price);

            notebook.DisplayInfo();

            Console.Read();

        }
    }
}
