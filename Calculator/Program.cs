using System;

namespace Calculator
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Pick a number");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Pick another number");
            int numTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you want to add, subtract, multiply, or divide the two numbers");
            string choice = Console.ReadLine();
            choice = choice.ToLower();
            int result = 0;
            if(choice == "add" || choice == "+")
            {
                result = numOne + numTwo;
            }
            if(choice == "subtract" || choice == "-")
            {
                result = numOne - numTwo;
            }
            if(choice == "multiply" || choice == "x" || choice == "*")
            {
                result = numOne * numTwo;
            }
            if(choice == "divide" || choice == "/")
            {
                result = numOne / numTwo;
            }
            
            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 

            Console.WriteLine($"Total = {result}");

            Console.ReadLine();
        }
    }
}
