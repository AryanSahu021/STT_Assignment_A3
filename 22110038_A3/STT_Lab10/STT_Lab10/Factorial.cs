using System;

class LoopsAndFunctions
{
    public static void FacMain()
    {
        // Print numbers 1 to 10 using for loop
        Console.WriteLine("Numbers 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // While loop for user input
        string input = "";
        while (input.ToLower() != "exit")
        {
            Console.WriteLine("Enter a number to calculate its factorial or type 'exit' to quit:");
            input = Console.ReadLine();

            if (input.ToLower() != "exit")
            {
                if (int.TryParse(input, out int number))
                {
                    long factorial = CalculateFactorial(number);
                    Console.WriteLine($"Factorial of {number} is {factorial}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'exit'.");
                }
            }
        }
    }

    // Function to calculate factorial
    public static long CalculateFactorial(int n)
    {
        if (n < 0)
            return -1; // Error case
        if (n == 0)
            return 1;

        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}