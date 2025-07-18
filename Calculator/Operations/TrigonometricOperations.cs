using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public class TrigonometricOperations
    {
        public static double Sin(double num) => Math.Sin(num);
        public static double Cos(double num) => Math.Cos(num);
        public static double Tan(double num) => Math.Tan(num);
        public static double Csc(double num) => 1 / Math.Sin(num);
        public static double Sec(double num) => 1 / Math.Cos(num);
        public static double Cot(double num) => 1 / Math.Tan(num);
        

    }
}
