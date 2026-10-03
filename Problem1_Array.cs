using System;

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
        Student[] students = new Student[10];
        int studentCount = 0;
        int choice;

        do
        {
            Console.WriteLine("========================================");
            Console.WriteLine("       STUDENT RECORD MANAGEMENT");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                if (studentCount >= 10)
                {
                    Console.WriteLine("Cannot add more than 10 students.");
                }
                else
                {
                    Student student = new Student();

                    Console.Write("Enter Student Number: ");
                    student.StudentNumber = Console.ReadLine();

                    Console.Write("Enter Name: ");
                    student.Name = Console.ReadLine();

                    Console.Write("Enter Program: ");
                    student.Program = Console.ReadLine();

                    Console.Write("Enter Year Level: ");
                    student.YearLevel = Convert.ToInt32(Console.ReadLine());

                    students[studentCount] = student;
                    studentCount++;

                    Console.WriteLine("Student added successfully!");
                }
            }
            else if (choice == 2)
            {
                if (studentCount == 0)
                {
                    Console.WriteLine("No student records found.");
                }
                else
                {
                    Console.WriteLine("\n========================================");
                    Console.WriteLine("           STUDENT RECORDS");
                    Console.WriteLine("========================================");

                    for (int i = 0; i < studentCount; i++)
                    {
                        Console.WriteLine("Student Number: " + students[i].StudentNumber);
                        Console.WriteLine("Name: " + students[i].Name);
                        Console.WriteLine("Program: " + students[i].Program);
                        Console.WriteLine("Year Level: " + students[i].YearLevel);
                        Console.WriteLine("----------------------------------------");
                    }
                }
            }
            else if (choice == 3)
            {
                Console.Write("Enter Student Number to search: ");
                string number = Console.ReadLine();
                bool found = false;

                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == number)
                    {
                        Console.WriteLine("\nStudent Found!");
                        Console.WriteLine("Student Number: " + students[i].StudentNumber);
                        Console.WriteLine("Name: " + students[i].Name);
                        Console.WriteLine("Program: " + students[i].Program);
                        Console.WriteLine("Year Level: " + students[i].YearLevel);
                        found = true;
                        break;
                    }
                }

                if (!found)
                    Console.WriteLine("Student not found.");
            }
            else if (choice == 4)
            {
                Console.Write("Enter Student Number to update: ");
                string number = Console.ReadLine();
                bool found = false;

                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == number)
                    {
                        Console.Write("Enter New Name: ");
                        students[i].Name = Console.ReadLine();

                        Console.Write("Enter New Program: ");
                        students[i].Program = Console.ReadLine();

                        Console.Write("Enter New Year Level: ");
                        students[i].YearLevel = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Student updated successfully!");
                        found = true;
                        break;
                    }
                }

                if (!found)
                    Console.WriteLine("Student not found.");
            }
            else if (choice == 5)
            {
                Console.Write("Enter Student Number to delete: ");
                string number = Console.ReadLine();
                bool found = false;

                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == number)
                    {
                        for (int j = i; j < studentCount - 1; j++)
                        {
                            students[j] = students[j + 1];
                        }

                        studentCount--;
                        Console.WriteLine("Student deleted successfully!");
                        found = true;
                        break;
                    }
                }

                if (!found)
                    Console.WriteLine("Student not found.");
            }
            else if (choice == 6)
            {
                Console.WriteLine("Program exited.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.WriteLine();
        }
        while (choice != 6);
    }
}
