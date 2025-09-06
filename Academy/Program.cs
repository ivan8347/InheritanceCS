using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Human human = new Human("Schwartznegger","Arnold",78);
            Console.WriteLine(human);
            Console.WriteLine("\n_____________________________\n");
            Student student = new Student("Colombo", "Franco", 91, "HeavyMetal","LA", 98, 100);
            Console.WriteLine(student);
            Console.WriteLine("\n_____________________________\n");
            Teacher teacher = new Teacher ("White", "Walter", 50, "Chemistry", 25);
            Console.WriteLine(teacher);
            Console.WriteLine("\n_____________________________\n");
            Graduate graduate = new Graduate("Schreder","Hank", 40,"Criminalistic", "WW_220", 40, 60, "How to catch Heisenberg");
           Console.WriteLine(graduate);
            Console.WriteLine("\n_____________________________\n");

        }
    }
}
