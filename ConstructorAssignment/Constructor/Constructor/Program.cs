using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            
            

            //1.Create a const variable
            const string myFirstName = "Ryan";
         

            ////2.Create a variable using the keyword "var".
     


            Console.WriteLine("First construct!");
            var a = new NewEmployee();
            Console.WriteLine("Second construct!");
            NewEmployee b = new NewEmployee("Daniel");
            Console.WriteLine("Third construct!");
            NewEmployee c = new NewEmployee("Daniel", "Szabo");
            Console.WriteLine(myFirstName);
            Console.ReadLine();
        }

  
    }
}
