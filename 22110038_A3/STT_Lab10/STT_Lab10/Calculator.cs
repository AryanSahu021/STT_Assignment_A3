using System;

class Calculator
{
    public static void CalcMain()
    {
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Perform operations
        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;

        Console.WriteLine($"Addition: {sum}");
        Console.WriteLine($"Subtraction: {difference}");
        Console.WriteLine($"Multiplication: {product}");

        // Division with error handling (will be improved in Activity 5)
        if (num2 != 0)
        {
            double quotient = num1 / num2;
            Console.WriteLine($"Division: {quotient}");
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }

        // Check if sum is even or odd
        if (sum % 2 == 0)
        {
            Console.WriteLine($"The sum {sum} is even.");
        }
        else
        {
            Console.WriteLine($"The sum {sum} is odd.");
        }
    }
}