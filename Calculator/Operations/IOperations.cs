using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public interface IOperations
    {
        double Calculate(double num1, double num2, string operation);
        double Calculate(double num, string operation); // Overloaded method for single operand operations
    }
}
