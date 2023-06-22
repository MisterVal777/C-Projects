using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Ask the user for his age.
            //2.Display the year user born.
            //3.Exceptions must be handled using "try .. catch".
            //4.Display appropriate error messages if user enters zero or negative numbers.
            //5.Display a general message if exception caused by anything else.
            try
            {

                Console.WriteLine("Please, input your age?");
                int ageInput = int.Parse(Console.ReadLine());
                DateTime year = DateTime.Now;
                int yearBorn = year.Year - ageInput;
                // Console.WriteLine("{0} - {1}  = {2}", year.Year, ageInput, (year.Year));
                if (ageInput < 0)
                {
                    throw new Exception("Only Positive Numbers & no Letters Please!");
                }
                // Console.WriteLine("By the age input you have given, you were born in the year...");
                Console.WriteLine(yearBorn);
                return;
            }

            catch (FormatException)
            {
                Console.WriteLine(" Please input in digits only, decimals and words are not accepted. Thank you.");
                Console.ReadLine();
                return;
            }

            catch (Exception birthYear)
            {
                Console.WriteLine(birthYear.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
