using System;
using System.Collections.Generic;
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
}