using System;
using System.Collections.Generic;
using Layout;

namespace Base
{
    public class Executor
    {
        private readonly List<Project> Projects = new List<Project>();
        
        public Executor()
        {
        }
        
        private enum Selection
        {
            SelectTask=1,
            RunWholeProject=2,
            RunAllTasks=3,
            Quit=4
        }

        public void AskUser()
        {
            const string welcomeMsg = "--=== College Programming ===--\n" +
                                      "Developer: Turpster (or Reece)\n" +
                                      "Tutor: Darren\n" +
                                      "\n" +
                                      "1) Select a task to run.\n" +
                                      "2) Run a whole project.\n" +
                                      "3) Run all tasks from every project.\n" +
                                      "4) Quit.\n" +
                                      "";
            while (true)
            {
                Console.WriteLine(welcomeMsg);
                
                Console.Write("Selection: ");
                int selection = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.WriteLine(".\n");
                if (selection == (int) Selection.SelectTask)
                {
                    Project project;
                    while (true)
                    {
                        try
                        {
                            project = Projects[GetValidInt("Project") - 1];
                            break;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Please input a valid project number, 1 to {0}.", Projects.Count);
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
                    
                    RunTask(task);
                }
                else if (selection == (int) Selection.RunWholeProject)
                {
                    Project targetProject;
                    while (true)
                    {
                        var sel = GetValidInt("Project Number");
                        try
                        {
                            targetProject = Projects[sel - 1];
                            break;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Project number is out of range, 1 to {0} and your selection was {1}.", Projects.Count, sel);
                        }
                    }
                    
                    foreach (var paper in targetProject.Papers)
                    {
                        Console.WriteLine("--=== {0} ===--", paper.Title);
                        if (paper.Comments != null) Console.WriteLine(paper.Comments);
                        foreach (var task in paper.Tasks)
                        {
                            RunTask(task);
                        }
                    }

                }
                else if (selection == (int) Selection.RunAllTasks)
                {
                    foreach (Project project in Projects)
                    {
                        Console.WriteLine("--=== {0} ===--", project.Title);
                        foreach (Paper paper in project.Papers)
                        {
                            Console.WriteLine("--=== {0} ===--", paper.Title);
                            if (paper.Comments != null) Console.WriteLine(paper.Comments);
                            foreach (Task task in paper.Tasks)
                            {
                                RunTask(task);
                            }
                        }
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
                catch (FormatException)
                {
                    Console.Write("Please input a valid number.");
                }
            }

            return task;
        }

        private static void RunTask(Task task)
        {
            Console.WriteLine(": Start of {0}", task.Title);
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
                Console.WriteLine("Task is going to throw up.\n{0}", up);
                // ReSharper disable once PossibleIntendedRethrow
                throw up; // haha
            }
            Console.WriteLine(": Task ({0}) ran successfully with no exceptions.", task.Title);
        }

        public void AddProject(Project project)
        {
            Projects.Add(project);
        }
    }
    
}