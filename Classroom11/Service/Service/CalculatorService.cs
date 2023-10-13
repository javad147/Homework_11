using Domain.Models;
using Homework10.Services;
using System;

namespace Homework10.Services
{
    public class CalculatorService
    {
        public void Calculate(Calculator calculator)
        {
            double result = 0;

            if (calculator.Operation == '+')
            {
                result = calculator.FirstNumber + calculator.SecondNumber;
            }
            else if (calculator.Operation == '-')
            {
                result = calculator.FirstNumber - calculator.SecondNumber;
            }
            else if (calculator.Operation == '*')
            {
                result = calculator.FirstNumber * calculator.SecondNumber;
            }
            else if (calculator.Operation == '/')
            {
                if (calculator.SecondNumber != 0)
                {
                    result = calculator.FirstNumber / calculator.SecondNumber;
                }
                else
                {
                    Console.WriteLine("0 bolmek olmaz!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid operation. Please enter (+, -, *, /).");
                return;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
