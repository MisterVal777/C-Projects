using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //step1 print statement
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //step2 print Person 1 and 2
            Console.WriteLine("Person 1");
            Console.ReadLine();
            //step3 save input and convert to int
            Console.WriteLine("Person 1 what is your hourly rate?");
            string hourRateA = Console.ReadLine();
            int hourRateB = Convert.ToInt32(hourRateA);

            Console.WriteLine("Person 1 how many hours do you work per week?");
            string hourWeekA = Console.ReadLine();
            int hourWeekB = Convert.ToInt32(hourWeekA);

            
            Console.WriteLine("Person 2");
            Console.ReadLine();
         
            Console.WriteLine("Person 2 what is your hourly rate?");
            string hourRateC = Console.ReadLine();
            int hourRateD = Convert.ToInt32(hourRateC);

            Console.WriteLine("Person 2 how many hours do you work per week?");
            string hourWeekC = Console.ReadLine();
            int hourWeekD = Convert.ToInt32(hourWeekC);

            //step4 and 5 gather yearly salary
            int product = hourRateB * hourWeekB * 52;
            Console.WriteLine("Annual salary of Person 1 is \n" + product);
            Console.ReadLine();

          
            int productA = hourRateD * hourWeekD * 52;
            Console.WriteLine("Annual salary of Person 2 is \n" + productA);
            Console.ReadLine();

            //step6 boolean
            bool trueOrFalse = product > productA;
            Console.WriteLine("Does Person 1 make more money than Person 2? \n" + trueOrFalse.ToString());
            Console.ReadLine();

        }
    }
}
