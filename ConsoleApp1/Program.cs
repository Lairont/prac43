using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Создать структуру для хранения информации о студентах, включающую поля для ФИО, группы и оценок по таким предметам, как информатика, физика и история.
    //Реализовать возможность ввода данных с клавиатуры, сохранение их в коллекции, а затем выводить сведения об объектах в табличном виде. Если объекты не были введены, вывести сообщение об их отсутствии.
    //Также нужно вычислить средний балл по каждому предмету и вывести информацию о студентах, у которых средний балл выше 4, подсчитав их количество.
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.Write("Кол-во студентов ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Количество студентов должно быть больше 0.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nВведите данные для студента {i + 1}:");
                students.Add(Student.Print());
            }
            Console.WriteLine("\nСтуденты:");
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine($"Средний балл: {student.SredniuBall():F2}");
                Console.WriteLine();
            }
            Console.WriteLine("Студенты со средним баллом выше 4:");
            bool found = false;
            int count = 0;
            foreach (Student s in students)
            {
                if (s.SredniuBall() > 4.0)
                {
                    Console.WriteLine($"{s.FIO} {s.Group} — {s.SredniuBall():F2}");
                    found = true;
                    count++;
                }
            }

            if (!found)
            {
                Console.WriteLine("Нет таких студентов.");
            }
            else
            {
                Console.WriteLine($"Всего таких студентов: {count}");
            }
        }
    }
}
