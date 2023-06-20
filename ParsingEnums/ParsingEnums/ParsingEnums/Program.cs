using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{

    // 1. Create an enum for the days of the week.

    // 2. Prompt the user to enter the current day of the week.

    // 3. Assign the value to a variable of that enum data type you just created.

    // 4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.





    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 2. Prompt the user to enter the current day of the week.
                Console.WriteLine("Please enter the current day of the week into the Console.");
                string currentDay = Console.ReadLine();

                var Day = System.Enum.Parse(typeof(WeekDays), currentDay);
                //WeekDays parsedEnumValue = (WeekDays)System.Enum.Parse(typeof(WeekDays), currentDay);
                Console.WriteLine( (WeekDays)System.Enum.Parse(typeof(WeekDays), currentDay));



            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
