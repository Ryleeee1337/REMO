using System;
using System.Collections.Generic;

struct StudentRequest
{
    public string StudentNumber;
    public string StudentName;
    public string RequestType;
}

class Program
{
    static void Main()
    {
        Queue<StudentRequest> requests =
            new Queue<StudentRequest>();

        int choice;

        do
        {
            Console.WriteLine("1. Add Request");
            Console.WriteLine("2. View Requests");
            Console.WriteLine("3. Process Request");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                StudentRequest r = new StudentRequest();

                Console.Write("Student Number: ");
                r.StudentNumber = Console.ReadLine();

                Console.Write("Student Name: ");
                r.StudentName = Console.ReadLine();

                Console.Write("Request Type: ");
                r.RequestType = Console.ReadLine();

                requests.Enqueue(r);

                Console.WriteLine("Added.");
            }

            else if (choice == 2)
            {
                if (requests.Count == 0)
                {
                    Console.WriteLine("No requests.");
                }
                else
                {
                    foreach (StudentRequest r in requests)
                        Console.WriteLine(r.StudentName + " - " + r.RequestType);
                }
            }

            else if (choice == 3)
            {
                if (requests.Count == 0)
                {
                    Console.WriteLine("No requests.");
                }
                else
                {
                    StudentRequest r = requests.Dequeue();

                    Console.WriteLine("Processing: " +
                        r.StudentName + " - " + r.RequestType);
                }
            }

        } while (choice != 4);

        Console.WriteLine("Program exited.");
    }
}
