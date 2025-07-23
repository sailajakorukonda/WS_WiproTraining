using System;

public class Calculator
{
    static void Main(String[] args)
    {
        int a;
        int b;
        Console.WriteLine("Enter the first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sum of 2 numbers: " + (a + b));
        Console.WriteLine("Sabstraction of 2 mumbers: " + (a - b));
        Console.WriteLine("Multiplication of 2 numbers: " + (a * b));
        Console.WriteLine("Division of 2 numbers: " + (a / b));
        Console.ReadKey();

    }
}