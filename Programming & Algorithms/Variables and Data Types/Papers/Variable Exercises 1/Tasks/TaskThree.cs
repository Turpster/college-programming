using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Variable_Exercises_1.Tasks
{
    public class TaskThree : Task
    {
        public TaskThree() : base("Alter question 2 to allow the user to then enter an amount of money that they have " +
                                  "given to the shop keeper e.g. £10.00. The program should work out how much change " +
                                  "is due and output the amount tendered and the amount of change given.",
            "Task Three")
        {}

        public override void Run()
        {
            string pc = Utils.AskUserString("P/C");
            string desc = Utils.AskUserString("Desc");
            double price = Utils.AskUserDouble("Price");
            int quantity = Utils.AskUserInteger("Quantity");
            double total = price * quantity;
            
            Console.WriteLine("P/C:   {0}\n" +
                              "Desc:  {1}\n" +
                              "U/Prc: £{2:0.00}\n" +
                              "Qty:   {3}\n" +
                              "Total: £{4:0.00}", pc, desc, price, quantity, total);

            double amountGiven = Utils.AskUserDouble("Amount of money you have given to the shop keeper");

            if (amountGiven < total)
            {
                Console.WriteLine("You have spent £{0:0.00} and the product is £{1:0.00}. You need to pay more.", amountGiven, total);
            }
            else
            {
                Console.WriteLine("You have £{0:0.00} change.", amountGiven - total);
            }
        }
        
    }
}