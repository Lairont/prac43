using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кол-во книг: ");
            int n = int.Parse(Console.ReadLine());
            Book[] books = new Book[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nКнига {i + 1}:");
                books[i] = Book.Print(); 
            }
            Console.WriteLine();
            foreach (Book book in books)
            {
                Console.WriteLine(book);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
