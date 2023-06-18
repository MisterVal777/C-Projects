using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // 3. Create another class called Employee and have it inherit from the Person class.
    public class Employee : Person
    // 4. Implement the SayName() method inside of the Employee class.
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
