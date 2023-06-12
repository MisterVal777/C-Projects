﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{

    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)

        {
            // In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("Enter a number this program will add 7, subtract 4, and than square that number... ");
            var userValue = Convert.ToInt32(Console.ReadLine());


            // 3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.
            var mathObject = new Math();
            var result = mathObject.add(userValue);
            Console.WriteLine(userValue + " + 7 is " + result);
            Console.ReadLine();
            result = mathObject.subtract(result);
            Console.WriteLine("subtract 4 and you have " + result);
            Console.ReadLine();
            result = mathObject.square(result, result);

            Console.WriteLine("Square this number and you get " + result + ", thanks for playing!");
            Console.ReadLine();

        }
    }
}
