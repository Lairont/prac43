using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    struct Student
    {
        public string FIO;
        public string Group;
        public int Informatics;
        public int Physics;
        public int History;

        public Student(string FIO, string Group, int Informatics, int Physics, int History)
        {
            this.FIO = FIO;
            this.Group = Group;
            this.Informatics = Informatics;
            this.Physics = Physics;
            this.History = History;
        }

        public static Student Print()
        {
            Console.WriteLine("ФИО: ");
            string FIO = Console.ReadLine();
            Console.WriteLine("Группа: ");
            string Group = Console.ReadLine();
            Console.WriteLine("Оценка по Информатике: ");
            int Information = int.Parse(Console.ReadLine());
            Console.WriteLine("Оценка по Физике: ");
            int Physics = int.Parse(Console.ReadLine());
            Console.WriteLine("Оценка по Истории: ");
            int History = int.Parse(Console.ReadLine());
            return new Student(FIO, Group, Information, Physics, History);
        }
        public override string ToString()
        {
            return $"ФИО: {FIO}\nГруппа: {Group}\nОценка по Информатике: {Informatics}\nОценка по Физике: {Physics}\nОценка по Истории: {History}";
        }
        public double SredniuBall()
        {
            return (Informatics + Physics + History) / 3;
        }
    }
}
