using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Joe" , "Jill" , "Bob" , "Sam" , "Fred" };
            
            while (true)
            {
                Console.Write("1. Show the contents of the array.\n" +
                "2. Output the name of somebody if you type in the position number.\n" +
                "3. Search for a name in the array.\n");

                Console.Write("Selection: ");
                char key = Console.ReadKey().KeyChar;
                Console.WriteLine(".");

                if (key == '1')
                {
                    Console.Write("Contents: ");
                    foreach(string name in names)
                    {
                        Console.Write(name + " ");
                    }
                    Console.WriteLine(".");
                }
                else if (key == '2')
                {
                    int index;

                    while (true)
                    {
                        Console.Write("Position: ");
                        char indexChr = Console.ReadKey().KeyChar;
                        Console.WriteLine(".");
                        
                        try
                        {
                            index = int.Parse(indexChr.ToString());
                            break;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Invalid Format.");
                            continue;
                        }
                    }
                    if (index <= names.Length-1 && index >= 0)
                    {
                        Console.WriteLine("Index Object: " + names[index]);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Index..");
                        continue;
                    }

                }
                else if (key == '3')
                {
                    Console.Write("Enter Name: ");
                    string targetName = Console.ReadLine();

                    Boolean found = false;

                    foreach(string name in names)
                    {
                        if (String.Compare(name, targetName) == 0)
                        {
                            Console.WriteLine("Found in array.");
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                        Console.WriteLine("Could not find in array.");
                }
                else if (key == 'q')
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}