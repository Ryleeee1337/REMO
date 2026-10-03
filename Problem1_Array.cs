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
        int count = 0;
        int choice;

        do
        {
            Console.WriteLine("STUDENT RECORD MANAGEMENT");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                if (count == 10)
                {
                    Console.WriteLine("Full.");
                    continue;
                }

                Console.Write("Student Number: ");
                students[count].StudentNumber = Console.ReadLine();

                Console.Write("Name: ");
                students[count].Name = Console.ReadLine();

                Console.Write("Program: ");
                students[count].Program = Console.ReadLine();

                Console.Write("Year Level: ");
                students[count].YearLevel = int.Parse(Console.ReadLine());

                count++;
                Console.WriteLine("Added.");
            }

            else if (choice == 2)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("STUDENT RECORDS");
                    Console.WriteLine(students[i].StudentNumber);
                    Console.WriteLine(students[i].Name);
                    Console.WriteLine(students[i].Program);
                    Console.WriteLine(students[i].YearLevel);
                }
            }

            else if (choice == 3)
            {
                Console.Write("Student Number: ");
                string number = Console.ReadLine();
                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (students[i].StudentNumber == number)
                    {
                        Console.WriteLine(students[i].Name);
                        Console.WriteLine(students[i].Program);
                        Console.WriteLine(students[i].YearLevel);
                        found = true;
                    }
                }

                if (!found)
                    Console.WriteLine("Student not found.");
            }

            else if (choice == 4)
            {
                Console.Write("Student Number: ");
                string number = Console.ReadLine();

                for (int i = 0; i < count; i++)
                {
                    if (students[i].StudentNumber == number)
                    {
                        Console.Write("New Name: ");
                        students[i].Name = Console.ReadLine();

                        Console.Write("New Program: ");
                        students[i].Program = Console.ReadLine();

                        Console.Write("New Year Level: ");
                        students[i].YearLevel = int.Parse(Console.ReadLine());

                        Console.WriteLine("Updated.");
                    }
                }
            }

            else if (choice == 5)
            {
                Console.Write("Student Number: ");
                string number = Console.ReadLine();

                for (int i = 0; i < count; i++)
                {
                    if (students[i].StudentNumber == number)
                    {
                        for (int j = i; j < count - 1; j++)
                            students[j] = students[j + 1];

                        count--;
                        Console.WriteLine("Deleted.");
                        break;
                    }
                }
            }

        } while (choice != 6);

        Console.WriteLine("Program exited.");
    }
}
