using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    // 1.Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application
    public class Math
    {
        public int add(int data, int value)
        {
            return data + value;
        }

        public int subtract(int data, int value)
        {
            return data - value;
        }

        public int square(int data, int value)
        {
            return data * value;
        }
    }
}
