using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{

    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)

        {
            // In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("Enter a number this program will add 7, subtract 4, and than square that number... ");
            var userValue = Convert.ToInt32(Console.ReadLine());


            // 3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.
            var mathObject = new Math();
            var result = mathObject.add(userValue);
            Console.WriteLine(userValue + " + 7 is " + mathObject.add(userValue));
            Console.ReadLine();
            result = mathObject.subtract(userValue);
            Console.WriteLine(userValue + " minus 4 and you have " + mathObject.subtract(userValue));
            Console.ReadLine();
            result = mathObject.square(userValue);

            Console.WriteLine(userValue + " Squared and you get " + mathObject.square(userValue) + ", thanks for playing!");
            Console.ReadLine();

        }
    }
}
