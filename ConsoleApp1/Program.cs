using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// ClassTaker изм поле change и принимает обьект класса 
        /// </summary>
        /// <param name="myClass"></param>
        static void ClassTakes(MyClass myClass)
        {
            myClass.change = "Изменено";
        }
        /// <summary>
        /// StructTaker изм поле change и принимает обьект класса 
        /// </summary>
        /// <param name="myStruct"></param>
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            //инициализируем поля
            myClass.change= "Не изменено";
            myStruct.change = "Не изменено";
            Console.WriteLine("До вызова");
            Console.WriteLine($"MyClass.change = {myClass.change}");
            Console.WriteLine($"MyStruct.change = {myStruct.change}");
            //Вызов методы
            ClassTakes(myClass);
            StructTaker(myStruct);
            //выводим значения после вызова методов
            Console.WriteLine("После вызова");
            Console.WriteLine($"MyClass.change = {myClass.change}");
            Console.WriteLine($"MyStruct.change = {myStruct.change}");
            Console.Read();
        }

    }
}
