using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

           
            //1.Prints the current date and time to the console.
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            //2.Asks the user for a number.
            Console.WriteLine("input a number");
            int number = Convert.ToInt32(Console.ReadLine());
            //3.Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine("{0} + {1} = {2} ", now, number, now.AddHours(number));
            Console.ReadLine();
        }
    }
}
