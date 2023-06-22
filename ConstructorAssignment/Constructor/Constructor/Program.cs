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
            Console.WriteLine("Hello, {0}.", myIdentity);

            //2.Create a variable using the keyword "var".
            var identity = new Identity();
            identity.id = 98898;
            identity.name = "Jennifer";
            //3.Chain two constructors together.
            Console.WriteLine(identity.id);
            Console.WriteLine(identity.name);
            Console.ReadLine();
        }




        //const string casinoName = "Grand hotel casino";

        
    }
}
