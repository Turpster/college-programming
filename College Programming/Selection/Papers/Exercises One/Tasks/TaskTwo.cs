using System;
using Layout;

namespace Selection.Papers.Exercises_One.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("An electronics company gives its customers the following discounts:\n" +
                                "*---------+---------+---------+-----------+-------------------+\n" +
                                "| < £1000 | < £2500 | < £5000 | < £10,000 | < £10,000 or more |\n" +
                                "| 0       | 5%      | 10%     | 15%       | 20%               |\n" +
                                "*---------+---------+---------+-----------+-------------------+\n" +
                                "Write a program to calculate and display the discounted price for orders, as in " +
                                "the following console session:\n" +
                                "Discount Orders\n" +
                                "\n" +
                                "Enter the value of the order: 5095\n" +
                                "\n" +
                                "The discounted price is 4330.75\n",
            "Task Two: Discounts") {}
        
        public override void Run()
        {
            Console.WriteLine("Discount Orders\n");
            double value = Utils.AskUserDouble("Enter the value of the order");
            
            value *= value < 1000 ? 0 : value < 2500 ? 0.05 : value < 5000 ? 0.1 : value < 10000 ? 0.15 : 0.2;
            
            Console.WriteLine("\nThe discounted price is {0:0.00}.", value);
        }
    }
}