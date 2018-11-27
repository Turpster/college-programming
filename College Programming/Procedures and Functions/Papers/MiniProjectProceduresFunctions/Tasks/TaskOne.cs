using Layout;

namespace Procedures_and_Functions.Papers.MiniProjectProceduresFunctions.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Write a program that does the following:\n" +
                                "The program is designed to work out the cost of building a garage and must first " +
                                "calculate the number of bricks required in order to estimate the cost. The builder " +
                                "is constrained to heights of 15 metres, length of 15 metres and width of 15 metres. " +
                                "The program will be required to accept the length, width and height and validate " +
                                "each of these to make sure they are between the values 0-15.\n" +
                                "The program will work out the cubic metre of the garage, and by general rule for " +
                                "every cubic metre there will be 50 bricks used.\n" +
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
        
        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}