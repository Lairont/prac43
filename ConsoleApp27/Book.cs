using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal struct Book
    {
        public string title;
        public string author;
        public int year;
        public int pages;

        public Book(string title, string author, int year, int pages)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.pages = pages;
        }

        public static Book Print()
        {
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Год издания: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Кол-во страниц: ");
            int pages = int.Parse(Console.ReadLine());

            return new Book(title, author, year, pages);
        }
        public override string ToString()
        {
            return $"Название: {title}\nАвтор: {author}\nГод издания: {year}\nКоличество страниц: {pages}";
        }
    }
}
