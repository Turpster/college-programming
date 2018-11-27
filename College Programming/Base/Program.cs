using System;
namespace Base
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            //TODO Change to add dynamically instead of statically
            var executor = new Executor();

            executor.AddProject(new Variables_and_Data_Types.VariablesAndDataTypesProject());
            executor.AddProject(new Selection.Selection());
            executor.AddProject(new Iteration.Iteration());
            executor.AddProject(new Arrays.Arrays());
            
            executor.AskUser();
        }
    }
}