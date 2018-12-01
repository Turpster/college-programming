using System;
using Layout;

namespace Arrays
{
    public class Arrays : Project
    {
        public Arrays() : base(new Paper[]{new Papers.Arrays.Paper(), 
            new Papers.ArraysWorksheetOne.Paper(), 
            new Papers.ArraysWorksheetTwo.Paper(), 
            new Papers.SampleCodeArrays.Paper(),
            new Papers.ArraysWorksheetThree.Paper(),
            new Papers.Twelve_Days_of_Christmas.Paper(), 
        }, "Arrays") {}
        public static void Main(string[] args)
        {
            Console.WriteLine("Please run the Base Project.");
        }
    }    
}