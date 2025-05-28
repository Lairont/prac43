using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Макбук", "Эппл", 150000);
            notebook.Info();

            Console.ReadLine();
        }
    }
}
