using System;

class Program
{
    static void Main()
    {
        // Task 1: Multiply user input by 50
        Console.Write("Enter a number to be multiplied by 50: ");
        double userInput1 = Convert.ToDouble(Console.ReadLine());
        double result1 = userInput1 * 50;
        Console.WriteLine($"Result after multiplying by 50: {result1}");

        // Task 2: Add 25 to user input
        Console.Write("Enter a number to add 25 to: ");
        double userInput2 = Convert.ToDouble(Console.ReadLine());
        double result2 = userInput2 + 25;
        Console.WriteLine($"Result after adding 25: {result2}");

        // Task 3: Divide user input by 12.5
        Console.Write("Enter a number to be divided by 12.5: ");
        double userInput3 = Convert.ToDouble(Console.ReadLine());
        double result3 = userInput3 / 12.5;
        Console.WriteLine($"Result after dividing by 12.5: {result3}");

        // Task 4: Check if user input is greater than 50
        Console.Write("Enter a number to check if it's greater than 50: ");
        double userInput4 = Convert.ToDouble(Console.ReadLine());
        bool isGreaterThan50 = userInput4 > 50;
        Console.WriteLine($"Is the number greater than 50? {isGreaterThan50}");

        // Task 5: Get the remainder after dividing user input by 7
        Console.Write("Enter a number to get the remainder after dividing by 7: ");
        double userInput5 = Convert.ToDouble(Console.ReadLine());
        double remainder = userInput5 % 7;
        Console.WriteLine($"Remainder after division by 7: {remainder}");
    }
}
