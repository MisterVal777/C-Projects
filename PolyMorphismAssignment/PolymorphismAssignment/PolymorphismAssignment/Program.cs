using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program

        // Step 1. is in the "IQuittable" Interface.
        // Step 2. is in the "Employee" class.
        // Step 3. is in the main "Program".



    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();

            //3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.
            IQuittable quit = new Employee();
            quit.Quit();

            Console.ReadLine();
        }
    
    }
}
