using System;
using System.Collections.Generic;
using System.Linq;
using Layout;
using Layout.Table;

namespace Arrays.Papers.Twelve_Days_of_Christmas.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Over the twelve days of Christmas – a number of gifts have been sent – these " +
                                "include a partridge in a pear tree, Lords-a-Leaping and Turtle Doves as well as " +
                                "many more. Not always do gifts come free – and the sender of the gifts wanted to " +
                                "know the true cost of Christmas!\n" +
                                "You have been asked to write a program that calculates the total cost of all gifts " +
                                "as well as allows the user to select a certain day – and the program will calculate " +
                                "the cost of all the gifts of that particular day. We must be able to enter the name " +
                                "of a gift and the program will tell us how many of those have been bought also.\n" +
                                "The gifts are as follows:\n" +
                                "Partridge in a pear tree: £29.50\n" +
                                "Turtle Dove               £25\n" +
                                "French Hen                £12\n" +
                                "Calling Bird              £18\n" +
                                "Gold Ring                 £60\n" +
                                "Geese-a-laying            £48\n" +
                                "Swan-a-swimming		   £480\n" +
                                "Maid-a-walking            £120\n" +
                                "Lady dancing              £202.80\n" +
                                "Lord-a-leeping            £292.50\n" +
                                "Piper Piping              £97.75\n" +
                                "Drummer Drumming          £205\n" +
                                "Examples of output:\n" +
                                "On the 1st day of Christmas my true love spent:  £29.50 and bought 1 x Partridge " +
                                "in a pear tree.\n" +
                                "--------\n" +
                                "On the 3rd day of Christmas my true love spent:\n" +
                                "	1 x partridge in a pear tree    - £29.50\n" +
                                "	2 x Turtle Doves                - £50\n" +
                                "	3 x French Hens                 - £36\n" +
                                "\n" +
                                "   Total:                            £115.50\n" +
                                "--------\n" +
                                "Further Guidance\n" +
                                "On the 10th day of Christmas - the shop keeper started to offer discount due to the " +
                                "excessive amount of gifts that were bought. 10% on the 10th day - 11% on the 11th " +
                                "day and 12% on the 12th day.\n" +
                                "Deadline: Entries to be handed to Darren by 4.20 on Tuesday 12th December\n" +
                                "(Prizes will be given on either Wednesday or Thursday)\n" +
                                
                                "Prizes: There will be a number of prizes to give away e.g. for the first " +
                                "completed solution that works / for the most improved programming / the most efficient"
            , "Paper Task"){}

        public override void Run()
        {
            Table table = new Table(2, 12);
            table.AddEntries(new []
            {
                new KeyValuePair<Position, TableEntry>(new Position(0, 0), new FigureName(table, "Partridge in a pear tree")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 1), new FigureName(table, "Turtle Dove")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 2), new FigureName(table, "French Hen")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 3), new FigureName(table, "Calling Bird")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 4), new FigureName(table, "Gold Ring")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 5), new FigureName(table, "Geese-a-laying")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 6), new FigureName(table, "Swan-a-swimming")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 7), new FigureName(table, "Maid-a-walking")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 8), new FigureName(table, "Lady dancing")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 9), new FigureName(table, "Lord-a-leeping")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 10), new FigureName(table, "Piper Piping")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 11), new FigureName(table, "Drummer Drumming")), 
               
                new KeyValuePair<Position, TableEntry>(new Position(1, 0), new CurrencyFigureEntry(table, 25)), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 1), new CurrencyFigureEntry(table, 25)), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 2), new CurrencyFigureEntry(table, 12)), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 3), new CurrencyFigureEntry(table, 18)), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 4), new CurrencyFigureEntry(table, 60)), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 5), new CurrencyFigureEntry(table, 48)), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 6), new CurrencyFigureEntry(table, 480)), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 7), new CurrencyFigureEntry(table, 120)), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 8), new CurrencyFigureEntry(table, 202)),
                new KeyValuePair<Position, TableEntry>(new Position(1, 9), new CurrencyFigureEntry(table, 292*0.9)),
                new KeyValuePair<Position, TableEntry>(new Position(1, 10), new CurrencyFigureEntry(table, 97.75*0.89)), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 11), new CurrencyFigureEntry(table, 205*0.88))
            });
            
            Console.WriteLine("1) Output total cost of all gifts");
            Console.WriteLine("2) Output a day you received a gift from your true love");
            Console.WriteLine("3) Search how many of a gift have been brought");
            Console.WriteLine("4) Quit");

            int selection = Utils.AskUserInteger("Selection");

            if (selection == 1)
            {
                double total = 0;

                foreach (TableEntry tableEntry in table.GetEntriesInRow(1))
                {
                    if (tableEntry.GetType() == typeof(CurrencyFigureEntry))
                    {
                        total += ((CurrencyFigureEntry) tableEntry).Score;
                    }
                }
                    
                Console.WriteLine("Total: {0:C}", total);
            }
            else if (selection == 2)
            {
                int day = Utils.AskUserInteger("Day");

                if (Enumerable.Range(1, table.Height).Contains(day))
                {
                    Table editedTable = table;
                    editedTable.Height = day;
                    for (; day <= table.Height; day++)
                    {
                        editedTable.TableEntries.Remove(new Position(0, day));
                        editedTable.TableEntries.Remove(new Position(1, day));
                    }
                    
                    Console.WriteLine(editedTable.GetDisplay());
                }
                else
                {
                    Console.WriteLine("Invalid day");
                }
            }
            else if (selection == 3)
            {
                Position? position = table.SearchPositionRow(Utils.AskUserString("Search"), 0);
                if (position.HasValue)
                {
                    Console.WriteLine("{0} have been sold.", position.Value.Y + 1);
                }
                else
                {
                    Console.WriteLine("Could not find that value");
                }
            }
            if (selection != 4)
            {
                Run();
            }
            else
            {
                Console.WriteLine("Merry Christmas");
            }
        }
    }
}