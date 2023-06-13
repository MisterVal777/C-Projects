using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleIntegerMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.In the Main() method of the console app, instantiate the class.
            var mathObject = new Math();

            //3.Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.
            Console.WriteLine("Please enter two numbers one at a time, the second number will be optional.  Please input the first number. ");
            var userNum1 = Convert.ToInt32(Console.ReadLine());
            
            try
            {
            Console.WriteLine("Please input the second number (optional). ");
            var userNum2 = int.Parse(Console.ReadLine());

            //3. Call the method in the class, passing in the one or two numbers entered.
            var result = mathObject.add(userNum1, userNum2);

            Console.WriteLine(userNum1 + " plus " + userNum2 + " is equal to " + result);
            Console.ReadLine();
            }
            catch (Exception)
            {
            var result = mathObject.add(userNum1);
            Console.WriteLine(userNum1 + " plus a default number of 2 is equal to " + result);
            Console.ReadLine();
            }

        }
    }
}
