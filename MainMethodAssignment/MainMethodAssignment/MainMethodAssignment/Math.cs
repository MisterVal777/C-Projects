using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    // 1.Create a class. In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer.
    public class Math
    {
        public int add(int data)
        {
            return data + 7;
        }
        // 3. Add a second method to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer.
        public decimal asDecimal(int data)
        {
            return (decimal)data;
            
        }

    }
}