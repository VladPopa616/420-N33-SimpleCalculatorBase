using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CalculatorEngineLibrary;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is a console calculator");
            Console.WriteLine("The program takes in 2 numbers and an operator");
            Console.WriteLine("Please enter the numbers and operator to calculate the result...");
            try
            {
                //Class to convert user input
                InputConverter inputConverter = new InputConverter();

                //Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(firstNumber + operation + secondNumber + " = " +  result);
                Console.WriteLine("Closing Calculator");

            } catch (System.ArgumentException e)
            {
                Console.WriteLine("Please enter a number");
            }

            catch (System.InvalidOperationException e)
            {
                Console.WriteLine("Please enter a valid operator such as +,-,*,/ or write it out.");
            }
        }
    }
}
