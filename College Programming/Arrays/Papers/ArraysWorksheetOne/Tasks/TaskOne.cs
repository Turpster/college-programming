using Layout;

namespace Arrays.Papers.ArraysWorksheetOne.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Set up an array of people’s names:\n" +
                                "String [] peopleNames = new string[5];\n" +
                                "PeopleNames[0] = “Joe”;\n" +
                                "PeopleNames[1] = “Jill”;\n" +
                                "PeopleNames[2] = “Bob”;\n" +
                                "PeopleNames[3] = “Sam”;\n" +
                                "PeopleNames[4] = “Fred”;\n" +
                                "Exercise one\n" +
                                "Using a form of selection and a menu system allow the user to select:\n" +
                                "1) Output the contents of the array\n" +
                                "2) Output the name of somebody if you type in the position number\n" +
                                "3) Search for a name in the array\n" +
                                "\n" +
                                "Hint:\n" +
                                "1) Use a for loop to loop through every element of the array\n" +
                                "2) Allow the user to enter a number into a variable, then output the array at this " +
                                "position\n" +
                                "3) Accept the users input of a name. Use a for loop to go through each element to " +
                                "see if the name is present\n" +
                                "Exercise two\n" +
                                "Create a program to accept 10 exam marks from the user into an array, and output:\n" +
                                "a) The lowest mark\n" +
                                "b) The highest mark\n" +
                                "c) The average mark\n" +
                                "Tip: Store the contents of the first array location in a temp variable and then use " +
                                "a for loop. Comparing the numbers each time. If the new number is smaller than the " +
                                "last, then store that in the temp variable, replacing it."
            , "Paper Task"){}

        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}