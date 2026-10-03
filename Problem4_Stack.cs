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
        Stack<Operation> operationHistory =
            new Stack<Operation>();

        int choice;

        do
        {
            Console.WriteLine("========================================");
            Console.WriteLine("          OPERATION HISTORY");
            Console.WriteLine("========================================");
            Console.WriteLine("1. View Operation History");
            Console.WriteLine("2. View Last Operation");
            Console.WriteLine("3. Remove Last Operation");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No recorded operations.");
                }
                else
                {
                    Console.WriteLine("\nOPERATION HISTORY");

                    int number = operationHistory.Count;

                    foreach (Operation operation in operationHistory)
                    {
                        Console.WriteLine(number + ". " +
                            operation.Action + " " +
                            operation.StudentName);
                        number--;
                    }
                }
            }
            else if (choice == 2)
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No recorded operations.");
                }
                else
                {
                    Operation last = operationHistory.Peek();

                    Console.WriteLine("Last Operation: " +
                        last.Action + " " + last.StudentName);
                }
            }
            else if (choice == 3)
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No recorded operations.");
                }
                else
                {
                    operationHistory.Pop();
                    Console.WriteLine("Last operation removed successfully!");
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
