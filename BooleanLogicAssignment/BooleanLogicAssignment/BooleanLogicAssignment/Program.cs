using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // step 1. Ask and save 3 inputs variables
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int ageNumber = Convert.ToInt32(yourAge);

            Console.WriteLine("Have you ever had a DUI? Please answer “true” or “false.”");
            string hadDui = Console.ReadLine();
            bool hasDui = Convert.ToBoolean(hadDui);

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketCount = Console.ReadLine();
            int ticketNumber = Convert.ToInt32(ticketCount);

            //step 2. Qualify applicant with Boolean
            Console.WriteLine("Qualified?");
            Console.WriteLine(ageNumber > 15 && hasDui == false && 3 > ticketNumber);
            Console.ReadLine();
        }
    }
}
