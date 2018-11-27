using Layout;

namespace Arrays.Papers.ArraysWorksheetTwo.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("1) Products\n" +
                                "Here are details of 5 products:\n" +
                                "Product		    Price\n" +
                                "\n" + 
                                "MP3 Player		    46.50\n" +
                                "Docking Station	123.25\n" +
                                "50” TV		        499.50\n" +
                                "Digital Camera	    84.00\n" +
                                "SD Card 64GB	    35.39\n" +
                                "1) Allows you to set up the details into two arrays.\n" +
                                "2) Outputs all the details as above\n" +
                                "3) Allows a search for a product then outputs that product’s price - or gives a " +
                                "message ‘no such product’\n" +
                                "4) Allows a search for a price then outputs that product’s details - or gives a " +
                                "message ‘no such price’\n" +
                                "2) Prisoner example\n" +
                                "Here are details of 5 prisoners:\n" +
                                "Name		Age	Cell Number		Sentence in Years\n" +
                                "Fred		46		4			5\n" +
                                "Bill		33		3			1\n" +
                                "Mary		42		2			10\n" +
                                "Jean		30		11			11\n" +
                                "Martin		35		12			15\n" +
//                              "Reece      17    My Head       Rest of Life\n" +
                                "\n" +
                                "You need to write a program which does the following:\n" +
                                "1) Allows you to set up the details into four arrays.\n" +
                                "2) Outputs all the details\n" +
                                "3) Outputs all details for those prisoners who have a sentence of 10 years or more\n" +
                                "4) Outputs the name age and cell for prisoners who have a cell number of less than 10\n" +
                                "5) Outputs the name of those prisoners who will be 50 or over at the end of their " +
                                "sentence\n" +
                                "6) Allows a search for a name then outputs that persons details - or gives a message " +
                                "'no such name'\n" +
                                "7) Allows a search for a cell then outputs that persons details - or gives a message " +
                                "'no such cell'\n"
            , "Paper Task"){}

        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}