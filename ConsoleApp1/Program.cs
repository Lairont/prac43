using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void structTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void Main(string[] args)
        {
            MyClass classInstance = new MyClass();
            MyStruct structInstance = new MyStruct();

            Console.Write("Введите значение для поля classInstance");
            classInstance.change = Console.ReadLine();

            Console.Write("Введите значение для поля structInstance");
            structInstance.change = Console.ReadLine();

            Console.WriteLine("\nДо вызова методов");
            Console.WriteLine("classInstant.change = " + classInstance.change);
            Console.WriteLine("structInstance.change =" + structInstance.change);

            ClassTaker(classInstance);
            structTaker(structInstance);

            Console.WriteLine("\nПосле вывода методов");
            Console.WriteLine("classInstant.change =" + classInstance.change);
            Console.WriteLine("structUnstnce.change=" + structInstance.change);

            Console.Read();

        }
    }
}
