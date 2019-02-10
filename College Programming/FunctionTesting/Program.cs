using System;
using Layout;

namespace FunctionTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 3, 3, 4, 4, 5, 8};
            
            Console.WriteLine(Algorithms.BinarySearch(arr, 0, arr.Length - 1, 1));
        }
    }
}