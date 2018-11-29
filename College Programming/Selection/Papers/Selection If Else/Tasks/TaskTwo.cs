using System;
using Layout;

namespace Selection.Papers.Selection_If_Else.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("Write a program that asks for a person’s age as an input and outputs one of the following messages depending upon their age:\n" +
                                 "a) If they are younger than 16 then it would output \"Youngster\"\n" +
                                 "b) If they are between 16 and 21 then it would output \"Young Adult\"\n" + 
                                 "c) If they are between 22 and 45 then it would output \"Adult\"\n" + 
                                 "d) If they were between 46 and 60 then it would output \"Middle Aged\"\n" + 
                                 "e) If they are over 60 then it would output \"Old\"", 
            "Task Two") {}

        enum Ages
        {
            Youngster = 0,
            YoungAdult = 16,
            Adult = 21,
            MiddleAged = 45,
            Old = 60,
        }
        
        public override void Run()
        {
            int age = Utils.AskUserInteger("Age");

            if (age <= (int) Ages.YoungAdult)
            {
                Console.WriteLine("You are a Youngster.");
            }
            else if (age <= (int) Ages.Adult)
            {
                Console.WriteLine("You are a Young Adult");
            }
            else if (age <= (int) Ages.MiddleAged)
            {
                Console.WriteLine("You are an Adult");
            }
            else if (age <= (int) Ages.Old)
            {
                Console.WriteLine("You are Middle Aged");    
            }
            else
            {
                Console.WriteLine("You are Old");    
            }
            
        }
    }
}