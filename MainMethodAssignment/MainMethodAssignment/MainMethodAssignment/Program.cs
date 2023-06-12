using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{

    class Program
    {
        //public decimal baseValue { get; set; }
        public static int Data { get; set; }
        static void Main(string[] args)

        {

            // In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("Enter a number this program will add 7, subtract 4, and than square that number... ");
            var userValue = Convert.ToInt32(Console.ReadLine());


            // 1. Create a class. In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer.
            var mathObject = new Math();
            var result = mathObject.add(userValue);
            // 2. In the Main() method of the console app, instantiate the class and call the one method, passing in an integer. Display the result to the screen.
            Console.WriteLine(userValue + " + 7 is " + mathObject.add(userValue));
            Console.ReadLine();



            //4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.

            //result = mathObject.asDecimal(userValue);
            Console.WriteLine(userValue + " minus 4 and you have " + mathObject.asDecimal(userValue));
            Console.ReadLine();



        }        
    }
}
