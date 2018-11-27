using Layout;

namespace Selection.Papers.Selection_If_Else_Logic.Tasks
{
    public class TaskThree : Task
    {
        public TaskThree() : base("A sales person is allowed an allowance depending upon the amount of miles that " +
                                  "they travel and the type of car that they own. The program will allow the user to " +
                                  "enter a weekly mileage, engine size and fuel type and give an allowance amount to " +
                                  "the user.\n" +
                                  "- The sales person will get paid 40p per mile for a car of 1500CC engine or less\n" +
                                  "- The sales person will get paid 50p per mile for a car with over 1500CC engine\n" +
                                  "- If the car is Diesel they will get paid an additional 3p per mile", 
            "Task Three") {}
        
        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}