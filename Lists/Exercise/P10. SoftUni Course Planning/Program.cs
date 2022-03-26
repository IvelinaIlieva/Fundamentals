using System;
using System.Collections.Generic;
using System.Linq;

namespace P10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main()
        {
            List<string> lessonsList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] comArgs = command.Split(":").ToArray();

                string commType = comArgs[0];

                if (commType == "Exercise")
                {
                    string lessonTitle = comArgs[1];
                    string exerciseName = string.Concat(lessonTitle, "-", commType);

                    if (lessonsList.Contains(lessonTitle) && !lessonsList.Contains(exerciseName))
                    {
                        lessonsList.Insert(lessonsList.IndexOf(lessonTitle) + 1, exerciseName);
                    }
                    else if(!lessonsList.Contains(lessonTitle) && !lessonsList.Contains(exerciseName))
                    {
                        lessonsList.Add(lessonTitle);
                        lessonsList.Add(exerciseName);
                    }
                }
                else if (commType == "Add")
                {
                    string lessonTitle = comArgs[1];

                    if (!lessonsList.Contains(lessonTitle))
                    {
                        lessonsList.Add(lessonTitle);
                    }
                }
                else if (commType == "Insert")
                {
                    string lessonTitle = comArgs[1];
                    int index = int.Parse(comArgs[2]);

                    if (index < 0 || index >= lessonsList.Count)
                    {
                        continue;
                    }

                    if (!lessonsList.Contains(lessonTitle))
                    {
                        lessonsList.Insert(index, lessonTitle);
                    }
                }
                else if (commType == "Remove")
                {
                    string lessonTitle = comArgs[1];

                    if (lessonsList.Contains(lessonTitle))
                    {
                        lessonsList.Remove(lessonTitle);

                        if (lessonsList.Contains(string.Concat(lessonTitle, "-Exercise")))
                        {
                            lessonsList.Remove(string.Concat(lessonTitle, "-Exercise"));
                        }
                    }
                }
                else if (commType == "Swap")
                {
                    string lessonTitle1 = comArgs[1];
                    string lessonTitle2 = comArgs[2];
                    int index1 = lessonsList.IndexOf(lessonTitle1);
                    int index2 = lessonsList.IndexOf(lessonTitle2);

                    if (lessonsList.Contains(lessonTitle1) && lessonsList.Contains(lessonTitle2))
                    {
                        string tempLesson = lessonTitle1;
                        lessonsList[index1] = lessonTitle2;
                        lessonsList[index2] = tempLesson;

                        if (lessonsList.Contains(string.Concat(lessonTitle1, "-Exercise")))
                        {
                            lessonsList.Remove(string.Concat(lessonTitle1, "-Exercise"));
                            lessonsList.Insert(index2 + 1, string.Concat(lessonTitle1, "-Exercise"));
                        }
                        if (lessonsList.Contains(string.Concat(lessonTitle2, "-Exercise")))
                        {
                            lessonsList.Remove(string.Concat(lessonTitle2, "-Exercise"));
                            lessonsList.Insert(index1 + 1, string.Concat(lessonTitle2, "-Exercise"));
                        }
                    }
                }
            }

            for (int i = 1; i <= lessonsList.Count; i++)
            {
                Console.WriteLine($"{i}.{lessonsList[i - 1]}");
            }
        }
    }
}
