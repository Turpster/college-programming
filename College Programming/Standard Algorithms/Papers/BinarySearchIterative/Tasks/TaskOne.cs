using Layout;

namespace Standard_Algorithms.Papers.BinarySearchIterative.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("The algorithm below describes a binary search.  Implement this algorithm in a " +
                                "high-level programming language that you are familiar with.\n" +
                                "\n" +
                                "Procedure BinarySearch (List, First, Last, ItemSought)\n" +
                                "  ItemFound <- False\n" +
                                "  SearchFailed <- False\n" +
                                "  Repeat\n" +
                                "    Midpoint  (First + Last) DIV 2 \n" +
                                "  // Display a message saying which two items are being compared\n" +
                                "    If List[Midpoint] = ItemSought\n" +
                                "      Then ItemFound  True\n" +
                                "      Else\n" +
                                "        If First >= Last\n" +
                                "          Then SearchFailed  True\n" +
                                "          Else	\n" +
                                "            If List[Midpoint] > ItemSought\n" +
                                "              Then Last  Midpoint - 1\n" +
                                "              Else First  Midpoint + 1\n" +
                                "            EndIf\n" +
                                "        EndIf\n" +
                                "    EndIf\n" +
                                "  Until ItemFound OR SearchFailed\n" +
                                "  /*\n" +
                                "  If SearchFailed Then\n" +
                                "    Display a message saying “Item not it list”\n" +
                                "  Else\n" +
                                "    Display a message saying “Item found in the list”\n" +
                                "  EndIf\n" +
                                "  */\n" +
                                "EndProcedure\n" +
                                "\n" +
                                "The part of the pseudo code that is in italic red font is not part of the algorithm " +
                                "itself – it has been added so that after each pass through the loop the comparison " +
                                "that is being made is shown (this means you can see how the list is searched).\n" +
                                "As well as creating the procedure BinarySearch you will need to add some code to " +
                                "the main part of the program that calls the procedure.  Before calling the " +
                                "procedure your main program will have to declare an array to store the list in and " +
                                "put some values in the list to be sorted.\n" +
                                "Try your program out on the list in Figure 01 from Chapter 2.6 in the textbook."
            , "Paper Task") {}
        
        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}