using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("-----------------");

            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    break;
                }

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Thank you for using the calculator!");
        }
    }
}
