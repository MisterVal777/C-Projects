using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program

    {
        static void Main(string[] args)
        {
            //2. In the Main() method, create a list of at least 10 employees.At least two employees should have the first name “Joe”.

            List<Employees> Employee = new List<Employees>()
            
            { 
            new Employees { FirstName = "Ryan", LastName = "Reynolds", Id = 1 },
            new Employees { FirstName = "Ben", LastName = "Afflek", Id = 2 },
            new Employees { FirstName = "Joe", LastName = "Crue", Id = 3 },
            new Employees { FirstName = "Hayden", LastName = "Christiansen", Id = 4 },
            new Employees { FirstName = "Chris", LastName = "Hemsworth", Id = 5 },
            new Employees { FirstName = "Al", LastName = "Paccino", Id = 6 },
            new Employees { FirstName = "Joe", LastName = "Dirt", Id = 7 },
            new Employees { FirstName = "Toby", LastName = "Keith", Id = 8 },
            new Employees { FirstName = "Val", LastName = "Kilmer", Id = 9 }
            };
            //3. Using a foreach loop, create a new list of all employees with the first name “Joe”. In your comparison statement, remember to reference the property of the object you are checking.
            List<Employees> empJoe = Employee.FindAll(emp => emp.FirstName.Contains("Joe")).ToList();
            foreach (Employees emp in empJoe)
                Console.WriteLine(emp.FirstName + " " + emp.LastName);


            //4. Perform the same action again, but this time with a lambda expression.
            var EmployeeJoe = Employee.FindAll(x => x.FirstName == "Joe");
            foreach (var employeeJoes in EmployeeJoe)
            {
                  Console.WriteLine(employeeJoes.FirstName + " " + employeeJoes.LastName);
            }

            //5. Using a lambda expression, make a list of all employees with an Id number greater than 5.
            var EmployeeId = Employee.FindAll(x => x.Id > 5);
            foreach (var employeeIds in EmployeeId)
            {
                Console.WriteLine(employeeIds.FirstName + " " + employeeIds.LastName);
            }

            Console.ReadLine();
        }
    }
}

