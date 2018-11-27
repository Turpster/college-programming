using System;
namespace Base
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //TODO Change to add dynamically instead of statically
            
            Layout.Executor.AddProject(new Variables_and_Data_Types.VariablesAndDataTypesProject());
            Layout.Executor.AddProject(new Selection.Selection());
            new Layout.Executor();
        }
        
    }
}