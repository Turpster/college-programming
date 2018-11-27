using System;
using Variables_and_Data_Types;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Layout.Layout.AddProject(new VariablesAndDataTypesProject());
            new Layout.Layout();
        }
    }
}