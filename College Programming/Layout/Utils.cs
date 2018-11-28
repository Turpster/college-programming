using System;
using System.Globalization;
using System.Linq.Expressions;

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
        
        public static string AskUserString(string demand = "Input")
        {
            Console.Write(demand + ": ");
            return Console.ReadLine();

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
    }
}