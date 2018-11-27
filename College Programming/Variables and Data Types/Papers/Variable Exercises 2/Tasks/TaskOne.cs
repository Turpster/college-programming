using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Variable_Exercises_2.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base(
            "Temperatures can be converted from Fahrenheit to Centigrade using the following formula, where F is the " +
            "temperature in Fahrenheit and C the temperature in Centigrade:\n" +
            "C = 5 (F-32) / 9\n" +
            "Write a program to input a Fahrenheit temperature and output the equivalent temperature in Centigrade.",
            "Task One")
        {}

        public override void Run()
        {
            double fahrenheit = Utils.AskUserDouble("Fahrenheit");
            Console.WriteLine("Centigrade: {0}.", 5 * (fahrenheit-32) / 9);
        }
    }
}