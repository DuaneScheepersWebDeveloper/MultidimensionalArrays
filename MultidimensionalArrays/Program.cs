using System;

namespace MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize a 2D Array
            int[,] array2D = new int[,]
            {
                {1, 2, 3}, // Row 0
                {4, 5, 6}, // Row 1
                {7, 8, 9}  // Row 2
            };

            // Access and print a value from the array
            Console.WriteLine("Value at array2D[2, 0] is {0}", array2D[0, 1]);

            // Wait for user input before exiting
            Console.ReadKey();
        }
    }
}
