using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            {
                // This is a simple program to Read out Company name and report type.
                Console.WriteLine("The Tech Academy");
                Console.ReadLine();
                Console.WriteLine("Student Daily Report");
                Console.ReadLine();
                //Below are questions that will save yo named strings
                Console.WriteLine("What is your name?");
                string yourName = Console.ReadLine();
                

                Console.WriteLine("What course are you on?");
                string yourCourse = Console.ReadLine();

                Console.WriteLine("What page number?");
                string yourPage = Console.ReadLine();

                Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
                string needsHelp = Console.ReadLine();

                Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
                string specificExperiences = Console.ReadLine();

                Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
                string specificFeedback = Console.ReadLine();
                //Below question will convert hours worked from a string to an int and read out a good job statement follwed by the closing statement. 
                Console.WriteLine("How many hours did you study today?");
                string hoursWorked = Console.ReadLine();
                int hrsWorked = Convert.ToInt32(hoursWorked);
                Console.WriteLine("Nice Job putting in " + hrsWorked + " hours of study today!");

                Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
                Console.ReadLine();

            }
        }
    }

}
    

