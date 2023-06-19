using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionassignment
{
    // 1.Create an Employee class with Id, FirstName and LastName properties. 
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    //2. In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property. Remember that comparison operators must be overloaded in pairs.

        public static bool operator == (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
            bool b = true;
            string em = b.ToString();
            Console.WriteLine(em);
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
            bool c = true;
            string emp = c.ToString();
            Console.WriteLine(emp);

        }
    }
}
