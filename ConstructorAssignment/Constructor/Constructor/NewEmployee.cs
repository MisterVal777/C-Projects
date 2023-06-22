using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    //3. 3.Chain two constructors together.
    public class NewEmployee
    {
        public string firstName;
        public string lastName;
        public string v;

        public NewEmployee() : this("Default firstName", "Default lastName")
        {
            Console.WriteLine("Reserving new record for the upcoming employee.");
        }
        public NewEmployee(string firstName) : this(firstName, "Default lastName")
        {
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName!");
        }

        public NewEmployee(string firstName, string v)
        {
            this.firstName = firstName;
            this.v = v;
        }
    }

}





    //public class Car
    //{


