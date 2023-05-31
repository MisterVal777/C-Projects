using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6PartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1-Add one dimension Array of strings
            string[] names = { "Haydn", "Valentino", "Guiness", "LuLu" };
           

            //Part 2-Ask user to input some text.
            Console.WriteLine("Please input some text.");
            string text = Console.ReadLine();



            //Part 3-loop that iterates through each string in the array and adds the user's text input to the end of each string.
            for (int i = 0; i < names.Length; i++)
            {
                string name =  names[i] + text ;
                Console.WriteLine(name);
                Console.ReadLine();
            }

        }
    }
    
}
