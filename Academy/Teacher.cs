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
            return base.ToString() + " " + $"{Speciality} {Experience} ";
        }
        ~Teacher()
        {
            Console.WriteLine($"TDestructor:\t{GetHashCode().ToString("X")}");
        }


    }
}
