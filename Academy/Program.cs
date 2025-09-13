#define INHERITANCE
//#define WRITH_TO_FILE
//#define GROUP
//#define LOAD_TO_FILE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{

    internal class Program
    {

        static void Main(string[] args)
        {
#if INHERITANCE
            Human human = new Human("Schwartznegger", "Arnold", 78);
            Console.WriteLine(human);
            Console.WriteLine("\n_____________________________\n");
            Student student = new Student("Colombo", "Franco", 91, "HeavyMetal", "LA", 98, 100);
            Console.WriteLine(student);
            Console.WriteLine("\n_____________________________\n");
            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
            Console.WriteLine(teacher);
            Console.WriteLine("\n_____________________________\n");
            Graduate graduate = new Graduate("Schreder", "Hank", 40, "Criminalistic", "WW_220", 40, 60, "How to catch Heisenberg");
            Console.WriteLine(graduate);
            Console.WriteLine("\n_____________________________\n");

#endif
#if GROUP
             Human[] group =
              {
                new Human("Montana", "Antonio", 25),
                new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 99),
                new Student("Vercetty","Tommy",30,"Theft","vice",98,99),
                new Teacher("White", "Walter", 50, "Chemistry", 25),
                new Graduate("Schreder", "Hank", 40, "Criminalistic", "WW_220", 40, 60, "How to catch Heisenberg"),
                new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20),
                new Graduate("Targarian", "Daineris", 22, "Flight", "GoT", 91, 92, "How to make smoke"),
                new Teacher("Schwartzneger", "Arnold", 85, "Heavy Metal", 60)
              };
              string filename = "group.txt";
             string delimiter = new string('-', 40);

              // Запись в файл
              try
              {
                  using (StreamWriter fout = new StreamWriter(filename))
                  {
                      Console.WriteLine(delimiter);
                      foreach (var person in group)
                      {
                          Console.WriteLine(person);
                          fout.WriteLine(person);
                          Console.WriteLine(delimiter);
                      }
                  }
              }
              catch (Exception ex)
              {
                  Console.WriteLine("Ошибка при записи файла: " + ex.Message);
              }
              Console.WriteLine("Текущий каталог: " + Directory.GetCurrentDirectory());
              // Открываем файл в Notepad
              Process.Start("notepad.exe", filename);

          /*  using (StreamReader reader = new StreamReader("group.txt"))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }*/

#endif
#if WRITH_TO_FILE
             const int max_size = 10;
        Human[] group = new Human[max_size];
        int n = 0;

        Human.EnterData(group, ref n, max_size);
        Console.WriteLine("\nСозданные объекты:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(group[i]);
        }



            string filename = "group.txt";
            // Запись в файл
              try
              {
                  using (StreamWriter fout = new StreamWriter(filename))
                  {
                      foreach (var person in group)
                      {
                          Console.WriteLine(person);
                          fout.WriteLine(person);
                      }
                  }
              }
              catch (Exception ex)
              {
                  Console.WriteLine("Ошибка при записи файла: " + ex.Message);
              }
              Console.WriteLine("Текущий каталог: " + Directory.GetCurrentDirectory());
            // Открываем файл в Notepad
            Process.Start("notepad.exe", filename);

            using (StreamReader reader = new StreamReader("group.txt"))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            } 
#endif
#if LOAD_TO_FILE

            using (StreamReader reader = new StreamReader("group.txt"))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
#endif






        }
    }
}

