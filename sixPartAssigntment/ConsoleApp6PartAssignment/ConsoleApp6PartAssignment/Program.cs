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
            //Part1-1 Add one dimension Array of strings
            string[] names = { "Haydn", "Valentino", "Guiness", "LuLu" };


            //Part1-2 Ask user to input some text.
            Console.WriteLine("Please input some text.");
            string text = Console.ReadLine();



            //Part1-3 loop that iterates through each string in the array and adds the user's text input to the end of each string.
            for (int i = 0; i < names.Length; i++)
            {
                names[i] += text;
                //part1-4 print array to console.
                Console.WriteLine(names[i]);
                Console.ReadLine();
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Part2-1 & 3 Create infinite loop.  And than added int count and a break when count reaches 5.
            int count = 0;
            while (true)
            {
                Console.WriteLine("Hey!  This was is an infinite loop!");

                if (count++ >= 5)
                {
                    break;
                }
            }

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Part3-1 A loop with comparison thats used to determine whether to continue itering the loop is a < operator
            int[] lowTemperature = { 28, 29, 30, 34, 39, 43, 49, 50, 65 };

            for (int n = 0; n < lowTemperature.Length; n++)
            {
                if (lowTemperature[n] < 36)
                {
                    Console.WriteLine("Gathered daily Low temperatures for this region and season are: " + lowTemperature[n]);   
                }
                // part3-2
                    if (65 <= lowTemperature[n])
                    {
                        break;
                    }
                   
            }
            Console.ReadLine();

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //part4-1 A list of string where each item is unique.
            List<string> fruits = new List<string>() { "Apple", "Orange", "Kiwi", "Pinnaple", "Banana" };

            //Part4-2 Ask user to input text to search for in list
            Console.WriteLine("Pick any of these options for you mid travel flight snack: \"Apple\", \"Orange\", \"Kiwi\", \"Pinnaple\", and \"Banana\" ");
            string choice = Console.ReadLine();

            //Part4-3 A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen
            for (int d = 0; 0 < fruits.Count; d++)
            {
                if (fruits.Contains(choice) == true)
                {
                    Console.WriteLine("Your choice has an index of " + fruits.IndexOf(choice));
                    break;
                }
            //Part4-4 Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list. 

                else
                    Console.WriteLine("Your choice does not exist for todays options.");
                break;
            }
            Console.ReadLine();

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Part5-1 A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.

            List<string> myStrings = new List<string>() { "NM", "AZ", "NM", "CA", "OR", "WA", "CA" };

            Console.WriteLine("User pick which state you are in: \"AZ\", \"CA\", \"NM\", \"OR\", or \"WA\"");
            string state = Console.ReadLine();
            
            //Part5-2 Create a loop that iterates through the list and then displays the indices of the items matching the user-selected text. Ensure to remove any break statements that may prevent your code from returning multiple matches.
            for (int f = 0; 0 < myStrings.Count; f++)
            {
                if (myStrings.Distinct().Count() != myStrings.Count())
                {
                    int count = 0;
                    bool belowFive = true;
                    while (belowFive)
                    Console.WriteLine("Your choice has an index of " + myStrings.IndexOf(state));
                    
                    if (count++ >= 5)
                    {
                            belowFive = false;
                    }

                    //Part5-3 Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list. (You do not need to provide any additional chances for the user to enter text.)
                    else
                        Console.WriteLine("Your choice does not exist for todays options.");
                    break;
                }
                Console.ReadLine();


            }






                //if (foundAt == -1)
                //    Console.WriteLine("1");

                //else
                //    Console.WriteLine("2");
                //    Console.ReadLine();
                //{
                //Console.WriteLine("Found it at index " + d);
                //break; //exit the loop early
                //}
                //else
                //{
                //    Console.WriteLine("Didn't find it at index " + d);
                //}
                //}
                //Console.WriteLine("Your choice has an index of " + fruits.IndexOf(choice));


                //string choice = Console.ReadLine();

                //    if (choice == fruits[])
                //        {
                //            Console.WriteLine(name);
                //        }





                //foreach (int n in name)
                ////for (int l = 0; l < name.Length; l++)
                //{
                //    string namey = name;
                //    Console.WriteLine(namey );
                //    Console.ReadLine();
                //}



                //foreach (string name in names)
                //{
                //    if (name == "")
                //    {
                //        names.Add(text);
                //    }
                //}

                //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

                //for (int i = 0; i < testScores.Length; i++)
                //{
                //    if (testScores[i] > 85)
                //    {
                //        Console.WriteLine("Passing Test Score: " + testScores[i]);
                //    }
                //}
                //Console.ReadLine();

                //string[] names = { "JEsse", "Erik", "Daniel", "Adam" };

                //for (int j = 0; j < names.Length; j++)
                


                //Console.WriteLine(names[j]);

                //if (names[j] == "JEsse")
                //{
                //    Console.WriteLine(names[j]);
                //}


            
            //Console.ReadLine();             
            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }

            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "JEsse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    //if (name == "JEsse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}
            //Console.WriteLine(passingScores.Count);
            //Console.ReadLine();

        }
    }
    
}
