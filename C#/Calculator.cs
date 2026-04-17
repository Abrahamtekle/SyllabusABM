using System;

class Calculator
{
    static int Sum(int a, int b)
    {
        return a + b;
    }

    static int Subtraction(int a, int b)
    {
        return a - b;
    }

    static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 4;

        Console.WriteLine("=== ABM Calculator (C#) ===");
        Console.WriteLine($"Number 1: {num1}");
        Console.WriteLine($"Number 2: {num2}");
        Console.WriteLine($"Sum:         {num1} + {num2} = {Sum(num1, num2)}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {Subtraction(num1, num2)}");
    }
}
