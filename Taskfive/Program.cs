using System;

public enum DayType
{
    Weekday,
    Weekend
}

public record Book(string title, string author, double price);

class Program
{
    static void Main(string[] args)
    {
        // Part 1: DayType Enum Use
        Console.Write("Enter the day: ");
        string day = Console.ReadLine().Trim().ToLower();

        DayType result;

        if (day == "friday" || day == "saturday")
        {
            result = DayType.Weekend;
        }
        else
        {
            result = DayType.Weekday;
        }

        Console.WriteLine("It is: " + result);


       
        // Part 2: Record Book
        Book b1 = new Book("C# Basics", "John Doe", 599.99);

        Book b2 = b1 with { title = "Advanced C#", price = 799.99 };

        Console.WriteLine("\nFirst Book:");
        Console.WriteLine(b1);

        var (title, author, price) = b2;

        Console.WriteLine("\nSecond Book (Deconstructed):");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}
