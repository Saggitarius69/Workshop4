using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator c = new Calculator();

        c.PrintWelcome();

        int sum = c.Add(5, 7);
        int product1 = c.Multiply(4, 3);
        int product2 = c.Multiply(6);   // optional parameter used

        Console.WriteLine("Addition: " + sum);
        Console.WriteLine("Multiplication (4 * 3): " + product1);
        Console.WriteLine("Multiplication (6 * default 1): " + product2);
    }
}
