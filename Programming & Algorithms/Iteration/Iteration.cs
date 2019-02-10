using System;
using Layout;

namespace Iteration
{
    public class Iteration : Layout.Project
    {
        public Iteration() : base(
            new Paper[]
            {
                new Papers.ForLoopBasics.Paper(), 
                new Papers.ForLoopsAdvanced.Paper(),
                new Papers.ValidationEgCode.Paper(),
                new Papers.ProgramValidation.Paper(),
                new Papers.StringFunctionsOne.Paper(), 
                new Papers.StringFunctionsTwo.Paper(), 
                new Papers.UpperLowerTitleCase.Paper()
            }, "Iteration") {}
        public static void Main(string[] args)
        {
            Console.WriteLine("Please run the Base project.");
        }
    }
}