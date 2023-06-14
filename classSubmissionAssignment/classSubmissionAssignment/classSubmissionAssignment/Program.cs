using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //2.In the Main() method, instantiate that class.
            var mathObject = new Math();

            //3. Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.
            Console.WriteLine("Please input a number to be divided by two.");
            var number = Convert.ToInt32(Console.ReadLine());
            mathObject.divide(number);
            Console.ReadLine();

        }
    }
}
