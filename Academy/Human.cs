using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{

    internal class Human
    {
        public string LastName{get; set;}
        public string FirstName{get; set;}
        public int Age {get; set;}

        public Human(string lastName,string firstName, int age)
        {
            LastName =  lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"HConstructor:\t{GetHashCode().ToString("X")}");
        }
         ~Human() 
        {
        Console.WriteLine($"HDestructor:\t{GetHashCode().ToString("X")}");
        }
        public override string ToString()
        {
            return $"{base.ToString(),-20} {LastName,-16} {FirstName,-10} {Age,-3}";
        }


        public static Human CreateObjectByType(string type)
        {
            switch (type.ToLower())
            {
                case "human":
                    return Human.FillRand();
                case "student":
                    return Student.FillRand();
                case "teacher":
                    return Teacher.FillRand();
                case "graduate":
                    return Graduate.FillRand();
                default:
                    return null;
            }
        }


        public static Human FillRand()
            {
                Console.WriteLine("Фамилия: ");
                string LastName = Console.ReadLine();
                Console.WriteLine("Имя: ");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Возраст: ");
                int Age;
                int.TryParse(Console.ReadLine(), out Age);
                return new Human (LastName,FirstName,Age);
            }


        public static void EnterData(Human[] group, ref int n, int max_size)
        {
            while (n < max_size)
            {
                Console.WriteLine("Введите тип объекта (Human, Student, Teacher, Graduate), или 'exit' для завершения:");
                string type = Console.ReadLine();

                if (type.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                Human obj = CreateObjectByType(type);
                if (obj != null)
                {
                    group[n] = obj;
                    n++;
                }
                else
                {
                    Console.WriteLine("Объект не создан, попробуйте снова.");
                }

                Console.WriteLine("Добавить еще? (y/n):");
                string choice = Console.ReadLine();
                if (string.IsNullOrEmpty(choice) || choice.ToLower() != "y")
                    break;
            }
        }





    }
}
