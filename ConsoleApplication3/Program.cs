using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                bool maritalStatus;


                Person p1 = new Person();
                System.Console.WriteLine("[Enter Information for Person 1]: ");

                p1.InputPersonData();

                System.Console.Write("Are you married? True or False");
                maritalStatus = bool.Parse(System.Console.ReadLine());
                if (maritalStatus)
                {
                    p1.SpouseInputData();
                }
                System.Console.WriteLine();


                Person p2 = new Person();
                System.Console.WriteLine("[Enter Information for Person 2]: ");

                p2.InputPersonData();

                System.Console.Write("Are you married? True or False ");
                maritalStatus = bool.Parse(System.Console.ReadLine());
                if (maritalStatus)
                {
                    p2.SpouseInputData();
                }
                System.Console.WriteLine();

                p1.PrintNameandAge();
                p2.PrintNameandAge();
                System.Console.WriteLine("Average Age: " + Person.SumOfAllAges / Person.count);
                System.Console.WriteLine();


                System.Console.WriteLine();
                System.Console.WriteLine("Fin - press any key");
                System.Console.ReadKey();

            }
        }
    }

}














