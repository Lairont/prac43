using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    struct Book
    {
        public string Title;
        public string Author;
        public int Year;
        public int Pages;

        public Book(string title, string author, int year, int pages)
        {
            Title = title;
            Author = author;
            Year = year;
            Pages = pages;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\nИнформация о книге:");
            Console.WriteLine($"название: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Год издания: {Year}");
            Console.WriteLine($"Количество страниц: {Pages}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько книг вы хотите забрать?");
            int count;

            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.Write("Введите целое число");
            }
            Book[] books = new Book[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nВведите информацию о книге #{i + 1}");

                Console.Write("Название: ");
                string title = Console.ReadLine();
                Console.Write("ФИО автора: ");
                string author = Console.ReadLine();
                Console.Write("Год издания: ");
                int year;
                while (!int.TryParse(Console.ReadLine(), out year))
                {
                    Console.Write("корректный год: ");
                }
                Console.Write("Количество странци: ");
                int pages;
                while (!int.TryParse(Console.ReadLine(), out pages))
                {
                    Console.Write("Корректное количество страниц: ");
                }
                books[i] = new Book(title, author, year, pages);
            }
            Console.WriteLine("\nВсе введенные книги: ");
        
        }
    }
}
