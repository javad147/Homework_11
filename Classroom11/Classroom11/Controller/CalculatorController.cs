using Domain.Models;
using Homework10.Services;

namespace Classroom11

{
    public class CalculatorController
    {
        public void Elements()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Birinci reqemi daxil edi:");
            calculator.FirstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ikinci reqemi daxil edin:");
            calculator.SecondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Arifmetik operatoru daxil edin (+, -, *, /):");
            calculator.Operation = Console.ReadLine()[0];

            CalculatorService calculatorService = new CalculatorService();
            calculatorService.Calculate(calculator);
        }
    }
}