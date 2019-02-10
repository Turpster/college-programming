using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Layout
{
    public static class Utils
    {
        public static DateTime AskUserTime(string demand = "Input a time")
        {
            demand += " (h:mm:ss tt eg. 7:25:10 pm)";
            while (true)
            {
                try
                {
                    string date = AskUserString(demand);
                    return DateTime.ParseExact(date, "h:mm:ss tt", CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format, make sure you are using a valid date format.");
                }
            }
        }

        public static DateTime AskUserDateTime(string demand = "Input a datetime")
        {
            demand += " (dd/MM/yyyy h:mm:ss tt eg. 21/10/2001 7:25:10 am)";

            while (true)
            {
                try
                {
                    string date = AskUserString(demand); // my birthday ^-^
                    return DateTime.ParseExact(date, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format, make sure you are using a valid date format.");
                }
            }
        }

        public static DateTime AskUserDate(string demand = "Input a date")
        {
            demand += " (DD/MM/YYYY)";
            while (true)
            {
                try
                {
                    string date = AskUserString(demand);
                    return DateTime.Parse(date);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format, make sure you are using a valid date format.");
                }
            }
        }

        public static bool AskUserBoolean(string demand = "")
        {
            demand += "(Yes | No)";

            while (true)
            {
                string answer = AskUserString(demand);

                if (answer.Equals("Yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
                else if (answer.Equals("No", StringComparison.InvariantCultureIgnoreCase))
                {
                    return false;
                }

                Console.WriteLine("Invalid Input.");
            }
        }

        public static string[] AskUserNameAndSurname(string demand = "Full name (lastname,firstname)")
        {
            string[] nameSplit = AskUserString(demand).Split(',');
            if (nameSplit.Length != 2)
            {
                Console.WriteLine(demand);
                return AskUserNameAndSurname();
            }

            return nameSplit;
        }

        public static string AskUserString(string demand = "Input")
        {
            bool running = true;
            string input = "";

            while (running)
            {
                Console.Write(demand + ": ");

                input = Console.ReadLine();
                if (input.Length == 0)
                {
                    Console.WriteLine("Please write letters...");
                }
                else running = false;
            }

            return input;
        }

        public static char AskUserChar(string demand = "Input")
        {
            Console.Write(demand + ": ");
            char key = Console.ReadKey().KeyChar;
            Console.Write(".\n");
            return key;

        }

        public static double AskUserDouble(string demand = "Please input a number")
        {
            while (true)
            {
                Console.Write(demand + ": ");
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number.");
                }
            }
        }

        public static int AskUserInteger(string demand = "Please input a number")
        {
            while (true)
            {
                Console.Write(demand + ": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number.");
                }
            }
        }

        public static string GetDaySuffix(int day)
        {
            switch (day)
            {
                case 1:
                case 21:
                case 31:
                    return "st";
                case 2:
                case 22:
                    return "nd";
                case 3:
                case 23:
                    return "rd";
                default:
                    return "th";
            }
        }
    }

    public class ExpressionParser
    {
        /*
         * @param exp The expression given
         * @param vars A dictionary of variables, such as x=15, y=20 etc.
         */
        public double Eval(String exp)
        {
            return Eval(exp, new Dictionary<string, double>());
        }

        public double Eval(String exp, Dictionary<String, Double> vars)
        {
            if (exp == "")
            {
                return 0.0;
            }

            int bracketCounter = 0;
            int operatorIndex = -1;

            for (int i = 0; i < exp.Length; i++)
            {
                char c = exp.ToCharArray()[i];
                if (c == '(') bracketCounter++;
                else if (c == ')') bracketCounter--;
                else if ((c == '+' || c == '-') && bracketCounter == 0)
                {
                    operatorIndex = i;
                    break;
                }
                else if ((c == '*' || c == '/') && bracketCounter == 0 && operatorIndex < 0)
                {
                    operatorIndex = i;
                }
            }

            if (operatorIndex < 0)
            {
                exp = exp.Trim();
                if (exp.ToCharArray()[0] == '(' && exp.ToCharArray()[exp.Length - 1] == ')')
                    return Eval(exp.Substring(1, exp.Length - 1), vars);
                else if (vars.ContainsKey(exp))
                    return vars[exp];
                else
                    return Double.Parse(exp);
            }
            else
            {
                switch (exp.ToCharArray()[operatorIndex])
                {
                    case '+':
                        return Eval(exp.Substring(0, operatorIndex), vars) +
                               Eval(exp.Substring(operatorIndex + 1), vars);
                    case '-':
                        return Eval(exp.Substring(0, operatorIndex), vars) -
                               Eval(exp.Substring(operatorIndex + 1), vars);
                    case '*':
                        return Eval(exp.Substring(0, operatorIndex), vars) *
                               Eval(exp.Substring(operatorIndex + 1), vars);
                    case '/':
                        return Eval(exp.Substring(0, operatorIndex), vars) /
                               Eval(exp.Substring(operatorIndex + 1), vars);
                }
            }

            return 0;
        }
    }


    namespace Table
    {
        public struct Position
        {
            public int X;
            public int Y;

            public Position(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
            }
        }

        public class Table
        {


            public int Width;
            public int Height;

            public readonly Dictionary<Position, TableEntry> TableEntries = new Dictionary<Position, TableEntry>();

            public Table(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public void AddEntry(KeyValuePair<Position, TableEntry> entry)
            {
                if (TableEntries.ContainsKey(new Position(entry.Key.X, entry.Key.Y)))
                {
                    TableEntries.Add(entry.Key, entry.Value);
                }
                else
                {
                    throw new DataException("Table Entry already exists in same position");
                }

            }

            public void AddEntries(KeyValuePair<Position, TableEntry>[] entries)
            {
                foreach (KeyValuePair<Position, TableEntry> entry in entries)
                {
                    TableEntries.Add(entry.Key, entry.Value);
                }
            }


            public string GetDisplay()
            {
                string table = "";

                for (int y = 0; y < Height; y++)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        table += GetEntryWithSpace(x, y);
                    }

                    table += "\n";
                }

                return table;
            }

            public string GetColumns(int[] columns)
            {
                string table = "";

                foreach (int y in columns)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        table += GetEntryWithSpace(x, y);
                    }

                    table += "\n";
                }

                return table;
            }

            public string GetRows(int[] rows)
            {
                string table = "";

                foreach (int x in rows)
                {
                    for (int y = 0; y < Height; y++)
                    {
                        table += GetEntryWithSpace(x, y);
                    }

                    table += "\n";
                }

                return table;
            }

            public Position? SearchPosition(string displayOutput)
            {
                for (int x = 0; x < Width; x++)
                {
                    for (int y = 0; y < Height; y++)
                    {
                        TableEntries.TryGetValue(new Position(x, y), out TableEntry targetEntry);

                        if (targetEntry.GetDisplay().Equals(displayOutput, StringComparison.InvariantCultureIgnoreCase))
                        {
                            return new Position(x, y);
                            ;
                        }
                    }
                }

                return null;
            }

            public Position? SearchPositionColumn(string displayOutput, int column)
            {
                for (int x = 0; x < Width; x++)
                {
                    TableEntries.TryGetValue(new Position(x, column), out TableEntry targetEntry);
                    if (targetEntry != null)
                    {
                        throw new DataException("Invalid column location");
                    }

                    if (targetEntry.GetDisplay().Equals(displayOutput, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return new Position(x, column);

                    }
                }

                return null;
            }

            public Position? SearchPositionRow(string displayOutput, int row)
            {
                for (int y = 0; y < Height; y++)
                {
                    TableEntries.TryGetValue(new Position(row, y), out TableEntry targetEntry);
                    if (targetEntry != null)
                    {
                        if (targetEntry.GetDisplay().Equals(displayOutput, StringComparison.InvariantCultureIgnoreCase))
                        {
                            return new Position(row, y);
                        }
                    }
                }
                for (int y = 0; y < Height; y++)
                {
                    TableEntries.TryGetValue(new Position(row, y), out TableEntry targetEntry);
                    if (targetEntry != null)
                    {
                        if (targetEntry.GetDisplay().Contains(displayOutput, StringComparison.InvariantCultureIgnoreCase))
                        {
                            return new Position(row, y);
                        }
                    }
                }

                return null;
            }

            private string GetEntryWithSpace(int x, int y)
            {
                string entry = "";

                TableEntries.TryGetValue(new Position(x, y), out TableEntry targetEntry);

                if (targetEntry == null) throw new DataException("Invalid Table Entry Position");
                int spaces = GetSpaceWidth() - targetEntry.GetDisplay().Length;
                entry += targetEntry.GetDisplay() + new string(' ', spaces);

                return entry;
            }

            public Position? GetLocation(TableEntry tableEntry)
            {
                for (int x = 0; x < Width; x++)
                {
                    for (int y = 0; y < Height; y++)
                    {
                        if (TableEntries[new Position(x, y)] == tableEntry)
                        {
                            return new Position(x, y);
                        }
                    }
                }

                return null;
            }

            private int GetSpaceWidth(int spaces = 1)
            {
                int maxWidth = 2;

                foreach (TableEntry entry in TableEntries.Values)
                {
                    if (entry.GetDisplay().Length > maxWidth) maxWidth = entry.GetDisplay().Length;
                }

                return maxWidth + spaces;
            }

            public TableEntry[] GetEntriesInRow(int row)
            {
                List<TableEntry> entries = new List<TableEntry>();

                if (!Enumerable.Range(0, Width).Contains(row))
                {
                    throw new DataException("Invalid row");
                }

                for (int y = 0; y < Height; y++)
                {
                    TableEntries.TryGetValue(new Position(row, y), out TableEntry targetEntry);

                    entries.Add(targetEntry);
                }

                return entries.ToArray();
            }

            public TableEntry[] GetEntriesInColumn(int column)
            {
                List<TableEntry> entries = new List<TableEntry>();

                if (!Enumerable.Range(0, Height).Contains(column))
                {
                    throw new DataException("Invalid column");
                }

                for (int x = 0; x < Width; x++)
                {
                    TableEntries.TryGetValue(new Position(x, column), out TableEntry targetEntry);

                    entries.Add(targetEntry);
                }

                return entries.ToArray();
            }
        }

        public abstract class TableEntry
        {
            public readonly Table Table;
            public abstract string GetDisplay();

            public TableEntry(Table parentTable)
            {
                Table = parentTable;
            }

            public Position GetLocation()
            {

                Position? targetPosition = Table.GetLocation(this);
                if (targetPosition.HasValue)
                {
                    return targetPosition.Value;
                }

                throw new DataException(
                    "Could not get location. Please make sure width and height bounds are set correctly.");
            }
        }

        public class FigureName : TableEntry
        {
            public readonly string Name;

            public FigureName(Table parentTable, string name) : base(parentTable)
            {
                Name = name;
            }

            public override string GetDisplay()
            {
                return Name;
            }
        }

        public class FigureEntry : TableEntry
        {
            public readonly double Score;

            public FigureEntry(Table parentTable, double score) : base(parentTable)
            {
                Score = score;
            }

            public override string GetDisplay()
            {
                return Score.ToString();
            }
        }
        public class CurrencyFigureEntry : FigureEntry
        {
            public CurrencyFigureEntry(Table parentTable, double score) : base(parentTable, score) {}
        
            public override string GetDisplay()
            {
                return string.Format("{0:C}", Score);
            }
        }
    }
    public class BubbleSort
{
    private bool _numbersAreSorted = false;

    public float[] Sort(float[] _list)
    {
        float num1;
        float num2;

        while (!_numbersAreSorted)
        {
            _numbersAreSorted = true;
            for (int i = 0; i < _list.Length - 1; i++)
            {
                num1 = _list[i];
                num2 = _list[i + 1];
                if (num1 > num2)
                {
                    _list[i] = num2;
                    _list[i + 1] = num1;
                    i--;
                    _numbersAreSorted = false;
                }
            }
        }

        return _list;
    }
}
}
