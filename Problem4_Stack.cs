using System;
using System.Collections.Generic;

struct Operation
{
    public string Action;
    public string StudentNumber;
    public string StudentName;
}

class Program
{
    static void Main()
    {
        Stack<Operation> history =
            new Stack<Operation>();

        int choice;

        do
        {
            Console.WriteLine("1. Record Operation");
            Console.WriteLine("2. View History");
            Console.WriteLine("3. View Last Operation");
            Console.WriteLine("4. Remove Last Operation");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Operation op = new Operation();

                Console.Write("Action: ");
                op.Action = Console.ReadLine();

                Console.Write("Student Number: ");
                op.StudentNumber = Console.ReadLine();

                Console.Write("Student Name: ");
                op.StudentName = Console.ReadLine();

                history.Push(op);

                Console.WriteLine("Recorded.");
            }

            else if (choice == 2)
            {
                if (history.Count == 0)
                {
                    Console.WriteLine("No history.");
                }
                else
                {
                    foreach (Operation op in history)
                        Console.WriteLine(op.Action + " " + op.StudentName);
                }
            }

            else if (choice == 3)
            {
                if (history.Count == 0)
                {
                    Console.WriteLine("No history.");
                }
                else
                {
                    Operation op = history.Peek();
                    Console.WriteLine(op.Action + " " + op.StudentName);
                }
            }

            else if (choice == 4)
            {
                if (history.Count == 0)
                {
                    Console.WriteLine("No history.");
                }
                else
                {
                    history.Pop();
                    Console.WriteLine("Removed.");
                }
            }

        } while (choice != 5);

        Console.WriteLine("Program exited.");
    }
}
