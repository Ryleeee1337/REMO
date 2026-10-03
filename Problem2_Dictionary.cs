using System;
using System.Collections.Generic;

struct Student
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Program
{
    static void Main()
    {
        Dictionary<string, Student> students =
            new Dictionary<string, Student>();

        int choice;

        do
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display Students");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Student Number: ");
                string number = Console.ReadLine();

                if (students.ContainsKey(number))
                {
                    Console.WriteLine("Already exists.");
                    continue;
                }

                Student s = new Student();

                s.StudentNumber = number;

                Console.Write("Name: ");
                s.Name = Console.ReadLine();

                Console.Write("Program: ");
                s.Program = Console.ReadLine();

                Console.Write("Year Level: ");
                s.YearLevel = int.Parse(Console.ReadLine());

                students.Add(number, s);
                Console.WriteLine("Added.");
            }

            else if (choice == 2)
            {
                Console.Write("Student Number: ");
                string number = Console.ReadLine();

                if (students.ContainsKey(number))
                {
                    Student s = students[number];

                    Console.WriteLine(s.StudentNumber);
                    Console.WriteLine(s.Name);
                    Console.WriteLine(s.Program);
                    Console.WriteLine(s.YearLevel);
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }

            else if (choice == 3)
            {
                foreach (Student s in students.Values)
                {
                    Console.WriteLine(s.StudentNumber);
                    Console.WriteLine(s.Name);
                    Console.WriteLine(s.Program);
                    Console.WriteLine(s.YearLevel);
                }
            }

        } while (choice != 4);

        Console.WriteLine("Program exited.");
    }
}
