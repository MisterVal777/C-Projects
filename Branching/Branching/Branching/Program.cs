using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter your package weight:");
            string package = Console.ReadLine();
            int packageWeight = Convert.ToInt32(package);

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            if (packageWeight < 50)
            {
                Console.WriteLine("Please enter your package width:");
                string width = Console.ReadLine();
                int packageWidth = Convert.ToInt32(width);

                Console.WriteLine("Please enter your package height:");
                string height = Console.ReadLine();
                int packageHeight = Convert.ToInt32(height);

                Console.WriteLine("Please enter your package length:");
                string length = Console.ReadLine();
                int packageLength = Convert.ToInt32(length);


                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                if (packageWidth + packageHeight + packageLength < 50)
                {
                    Console.WriteLine("Your estimated total is $" + packageWeight * packageHeight * packageLength * packageWeight / 100);
                    Console.ReadLine();
                }
            }
        }
    }
}
