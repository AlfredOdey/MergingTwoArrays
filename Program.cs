using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merging2Arrays
{
    internal class Program
    {
        /*Question 4: Merging Two Arrays
        Create two arrays of integers:
        {1, 2, 3} and {4, 5, 6}.
        Merge the two arrays into a single array.
        Print the merged array.
        */
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };

            int[] mergedArray = array1.Concat(array2).ToArray();

            //Using a ForEach Loop	
            Console.Write("Value of merged array: [ ");
            foreach (var element in mergedArray)
            {
                Console.Write($"{element} ");
            }
            Console.Write("]\n");

            //Using String.Join
            Console.WriteLine($"Value of merged array: [ {String.Join(", ", mergedArray)} ]");
        }
    }
}
