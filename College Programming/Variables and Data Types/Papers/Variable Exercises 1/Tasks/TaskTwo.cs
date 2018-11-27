using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Variable_Exercises_1.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("Produce a program that allows you to enter a product code, a name of a product, a " +
                                "price for the product and the quantity you would like to buy. The program will then " +
                                "calculate the total cost and output this information in the following format: \n" + 
                                "P/C:  	XY102\n" +
                                "Desc:	12V Battery\n" +
                                "U/Prc:	£0.87\n" +
                                "Qty:	10\n" +
                                "Total:	£8.70",
            "Task Two")
        {}

        public override void Run()
        {
            string pc = Utils.AskUserString("P/C");
            string desc = Utils.AskUserString("Desc");
            int price = Utils.AskUserInteger("Desc");
            int quantity = Utils.AskUserInteger("Desc");
            int total = price * quantity;
            
            Console.WriteLine("P/C:   {0}\n" +
                              "Desc:  {1}\n" +
                              "U/Prc: £{2}\n" +
                              "Qty:   {3}\n" +
                              "Total: £{4}", pc, desc, price, quantity, total);
        }
        
    }
}