using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Graduate : Student
    {
        public string Subject{get;set;}

        public Graduate( string lastName, string firstName, int age, string speciality, string group,
            double rating, double attendence,string subject) : base(lastName, firstName, age, speciality, group,
             rating, attendence)
        {
            Subject = subject;
            Console.WriteLine($"GConstructor:\t{GetHashCode().ToString("X")}");
        }
        public override string ToString()
        {
            return  base.ToString()+$" {Subject}";
        }
        ~Graduate()
        {
            Console.WriteLine($"GDestructor:\t {GetHashCode().ToString("X")}");

        }

        public static Graduate FillRand()
        {
            Console.WriteLine("Фамилия: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Имя: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Возраст: ");
            int Age;
            int.TryParse(Console.ReadLine(), out Age);
            Console.WriteLine("Специальность: ");
            string Speciality = Console.ReadLine();
            Console.WriteLine("Группа: ");
            string Group = Console.ReadLine();
            Console.WriteLine("Рейтинг: ");
            double Rating;
            double.TryParse(Console.ReadLine(), out Rating);
            Console.WriteLine("Посещаемость: ");
            double Attendence;
            double.TryParse(Console.ReadLine(), out Attendence);
            Console.WriteLine("Тема курсовой:");
            string Subject = Console.ReadLine();

            return new Graduate(LastName, FirstName, Age, Speciality, Group, Rating, Attendence, Subject);
        }


    }
}
