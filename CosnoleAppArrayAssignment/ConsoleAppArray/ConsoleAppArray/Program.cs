using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 1. Single dimensioanl arrays
            string[] dogBreed = new string[3];
            dogBreed[0] = "German Shepherd";
            dogBreed[1] = "Belgian Mal";
            dogBreed[2] = "Dutch Shepherd";

            Console.WriteLine("Select and index number from 0-2 for your assigned K9 working Breed.");
            string k9Breed = Console.ReadLine();
            int k9Num = Convert.ToInt32(k9Breed);

            //part 3. Error message
            if (k9Num > 2)
            {
                Console.WriteLine("Index does not exist");
            }
            else
                Console.WriteLine("Your assigned K9 working breed is " + dogBreed[k9Num]);
            Console.ReadLine();



            //Part 2. one Dimensional array of integers.
            int[] numArray = new int[4];
            numArray[0] = 7;
            numArray[1] = 9;
            numArray[2] = 17;
            numArray[3] = 453;

            Console.WriteLine("Select and index number from 0-3 for a suprise dollar amount gift!");
            string giftNumber = Console.ReadLine();
            int giftNum = Convert.ToInt32(giftNumber);

            // Part 3. error message
            if (giftNum > 3)
            {
                Console.WriteLine("Index does not exist");
            }
            else
                Console.WriteLine("Congrats! Here is the amount of $" + numArray[giftNum]);
                Console.ReadLine();




            //part 4.  Create a list of strings
            List<string> intList = new List<string>();
            intList.Add("Shovel full of sand!");
            intList.Add("Shovel full of mud!");
            intList.Add("Shovel full of diamonds!");
            intList.Add("Shovel full of leaves!");
            intList.Add("Shovel full of $100 dollar bills!");

            Console.WriteLine("Select and index number from 0-4 for a suprise gift in the amount of a shovel full.");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);

            //Part 3. Error message
            if (num > 4)
            {
                Console.WriteLine("Index does not exist");
            }
            else
                Console.WriteLine("Wow!  You have won a " + intList[num]);
                Console.ReadLine();
        }
    }
}
