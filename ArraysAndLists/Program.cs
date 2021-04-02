using System;
using System.Collections.Generic; // added to create lists

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // DONE an int Array and populate numbers 1-10
            // example 1 - declaring and array of size 10 and intializing with index and the value

            int[] myArray = new int[10];
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
            myArray[4] = 5;
            myArray[5] = 6;
            myArray[6] = 7;
            myArray[7] = 8;
            myArray[8] = 9;
            myArray[9] = 10;

            // example 2 - decarling and initializing an array

            int[] myArray2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // or

            int[] myArray2a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // example 3 - shorthand with inferred implicit var keyword

            var myArray3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // example 4 - shortahand syntax

            int[] myArray4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            List<int> evens = new List<int>();

            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            // foreach loop to assign evens to List evens 

            foreach(var i in myArray)
            {
                if(i % 2 == 0)
                {
                    evens.Add(i);
                }
            }

            // for loop to assign odd numbers to List odds

            for (var i = 0; i < myArray.Length; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            // foreach loop to display the List evens

            Console.Write("This is the List evens: ");
            foreach ( var i in evens)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

            // for loop to display the List odds

            Console.Write("This is the List odds: ");
            for (var k = 1; k < 10; k += 2)
            {    
                Console.Write(k + ", ");
            }
        }
    }
}
