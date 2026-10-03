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
        Dictionary<string, Student> studentDictionary =
            new Dictionary<string, Student>();

        int choice;

        do
        {
            Console.WriteLine("========================================");
            Console.WriteLine("      STUDENT LOOKUP USING DICTIONARY");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display All Students");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Student student = new Student();

                Console.Write("Enter Student Number: ");
                student.StudentNumber = Console.ReadLine();

                if (studentDictionary.ContainsKey(student.StudentNumber))
                {
                    Console.WriteLine("Student Number already exists.");
                }
                else
                {
                    Console.Write("Enter Name: ");
                    student.Name = Console.ReadLine();

                    Console.Write("Enter Program: ");
                    student.Program = Console.ReadLine();

                    Console.Write("Enter Year Level: ");
                    student.YearLevel = Convert.ToInt32(Console.ReadLine());

                    studentDictionary.Add(student.StudentNumber, student);

                    Console.WriteLine("Student added successfully!");
                }
            }
            else if (choice == 2)
            {
                Console.Write("Enter Student Number to search: ");
                string number = Console.ReadLine();

                if (studentDictionary.ContainsKey(number))
                {
                    Student student = studentDictionary[number];

                    Console.WriteLine("\nStudent Found!");
                    Console.WriteLine("Student Number: " + student.StudentNumber);
                    Console.WriteLine("Name: " + student.Name);
                    Console.WriteLine("Program: " + student.Program);
                    Console.WriteLine("Year Level: " + student.YearLevel);
                }
                else
                {
                    Console.WriteLine("Student Number does not exist.");
                }
            }
            else if (choice == 3)
            {
                if (studentDictionary.Count == 0)
                {
                    Console.WriteLine("No student records found.");
                }
                else
                {
                    Console.WriteLine("\n========================================");
                    Console.WriteLine("           STUDENT RECORDS");
                    Console.WriteLine("========================================");

                    foreach (Student student in studentDictionary.Values)
                    {
                        Console.WriteLine("Student Number: " + student.StudentNumber);
                        Console.WriteLine("Name: " + student.Name);
                        Console.WriteLine("Program: " + student.Program);
                        Console.WriteLine("Year Level: " + student.YearLevel);
                        Console.WriteLine("----------------------------------------");
                    }
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Program exited.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.WriteLine();
        }
        while (choice != 4);
    }
}
