using System;
using Variables_and_Data_Types;

namespace Base
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Layout.Executor.AddProject(new VariablesAndDataTypesProject());
            new Layout.Executor();
        }
        
    }
}