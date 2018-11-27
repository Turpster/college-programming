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
        
        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}