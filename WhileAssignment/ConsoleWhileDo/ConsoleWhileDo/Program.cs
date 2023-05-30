using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWhileDo
{
    class Program
    {
        static void Main(string[] args)
        {    // a while statement that will count up to 17 while i is less than 17 starting at 7.
            int i = 7; 
            while ( i < 17)
            {
                Console.WriteLine(i);
                i++;
            }

            // a while do statement using switch to loop program until correct number is guessed
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 17;
            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. You are not correct.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. trye again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 17:
                        Console.WriteLine("You guessed the number 17.  That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isGuessed);

            Console.Read();
        }
    }
}
