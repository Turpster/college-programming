using System;
using Layout;

namespace Procedures_and_Functions
{
    public class ProceduresAndFunctions : Layout.Project
    {
        public ProceduresAndFunctions() : base(
            new Paper[]
            {
                new Papers.Subroutines.Paper(), 
                new Papers.ProcedureFunctionSheet.Paper(),
                new Papers.MiniProjectProceduresFunctions.Paper(),
                new Papers.SampleCodeProcFunc.Paper()
            }, "Iteration") {}
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Please run the Base project.");
        }
    }
}