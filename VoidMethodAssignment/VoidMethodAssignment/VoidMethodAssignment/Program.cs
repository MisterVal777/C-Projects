using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //2.In the Main() method of the console app, instantiate the class.
            var mathObject = new Math();

            //3. Call the method in the class, passing in two numbers.
            mathObject.add(1, 5);
            
            //4. Call the method in the class, specifying the parameters by name.
            void add(int num1, int num2, int sum)
            {
                Console.WriteLine(num1 + num2 + sum);               
            }
            Console.ReadLine();
        }
    }
}
