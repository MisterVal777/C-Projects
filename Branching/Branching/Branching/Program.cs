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










            //else if (packageWeight < 50)
            //{
            //    Console.WriteLine("Please enter your package width:");
            //    string width = Console.ReadLine();
            //    int packageWidth = Convert.ToInt32(width);
            //}







            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room rtemperature");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhhh..... something went wrong.");
            //}

            //Console.ReadLine();

            //int currentTemperature = 70;
            //int roomTemperature = 70;

            //string comparisonResults = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp";
            //Console.WriteLine(comparisonResults);
            //Console.ReadLine();

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is ecactely room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room tempeerature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current tempeerature");
            //}
            //else
            //{
            //    Console.WriteLine("It is not room temperature");
            //}
            //Console.ReadLine();
        }
    }
}
