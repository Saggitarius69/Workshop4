using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating student object
        Student s1 = new Student();
        s1.name = "Siddhartha";
        s1.age = 24;
        s1.address = "Dharan";

        // Creating student object
        Student s2 = new Student();
        s2.name = "Saphal";
        s2.age = 23;
        s2.address = "Biratchowk";

        // Display values of 1st object
        Console.WriteLine("---- Student 1 ----");
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Address: " + s1.address);

        // Display values of 2nd object
        Console.WriteLine("\n---- Student 2 ----");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Address: " + s2.address);

        Console.WriteLine("\nCollege Name (Static Field): " + Student.collegeName);
    }
}
