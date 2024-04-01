using Task02.Models;

namespace Task02
{
    internal class Program
    {
        #region Task02

        /*
         Task 2
        
        Write a program to create an abstract class Employee with abstract methods CalculateSalary() and DisplayInfo().
            
        Create subclasses Manager and Programmer that extend the Employee class and implement the respective methods to
        calculate salary and display information for each role.
         */

        #endregion
        static void Main(string[] args)
        {
            double hourlyRateManager, hourlyRateProgrammer;
            while (true)
            {
               Console.WriteLine("Enter hourly rate for manager:");
               if (!double.TryParse(Console.ReadLine(), out hourlyRateManager))
               {
                   Console.WriteLine("Enter valid number.");
                   continue;
               }

               break;
            }

            while (true)
            {
                Console.WriteLine("Enter hourly rate for programmer:");
                if (!double.TryParse(Console.ReadLine(), out hourlyRateProgrammer))
                {
                    Console.WriteLine("Enter valid number.");
                    continue;
                }

                break;
            }
            

            var manager1 = new Manager("Bob", "Bobsky", 5, 45);
            var manager2 = new Manager("Boss", "Boss", 10, 45);
            
            Console.WriteLine(manager1.DisplayInfo());
            Console.WriteLine(manager1.CalculateSalary(hourlyRateManager));
            Console.WriteLine();
            Console.WriteLine(manager2.DisplayInfo());
            Console.WriteLine(manager2.CalculateSalary(hourlyRateManager));

            var programmer1 = new Programmer("BobProgrammer", "Bobsky", 4, 45);
            var programmer2 = new Programmer("Experienced", "Programmer", 7, 45);
            
            Console.WriteLine(programmer1.DisplayInfo());
            Console.WriteLine(programmer1.CalculateSalary(hourlyRateProgrammer));
            Console.WriteLine();
            Console.WriteLine(programmer2.DisplayInfo());
            Console.WriteLine(programmer2.CalculateSalary(hourlyRateProgrammer));
        }
    }
}
