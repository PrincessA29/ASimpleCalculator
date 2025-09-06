using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Clear screen when program starts
            Console.WriteLine("=== Simple Calculator ===");
            Console.WriteLine();

            try
            {
                // Ask user to enter first number
                Console.Write("Enter the first number: ");
                string? input1 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input1))
                {
                    Console.WriteLine("Error: Please enter a valid number!");
                    return;
                }
                int number1 = Convert.ToInt32(input1);

                // Ask user to enter second number
                Console.Write("Enter the second number: ");
                string? input2 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input2))
                {
                    Console.WriteLine("Error: Please enter a valid number!");
                    return;
                }
                int number2 = Convert.ToInt32(input2);

                // Ask user which operation to perform
                Console.WriteLine();
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("+ for Addition");
                Console.WriteLine("- for Subtraction");
                Console.WriteLine("* for Multiplication");
                Console.WriteLine("/ for Division");
                Console.Write("Enter your choice (+, -, *, /): ");
                
                string? operation = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(operation))
                {
                    Console.WriteLine("Error: Please enter a valid operation!");
                    return;
                }

                // Perform calculation based on user's choice
                double result = 0;
                bool validOperation = true;

                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        Console.WriteLine($"\nResult: {number1} + {number2} = {result}");
                        break;
                    case "-":
                        result = number1 - number2;
                        Console.WriteLine($"\nResult: {number1} - {number2} = {result}");
                        break;
                    case "*":
                        result = number1 * number2;
                        Console.WriteLine($"\nResult: {number1} * {number2} = {result}");
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            result = (double)number1 / number2;
                            Console.WriteLine($"\nResult: {number1} / {number2} = {result:F2}");
                        }
                        else
                        {
                            Console.WriteLine("\nError: Cannot divide by zero!");
                            validOperation = false;
                        }
                        break;
                    default:
                        Console.WriteLine("\nError: Invalid operation! Please use +, -, *, or /");
                        validOperation = false;
                        break;
                }

                if (validOperation && operation != "/")
                {
                    Console.WriteLine($"Result as integer: {(int)result}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: Please enter valid numbers only!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nError: Number is too large or too small!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn unexpected error occurred: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}