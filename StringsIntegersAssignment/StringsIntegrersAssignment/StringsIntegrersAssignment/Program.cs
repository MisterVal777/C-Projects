using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsIntegrersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
                try
                {
                    List<int> list = new List<int>() { 20, 50, 100 };

                    Console.WriteLine("Pick a number to divide against 20, 50, 100 ");
                    int numberOne = Convert.ToInt32(Console.ReadLine());

                    foreach (int number in list)
                    {
                        int numberTwo = number / numberOne;
                        Console.WriteLine(numberTwo);
                    }
                    Console.ReadLine();

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please type a whole number");
                    return;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please dont divide by Zero");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }  
        }
    }
}
