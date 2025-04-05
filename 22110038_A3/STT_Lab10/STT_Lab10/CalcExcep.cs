using System;

class CalculatorWithExceptionHandling
{
    public static void Main()
    {
        try
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

            // Division with exception handling
            try
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                double quotient = num1 / num2;
                Console.WriteLine($"Division: {quotient}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
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
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numbers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Calculation completed.");
        }
    }
}