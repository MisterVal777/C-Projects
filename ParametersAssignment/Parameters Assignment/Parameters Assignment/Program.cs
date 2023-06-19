using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    class Program
    {
        
        static void Main(string[] args)
        {
//-------3. Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.---------------------
            Employee<string> Things = new Employee<string>();
            Things.things = new List<string>() { "Leash", "Collar", "Harness", "Clicker" };
//-------4.Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.------------------------
            Employee<int> NumberThings = new Employee<int>();
            NumberThings.things = new List<int>() { 1, 2, 3, 4 };

//-------5. Create a loop that prints all of the Things to the Console.
            foreach (string item in Things.things)
            {
                Console.WriteLine(item);
                //Console.ReadLine();
            }
            foreach (int numberItems in NumberThings.things)
            {
                Console.WriteLine(numberItems);
                //Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
