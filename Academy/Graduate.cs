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
            double rating, double attendence,string subject  ) : base(  lastName, firstName, age, speciality, group,
             rating, attendence)
        {
            Subject = subject;
            Console.WriteLine($"GConstructor:\t{GetHashCode().ToString("X")}");
        }
        public override string ToString()
        {
            return base.ToString() + " " + $"{Subject} ";
        }
        ~Graduate()
        {
            Console.WriteLine($"GDestructor:\t{GetHashCode().ToString("X")}");
        }
    }
}
