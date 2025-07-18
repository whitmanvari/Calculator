using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public class BasicOperations : IOperations
    {
        public double Calculate(double num1, double num2)
        {
            switch(Operation)
            {
                case "+": return num1 + num2;
                case "-": return num1 - num2;
                case "x": return num1 * num2;
                case "/": 
                if(num2 != 0) return num1 / num2; 
                else 
                throw new DivideByZeroException("Cannot divide by zero.");
                default: return num2; // If no operation is specified, return the second number
            }
        }
    }
}
