using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionassignment
{

    //3. In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties. Then compare the two Employee objects using the newly overloaded operators and display the results.
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.FirstName = "Ryan";
            employee1.LastName = "Omar";
            employee2.FirstName = "Ryan";
            employee2.LastName = "Omara";
            employee1.Id = 1802;
            employee2.Id = 1702;
            Console.WriteLine("Does employee1 and employee2 have the same firstnames? " + employee1.FirstName == employee2.FirstName);
            Console.WriteLine("Does employee1 and employee2 have same lastnames? " + employee1.LastName == employee2.LastName);
            Console.WriteLine("Are employee1 and employee2 the same employee?" + employee1 == employee2);
            Console.ReadLine();
        }        
    }
}
