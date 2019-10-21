using System;

namespace Calculator
{
    public static class Program
    {
        public static void Main()
        {
            int result = 0;

            Console.WriteLine("Please enter one number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second single number");
            int secondNumber = int.Parse(Console.ReadLine());
            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 
            Console.WriteLine("Please Choose an Operation example: add, subtract, multiply, divide");
            string operation = Console.ReadLine();

            operation = operation.ToLower();

            if(operation == "add")
            {
                result = firstNumber + secondNumber;
            }

            if(operation == "subtract")
            {
                result = firstNumber - secondNumber;
            }

            if(operation == "multiply")
            {
                result = firstNumber* secondNumber;
            }

            if(operation == "divide")
            {
                result = firstNumber/secondNumber;
            }


            Console.WriteLine($"Total = {result}");

            Console.ReadLine();
        }
    }
}
