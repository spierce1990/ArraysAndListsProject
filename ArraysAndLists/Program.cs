using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            var newOneArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            List<int> mylistEven = new List<int>();
            List<int> mylistOdd = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (var item in newOneArray)
            {
                if (item % 2 == 0)
                { mylistEven.Add(item); }



                else
                { mylistOdd.Add(item); }

            }


            Console.WriteLine("These are the even list:");
            mylistEven.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("These are the odd list:");
            mylistOdd.ForEach(item => Console.WriteLine(item));
            // Console.WriteLine(mylistEven);    
            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            foreach (var item in mylistEven)
            {
                Console.WriteLine($"The contents in the even list is {item}");

            }
        }
    }
}
