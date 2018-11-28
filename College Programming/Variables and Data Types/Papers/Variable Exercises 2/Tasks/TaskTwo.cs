using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Variable_Exercises_2.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("Liverchester FC Supporters Club organises coaches to take members to away matches. " +
                                "Between 8am and 9am members turn up at the home ground where there is a line of " +
                                "coaches. They always board the front coach. When a coach is full, it sets off. At " +
                                "9am the current front coach sets off, whether or not it is full. Write a program to " +
                                "carry out the following tasks:" +
                                "Input the total number of club members travelling to a match\n" +
                                "Input the seating capacity of a coach (assume they are all the same)\n" +
                                "Output the number of full coaches\n" +
                                "Output the number of passengers on the last coach",
            "Task Two")
        {}

        public override void Run()
        {
            int numOfClubMembersTravelling = Utils.AskUserInteger("Club Members travelling");
            int seatingCapacityOfCoach = Utils.AskUserInteger("The Seating capacity of each coach");
            
            Console.WriteLine("{0} full\n" +
                              "{1} is the seating capacity of the last coach", 
                Math.Floor((double) numOfClubMembersTravelling / seatingCapacityOfCoach), 
                numOfClubMembersTravelling % seatingCapacityOfCoach);
        }
        
    }
}