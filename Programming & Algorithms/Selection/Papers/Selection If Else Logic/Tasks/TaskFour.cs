using System;
using Layout;

namespace Selection.Papers.Selection_If_Else_Logic.Tasks
{
    public class TaskFour : Task
    {
        public TaskFour() : base("a) Alter the program to allow cars of 2000CC or over – they will receive 60p per mile\n" +
                                 "b) Alter the program to ask the sales person if they need an overnight stay or not\n" +
                                 "  a.If they require one they will get paid £65 per night for the first 2 nights\n" +
                                 "  b. If they stay 3 or more nights they only get paid £40 for each night over this", 
            "Task Four") {}
        
        public override void Run()
        {
            int weeklyMillage = Utils.AskUserInteger("Weekly Mileage");
            int engineSize = Utils.AskUserInteger("Engine Size");
            string fuelType = Utils.AskUserString("Fuel Type");

            bool overnightStay = Utils.AskUserBoolean("Overnight Stay");
            
            int allowanceInPennies = weeklyMillage * ((fuelType.Equals("Diesel", StringComparison.OrdinalIgnoreCase) ? 3 : 0) + (engineSize > 1500 ? engineSize > 2000 ? 60 : 50 : 40));            
            
            Console.WriteLine("You will get paid £{0:0.00} per mile.", (double) allowanceInPennies / 100);
            
            Console.WriteLine(overnightStay ? "You will get paid £65 per night for the first 2 nights" : "If you stay 3 or more nights you will only get paid £40 for each night over this");

        }
    }
}