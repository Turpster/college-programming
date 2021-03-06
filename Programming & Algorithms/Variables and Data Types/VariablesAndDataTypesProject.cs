using System;
using Layout;

namespace Variables_and_Data_Types
{
    public class VariablesAndDataTypesProject : Project
    {
        public VariablesAndDataTypesProject() : base(
            new Paper[]
            {
                new Papers.Simple_Output.Paper(),
                new Papers.Simple_Variables_Use.Paper(),
                new Papers.Input.Paper(),
                new Papers.Simple_Calculations.Paper(),
                new Papers.Random_Number.Paper(),
                new Papers.Variable_Exercises_1.Paper(),
                new Papers.Variable_Exercises_2.Paper()
            }, "Variables And Data Types") 
        {}

        public static void Main(string[] args)
        {
            Console.WriteLine("Please run the Base project.");
        }
    }
}