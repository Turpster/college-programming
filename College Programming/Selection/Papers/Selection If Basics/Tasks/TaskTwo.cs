using Layout;

namespace Selection.Papers.Selection_If_Basics.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("The user will be asked to enter any number into the console. The program will " +
                                  "display ALL of the correct messages shown below that meet the conditions:\n" +
                                  "a) Number is equal to Zero\n" +
                                  "b) Number is not equal to Zero\n" + 
                                  "c) Number is Less than or equal to One\n" + 
                                  "d) Number is Greater than 10\n" + 
                                  "e) Number is between 1 and 20 inclusively", "Task Two") {}
        
        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}