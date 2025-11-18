using System;

class Program
{
    static void Main(string[] args)
    {
        int marks;
        int total;

        Console.Write("Enter marks: ");
        bool ok1 = int.TryParse(Console.ReadLine(), out marks);

        Console.Write("Enter total: ");
        bool ok2 = int.TryParse(Console.ReadLine(), out total);

        if (!ok1 || !ok2)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        // Breakpoint 1 here

        double percentage = (double)marks / total * 100; 

        // Breakpoint 2 here

        Console.WriteLine("Percentage = " + percentage);
    }
}
