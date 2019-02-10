using System;
using System.Collections.Generic;
using Layout;
using Layout.Table;

namespace Arrays.Papers.ArraysWorksheetTwo.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("1) Products\n" +
                                "Here are details of 5 products:\n" +
                                "\n" +
                                "Product		    Price\n" + 
                                "MP3 Player		    46.50\n" +
                                "Docking Station	123.25\n" +
                                "50” TV		        499.50\n" +
                                "Digital Camera	    84.00\n" +
                                "SD Card 64GB	    35.39\n" +
                                "\n" +
                                "1) Allows you to set up the details into two arrays.\n" +
                                "2) Outputs all the details as above\n" +
                                "3) Allows a search for a product then outputs that product’s price - or gives a " +
                                "message ‘no such product’\n" +
                                "4) Allows a search for a price then outputs that product’s details - or gives a " +
                                "message ‘no such price’\n" +
                                "2) Prisoner example\n" +
                                "Here are details of 5 prisoners:\n" +
                                "\n" +
                                "Name		Age	Cell Number		Sentence in Years\n" +
                                "Fred		46		4			5\n" +
                                "Bill		33		3			1\n" +
                                "Mary		42		2			10\n" +
                                "Jean		30		11			11\n" +
                                "Martin		35		12			15\n" +
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
            Table table = new Table(2, 6);
            table.AddEntries(new []
            {
                new KeyValuePair<Position, TableEntry>(new Position(0, 0), new FigureName(table, "Product")), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 0), new FigureName(table, "Price")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 1), new FigureName(table, "MP3 Player")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 2), new FigureName(table, "Docking Station")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 3), new FigureName(table, "50\" TV")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 4), new FigureName(table, "Digital Camera")), 
                new KeyValuePair<Position, TableEntry>(new Position(0, 5), new FigureName(table, "SD Card 64GB")), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 1), new CurrencyFigureEntry(table, 46.50)), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 2), new CurrencyFigureEntry(table, 123.25)), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 3), new CurrencyFigureEntry(table, 499.50)), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 4), new CurrencyFigureEntry(table, 84.00)), 
                new KeyValuePair<Position, TableEntry>(new Position(1, 5), new CurrencyFigureEntry(table, 35.39)) 
            });
            Console.WriteLine("1) Output details\n" +
                              "2) Search for product and get price\n" +
                              "3) Search for price and get product details\n" +
                              "4) Quit");
            
            int selection = Utils.AskUserInteger("Selection");

            if (selection == 1)
            {
                Console.WriteLine(table.GetDisplay());
            }
            else if (selection == 2)
            {
                Position? position = table.SearchPositionRow(Utils.AskUserString("Search Product"), 0);

                if (position.HasValue)
                {
                    Console.WriteLine(table.GetColumns(new[] {0, position.Value.Y}));
                }
                else
                {
                    Console.WriteLine("Could not find entry");
                }
            }
            else if (selection == 3)
            {
                Position? position = table.SearchPositionRow(Utils.AskUserString("Search Price"), 1);

                if (position.HasValue)
                {
                    Console.WriteLine(table.GetColumns(new[] {0, position.Value.Y}));
                }
                else
                {
                    Console.WriteLine("Could not find price");
                }
            }
            if (selection != 4)
            {
                Run();
            }
        }
    }
}