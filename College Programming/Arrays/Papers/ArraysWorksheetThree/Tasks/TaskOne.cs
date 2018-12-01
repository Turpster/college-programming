using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using Layout;
using Layout.Table;

namespace Arrays.Papers.ArraysWorksheetThree.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("1) Create two arrays to hold the following data:\n" +
                                "    a. One array for names and one array (2D array) for the figures.\n" +
                                "           Jan Feb March\n" +
                                "    Bob    4   6   4\n" +
                                "    Pete   6   3   5\n" +
                                "    Jill   8   4   5\n" +
                                "    Jack   10  8   5\n" +
                                "    Do the following as a series of menu options. It may be easier to put each one in " +
                                "    its own sub procedure and call these from the menu (see YouTube video for help)\n" +
                                "2) Hard code the data above into the two arrays\n" +
                                "    Note: Months is not an array because this will just be headings\n" + 
                                "3) Code the following menu options:\n" +
                                "    a. Output the array\n" +
                                "            i. Use a nested For Loop output the entire contents of the array to be formatted as above.\n" + 
                                "        b. Month to Output\n" +
                                "            i. Let the user enter a month number and it will only output all of that particular months details. I.e.\n" +
                                "           e.g. User enters 2\n" +
                                "                   Feb\n" +
                                "           Bob     6\n" +
                                "           Pete    3\n" +
                                "           Jill    4\n" +
                                "           Jack    8\n" +
                                "    c. Search for name\n" +
                                "        i. Output that persons sales for the quarter if the user types in name\n" +
                                "    d. Work out the total sales for each person for the quarter\n" +
                                "    e. Work out the total sales for each month\n" +
                                "4) What would you do if you wanted to record car details for the years 2012 – 2015?"
            , "Tasks 1 to 3") {}

        public override void Run()
        {
            Table table = new Table(4, 5);
            
            table.AddEntries(new []
            {
                new KeyValuePair<Position, TableEntry>(new Position(0,0), new FigureName(table, "")),
                new KeyValuePair<Position, TableEntry>(new Position(1,0), new FigureName(table, "Jan")),
                new KeyValuePair<Position, TableEntry>(new Position(2,0), new FigureName(table, "Feb")),
                new KeyValuePair<Position, TableEntry>(new Position(3,0), new FigureName(table, "March")),
                new KeyValuePair<Position, TableEntry>(new Position(0,1), new FigureName(table, "Bob")),
                new KeyValuePair<Position, TableEntry>(new Position(1,1), new FigureEntry(table, 4)),
                new KeyValuePair<Position, TableEntry>(new Position(2,1), new FigureEntry(table, 6)),
                new KeyValuePair<Position, TableEntry>(new Position(3,1), new FigureEntry(table, 4)),
                new KeyValuePair<Position, TableEntry>(new Position(0,2), new FigureName(table, "Pete")),
                new KeyValuePair<Position, TableEntry>(new Position(1,2), new FigureEntry(table, 6)),
                new KeyValuePair<Position, TableEntry>(new Position(2,2), new FigureEntry(table, 3)),
                new KeyValuePair<Position, TableEntry>(new Position(3,2), new FigureEntry(table, 5)),
                new KeyValuePair<Position, TableEntry>(new Position(0,3), new FigureName(table, "Jill")),
                new KeyValuePair<Position, TableEntry>(new Position(1,3), new FigureEntry(table, 8)),
                new KeyValuePair<Position, TableEntry>(new Position(2,3), new FigureEntry(table, 4)),
                new KeyValuePair<Position, TableEntry>(new Position(3,3), new FigureEntry(table, 5)),
                new KeyValuePair<Position, TableEntry>(new Position(0,4), new FigureName(table, "Jack")),
                new KeyValuePair<Position, TableEntry>(new Position(1,4), new FigureEntry(table, 10)),
                new KeyValuePair<Position, TableEntry>(new Position(2,4), new FigureEntry(table, 8)),
                new KeyValuePair<Position, TableEntry>(new Position(3,4), new FigureEntry(table, 5))
            });            
            Console.WriteLine("3) Code the following menu options:\n" +
                              "    a. Output the array\n" +
                              "           i. Use a nested For Loop output the entire contents of the array to be formatted as above.\n" + 
                              "    b. Month to Output\n" +
                              "           i. Let the user enter a month number and it will only output all of that particular months details. I.e.\n" +
                              "           e.g. User enters 2\n" +
                              "                   Feb\n" +
                              "           Bob     6\n" +
                              "           Pete    3\n" +
                              "           Jill    4\n" +
                              "           Jack    8\n" +
                              "    c. Search for name\n" +
                              "        i. Output that persons sales for the quarter if the user types in name\n" +
                              "    d. Work out the total sales for each person for the quarter\n" +
                              "    e. Work out the total sales for each month\n" +
                              "    \n" +
                              "    q. quit");
            
            char selection = Utils.AskUserChar("Selection");

            if (selection == 'a')
            {
                Console.WriteLine(table.GetDisplay());
            }
            else if (selection == 'b')
            {
                int selectedMonth = Utils.AskUserInteger("Month Number to output");
                
                if (Enumerable.Range(1, 3).Contains(selectedMonth))
                    Console.WriteLine(table.GetRows(new[] {0, selectedMonth}));
                else
                    Console.WriteLine("Invalid Month");
            }
            else if (selection == 'c')
            {
                Position? position = table.SearchPositionRow(Utils.AskUserString("Search Name"), 0);

                if (position.HasValue)
                {
                    Console.WriteLine(table.GetColumns(new[] {0, position.Value.Y}));
                }
                else
                {
                    Console.WriteLine("Could not find entry");
                }
            }
            else if (selection == 'd')
            {
                for (int y = 1; y < table.Height; y++)
                {
                    double total = 0;

                    foreach (TableEntry tableEntry in table.GetEntriesInColumn(y))
                    {
                        if (tableEntry.GetType() == typeof(FigureEntry))
                        {
                            total += ((FigureEntry) tableEntry).Score;
                        }
                    }
                    
                    table.TableEntries.TryGetValue(new Position(0, y), out TableEntry entry);
                    Console.WriteLine("{0}: {1:0}", entry.GetDisplay(), total);
                }
            }
            else if (selection == 'e')
            {
                for (int x = 1; x < table.Width; x++)
                {
                    double total = 0;

                    foreach (TableEntry tableEntry in table.GetEntriesInRow(x))
                    {
                        if (tableEntry.GetType() == typeof(FigureEntry))
                        {
                            total += ((FigureEntry) tableEntry).Score;
                        }
                    }
                    
                    table.TableEntries.TryGetValue(new Position(x, 0), out TableEntry entry);
                    Console.WriteLine("{0}: {1:0}", entry.GetDisplay(), total);
                }
            }

            if (selection != 'q')
            {
                Run();
            }
        }
    }
}