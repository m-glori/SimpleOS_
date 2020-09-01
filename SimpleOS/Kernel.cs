using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace SimpleOS
{
    public class Kernel : Sys.Kernel
    {
        int firstLine = 0;
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            if (firstLine == 0) { Console.WriteLine("Welcome to SimpleOS! Type in Calc to use a calculator!"); firstLine = 1; }
            Console.Write("Input: ");
            var input = Console.ReadLine();

            if (input.Equals("calc")) { Calculator(); }
            // if (input.Equal("power off")) { shut off; }

            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }

        protected void Calculator()
        {
            // Later, use stacks (start 09/01/2020) to create a far better calculator.
            Console.WriteLine("Welcome to the calculator! Only input a number followed by an operation followed by a number, with now spaces. For example: 4+2");

            bool running = true;
            while (running)
            {

                var input = Console.ReadLine();

                char operation = input[1];
                int firstNumber = input[0] - '0';
                int secondNumber = input[2] - '0';


                Console.WriteLine("First number is: " + firstNumber);
                Console.WriteLine("Second number is: " + secondNumber);

                switch (operation)
                {
                    case '+':
                        Console.WriteLine("+");
                        Console.WriteLine(firstNumber + secondNumber);
                        break;
                    case '-':
                        Console.WriteLine("-");
                        Console.WriteLine(firstNumber - secondNumber);
                        break;
                    case '/':
                        Console.WriteLine("/");
                        Console.WriteLine(firstNumber / secondNumber);
                        break;
                    case '%':
                        Console.WriteLine("%");
                        Console.WriteLine(firstNumber % secondNumber);
                        break;
                    case '*':
                        Console.WriteLine("*");
                        Console.WriteLine(firstNumber * secondNumber);
                        break;
                    case 'f':
                        Console.WriteLine("Calculator goes boom.");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Input a different calculation. Your input is incalculatable.");
                        break;

                }
            }

        }
    }
}
