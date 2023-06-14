using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classSubmissionAssignment
{
    class Math
    {
        //1.  Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.
        public void divide(int num1)
        {
            int sum = num1 / 2;
            Console.WriteLine(num1 + " divided by two is " + sum);
        }
        //4. Create a method with output parameters.
        public void outNum(out int outNumber, out string outString)
        {
            outNumber = 10;
            outString = "Hello World!";
        }
        //5. Overload a method.
        public double area(double s)
        {
            double area = s * s;
            return area;
        }
        public double area(double l, double b)
        {
            double area = l * b;
            return area;
        }

        //6. Declare a class to be static
        static class User
        {
            // Static Variables
            public static string name;
            public static string location;
            public static int age;
        }
    }
}
