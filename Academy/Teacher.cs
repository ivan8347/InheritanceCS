using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher : Human
    {
        
        public string Speciality { get; set; }
        public int Experience { get; set; }

        public Teacher(string lastName, string firstName, int age, string speciality,int experiance)
             : base(lastName, firstName, age)
        {
            Speciality = speciality;
            Experience = experiance;
            Console.WriteLine($"TConstructor:\t{GetHashCode().ToString("X")}");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality,-22} {Experience,-3} ";
        }
        ~Teacher()
        {
            Console.WriteLine($"TDestructor:\t{GetHashCode().ToString("X")}");
        }

        public static Teacher FillRand()
        {
            Console.WriteLine("Фамилия: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Имя: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Возраст: ");
            int Age;
            int.TryParse(Console.ReadLine(), out Age);
            Console.WriteLine("Специальность:");
            string Speciality = Console.ReadLine();
            Console.WriteLine("Опыт:");
            int Experience;
            int.TryParse(Console.ReadLine(), out Experience);
            return new Teacher(LastName, FirstName, Age, Speciality, Experience);
        }




    }
}
