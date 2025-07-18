using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class CalculatorModel
    {
        public string CurrentInput { get; set; } = ""; // initially empty
        public string PreviousInput { get; set; } = ""; // initially empty
        public string Operation { get; set; } = ""; // initially no operation
        public double Result { get; set; } = 0.0; 
        public bool ResetInput { get; set; } = false; 
    }
}