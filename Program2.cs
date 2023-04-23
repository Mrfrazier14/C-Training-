using System;

namespace MyFirstCSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            int num1 = 10;
            int num2 = 5;
            string name = "John";
            bool isTrue = true;
            double pi = 3.14;

            // Prompt user for input and display output
            Console.WriteLine("Enter your name:");
            string input = Console.ReadLine();
            Console.WriteLine("Hello, " + input + "!");

            // Define and call functions
            int sum = AddNumbers(num1, num2);
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);

            // Implement conditional statements
            if (isTrue)
            {
                Console.WriteLine("This statement is true.");
            }
            else
            {
                Console.WriteLine("This statement is false.");
            }

            // Use loops
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Loop iteration " + i);
            }
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}