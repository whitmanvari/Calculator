using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public class BasicOperations : IOperations
    {
        public double Calculate(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+": return num1 + num2;
                case "-": return num1 - num2;
                case "x": return num1 * num2;
                case "/":
                    if (num2 != 0) return num1 / num2;
                    else
                        throw new DivideByZeroException("Cannot divide by zero.");
                default: return num2; // If no operation is specified, return the second number

            }
        }

        public double Calculate(double num, string operation)
        {
            switch (operation)
            {
                case "+": return num;
                case "-": return -num; // Negation
                case "x": return num; // Multiplication by 1
                case "/":
                    if (num != 0) return 1 / num;
                    else
                        throw new DivideByZeroException("Cannot divide by zero.");

                default: return num;
            }

        }
    }
}
