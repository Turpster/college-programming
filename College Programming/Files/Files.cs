using System;
using Layout;

namespace Files
{
    public class Files : Layout.Project
    {
        public Files() : base(
            new Paper[]
            {
                new Papers.RecordStructuresExercise.Paper(), 
                new Papers.Structures.Paper()
            }, "Files") {}
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Please run the Base project.");
        }
    }
}