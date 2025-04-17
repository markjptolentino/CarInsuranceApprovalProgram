using System;

class Program
{
    static void Main()
    {
        // Print program title
        Console.WriteLine("Car Insurance Approval Program");

        // Ask for applicant's age and convert input to integer
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask if applicant has had a DUI and convert input to boolean
        Console.WriteLine("Have you ever had a DUI? (true/false)");
        bool hasDUI = Convert.ToBoolean(Console.ReadLine());

        // Ask for number of speeding tickets and convert input to integer
        Console.WriteLine("How many speeding tickets do you have?");
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        // Create a boolean expression based on the qualification rules:
        // - Age must be greater than 15
        // - Must not have any DUIs (i.e., hasDUI must be false)
        // - Must not have more than 3 speeding tickets
        bool isQualified = (age > 15 && hasDUI == false && speedingTickets <= 3);

        // Print the result: true if qualified, false otherwise
        Console.WriteLine("Qualified?");
        Console.WriteLine(isQualified);
    }
}
