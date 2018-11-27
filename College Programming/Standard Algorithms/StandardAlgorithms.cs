using System;
using Layout;

namespace Standard_Algorithms
{
    public class StandardAlgorithms : Project
    {

        public StandardAlgorithms() : base(new Paper[]
        {
            new Papers.BubbleSortStructure.Paper(),
            new Papers.BinarySearch.Paper(),
            new Papers.BinarySearchIterative.Paper(),
            new Papers.BinarySearchIterativeCode.Paper(),
            new Papers.BigO.Paper(), 
        }, "Standard Algorithms") {}

        public static void Main(string[] args)
        {
            Console.WriteLine("Please run the Base project.");
        }
    }
}