using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a 4x5 2D array
            int[,] array = {
            {10, 4, 7, 3, 9},
            {6, 5, 8, 2, 11},
            {15, 12, 1, 14, 13},
            {19, 16, 18, 17, 20}
        };
            SortAndAdd(array);
        }
        static void SortAndAdd(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            Console.WriteLine("original 2D array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            //step:1 Extract all elements into a List
            List<int> elements = new List<int>();
            for(int i= 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    elements.Add(array[i, j]);
                }
            }
            // Step2:sort the List
            elements.Sort();
            int index = 0;
            for(int i=0;i<rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    array[i, j] = elements[index++];
                }
            }
            //print the sorted list
            Console.WriteLine("Sorted Array:");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
   

}

