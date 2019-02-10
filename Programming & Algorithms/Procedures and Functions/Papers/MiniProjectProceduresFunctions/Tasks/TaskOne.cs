using System;
using Layout;

namespace Procedures_and_Functions.Papers.MiniProjectProceduresFunctions.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Write a program that does the following:\n" +
                                "The program is designed to work out the cost of building a garage and must first " +
                                "calculate the number of bricks required in order to estimate the cost. The builder " +
                                "is constrained to heights of 15 metres, length of 15 metres and width of 15 metres.\n" +
                                "The program will be required to accept the length, width and height and validate " +
                                "each of these to make sure they are between the values 0-15.\n" +
                                "The program will work out the cubic metre of the garage, and by general rule for " +
                                "every cubic metre (1m^3) there will be 50 bricks used.\n" +
                                "The program should display how many bricks (to the nearest whole brick) the builder " +
                                "will need to order and also the overall cost.\n" +
                                "------\n" +
                                "Functions Needed:\n" +
                                "- ValidateSize\n" +
                                "  - This will validate that the value entered lies within the range of 0-15. This will either return the validated size or it will return true/false\n" +
                                "- CalculateSize\n" +
                                "  - This will make use of the length, height and width to calculate the size of the garage and return the cubic metre size of the garage.\n" +
                                "- CalculateBricks\n" +
                                "  - This function will calculate the number of bricks required based on the cubic metre of the garage\n" +
                                "- CalculateCost\n" +
                                "  - If each brick costs 25p then this function will return the total cost of the garage ex. VAT by multiplying the number of bricks by 25p\n" +
                                "- CalculateVAT\n" +
                                "  - This will take a cost and calculate the VAT on the value, returning the VAT amount. (VAT is currently 20%)\n" +
                                "------\n" +
                                "Procedures Needed:\n" +
                                "- InputDimensions\n" +
                                "  - This procedure will call upon the ValidateSize function three times in order " +
                                "for the three dimensions of length, width and height to be entered. These will all " +
                                "be returned (using Ref) to the sub Main\n" +
                                "- DisplayCalculations\n" +
                                "  - This procedure will display the number of bricks needed, the cost ex.VAT and " +
                                "the cost inc.VAT\n" +
                                "\n"
            , "Paper Task"){}


        // Every cubic metre (1m^3) there will be 50 bricks used
        // The bricks are 2cm^3! Little small.
        private const double BrickSizeInCubicMetres = 1d / 50d;
        
        // Functions
        
        // This will validate that the value entered lies within the range of 0-15. This will either return the validated size or it will return true/false
        private static Tuple<bool, double> ValidateSize(double size)
        {
            return new Tuple<bool, double>(size > 0 && size <= 15, size);
        }
        // This will make use of the length, height and width to calculate the size of the garage and return the cubic metre size of the garage.
        private double CalculateSize(double length, double width, double height) // Parameter
        {
            return length * width * height;
        }
        
        // This function will calculate the number of bricks required based on the cubic metre of the garage
       
        // Interesting... So the garage is just made of solid bricks? Or am I missing some math formula?
        // That's like adding a math question in an english paper; a little harsh
        // lol
        private int CalculateBricks(double length, double width, double height)
        {
            return (int) Math.Ceiling(CalculateSize(length, width, height) / BrickSizeInCubicMetres);
        }
        
        // If each brick costs 25p then this function will return the total cost of the garage ex. VAT by multiplying the number of bricks by 25p
        private double CalculateCost(int totalBricks, double brickPrice=0.25)
        {
            return totalBricks * brickPrice;
        }

        // This will take a cost and calculate the VAT on the value, returning the VAT amount. (VAT is currently 20%
        private double CalculateVAT(double value)
        {            
            return value * (1 - 0.2);
        }
        
        // Procedures
        // This procedure will call upon the ValidateSize function three times in order 
        private void InputDimensions(ref double value)
        {
            Boolean runDimensionCheck = true;

            while (runDimensionCheck)
            {
                double val = Utils.AskUserDouble("Dimension");
                if (ValidateSize(val).Item1)
                {
                    value = val;
                    runDimensionCheck = false;
                }
                else
                {
                    Console.WriteLine("Invalid range (0-15).");
                }
            }
        }

        // This procedure will display the number of bricks needed, the cost ex.VAT and the cost inc.VAT
        private void DisplayCalculations(int numBricksNeeded, double finalCost)
        {
            Console.WriteLine("You need {0} bricks at a price of {1:C}", numBricksNeeded, finalCost);
        }
        
        public override void Run()
        {
            double width = 0, length = 0, height = 0;

            Console.WriteLine("Width");
            InputDimensions(ref width);
            Console.WriteLine("Length");
            InputDimensions(ref length);
            Console.WriteLine("Height");
            InputDimensions(ref height);
            
            int numBricks = CalculateBricks(length, width, height);
            double cost = CalculateCost(numBricks);
            double costVat = CalculateVAT(cost);
            DisplayCalculations(numBricks, costVat);
        }
        
        //this code that I have been forced to write makes me want to puke
    }
}