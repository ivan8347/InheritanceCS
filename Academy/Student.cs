using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{

    internal class Student : Human
    {
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }
        public Student(string lastName, string firstName, int age, string speciality, string group,
            double rating, double attendence) : base(lastName, firstName, age)
        {
           
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendence;
            Console.WriteLine($"SConstructor:\t{GetHashCode().ToString("X")}");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality,-22} {Group,-8} {Rating,-5} {Attendance,-3}";
        }
        ~Student()
        {
            Console.WriteLine($"SDestructor:\t{GetHashCode().ToString("X")}");
        }



       /* public static Human CreateObjectByType(string type)
        {
            switch (type.ToLower())
            {
                case "Student":
                    return Student.FillRand();
                default:
                    return null;
            }
        }*/

        public static Student FillRand()
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
            double.TryParse(Console.ReadLine(),out Attendence);

            return new Student(LastName, FirstName, Age, Speciality, Group,Rating,Attendence);
        }
    }
}
