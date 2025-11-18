using System;

class Program
{
    static void Main(string[] args)
    {
        ParameterDemo obj = new ParameterDemo();

        int value = 20;
        obj.Increase(ref value);
        Console.WriteLine("After Increase: " + value);

        string myname;
        obj.GetFullName(out myname);
        Console.WriteLine("Full Name: " + myname);

        int total = obj.SumAll(5, 10, 15, 20);
        Console.WriteLine("Sum of all numbers: " + total);
    }
}
