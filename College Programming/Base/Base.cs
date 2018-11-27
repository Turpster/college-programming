using System;
using System.Collections.Generic;

namespace Base
{
    public class Base
    {
        List<Project> projects;
        
        public static void Main(string[] args)
        {
            new Base();
        }

        private enum Selection
        {
            SelectTask=1,
            RunWholeProject=2,
            RunAllTasks=3,
            Quit=4
        }
        
        public Base()
        {
            while (true)
            {
                string[] welcomeMsg =
                {
                    "--=== College Programming ===--",
                    "Developer: Turpster (or Reece)",
                    "Tutor: Darren",
                    "",
                    "1) Select a task to run.",
                    "2) Run a whole project.",
                    "3) Run all tasks from every project.",
                    "4) Quit.",
                    ""
                };
                Console.WriteLine(welcomeMsg);
                Console.Write("Selection: ");
                int selection = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.WriteLine(".\n\n");
                if (selection == (int) Selection.SelectTask)
                {
                    Project project;
                    while (true)
                    {
                        try
                        {
                            project = projects[GetValidInt("Project: ") - 1];
                            break;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Please input a valid project number, 1 to {0}.", projects.Count);
                        }
                    }
                    
                    Paper paper;
                    while (true)
                    {
                        try
                        {
                            paper = project.Papers[GetValidInt("Project: ") - 1];
                            break;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Please input a valid paper number, 1 to {0}.", project.Papers.Length);
                        }
                    }

                    Task task;
                    while (true)
                    {
                        try
                        {
                            task = paper.Tasks[GetValidInt("Task: ") - 1];
                            break;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Please input a valid project number, 1 to {0}.", paper.Tasks.Length);
                        }
                    }
                    
                    Console.Write("\n\n---\n{0}\n\n", task.Question); // TODO Might of overdone the line breaks
                    task.Run();
                }
                else if (selection == (int) Selection.RunWholeProject)
                {
                    Project targetProject;
                    while (true)
                    {
                        var sel = GetValidInt("Project Number");
                        try
                        {
                            targetProject = projects[sel - 1];
                            break;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Project number is out of range, 1 to {0} and your selection was {1}.", projects.Count, sel);
                        }
                    }
                    
                    foreach (var paper in targetProject.Papers)
                    {
                        Console.WriteLine("--=== {0} ===--", paper.Title);
                        foreach (var task in paper.Tasks)
                        {
                            Console.Write("\n\n---\n{0}\n\n", task.Question); // TODO Might of overdone the line breaks
                            task.Run();
                        }
                    }

                }
                else if (selection == (int) Selection.RunAllTasks)
                {
                    foreach (Project project in projects)
                    {
                        Console.WriteLine("--=== {0} ===--", project.Title);
                        foreach (Paper paper in project.Papers)
                        {
                            Console.WriteLine("--=== {0} ===--", paper.Title);
                            if (paper.Comments != null) Console.WriteLine(paper.Comments);
                            foreach (Task task in paper.Tasks)
                            {
                                Console.Write("\n\n---\n{0}\n\n",
                                    task.Question); // TODO Might of overdone the line breaks
                                try
                                {
                                    task.Run();
                                }
                                catch (NotImplementedException)
                                {
                                    Console.WriteLine("Task has not yet been implemented.");
                                }
                                catch(Exception up)
                                {
                                    Console.WriteLine("Task is going to throw up.");
                                    throw up; // haha
                                }
                            }
                        }
                        
                        Console.WriteLine("All tasks ran with no exceptions.");
                    }
                }
                else if (selection == (int) Selection.Quit)
                {
                    Console.WriteLine("Goodbye.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Selection");
                }
            }
        }

        private static int GetValidInt(string demand) 
        {
            int task;
            while (true)
            {
                Console.Write("{0}: ", demand);
                try
                {
                    task = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.Write("Please input a valid number");
                }
                finally
                {
                    Console.Write(".\n");
                }
            }

            return task;
        }
    }
}