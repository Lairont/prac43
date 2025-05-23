using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //Создать структуру для хранения информации о студентах, включающую поля для ФИО, группы и оценок по таким предметам, как информатика, физика и история.
    //Реализовать возможность ввода данных с клавиатуры, сохранение их в коллекции, а затем выводить сведения об объектах в табличном виде. Если объекты не были введены, вывести сообщение об их отсутствии.
    //Также нужно вычислить средний балл по каждому предмету и вывести информацию о студентах, у которых средний балл выше 4, подсчитав их количество.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кол-во студентов: ");
            int n = int.Parse(Console.ReadLine());
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nВвод данных для студента #{i + 1}");
                students[i] = Student.Print();
            }
            Console.WriteLine(
        }
    }
}
