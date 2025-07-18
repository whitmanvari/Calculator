using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Helpers
{
    public class ButtonHelper
    {
        public static void NumberClicked(FlowLayoutPanel button, string number, CalculatorModel model, Panel result)
        {
            button.Click += (sender, e) =>
            {
                if (model.ResetInput) //One of the properties of CalculatorModel
                {
                    model.CurrentInput = ""; // Reset the current input if needed
                    model.ResetInput = false; // Reset the flag
                }
                model.CurrentInput += number;
                result.Text = model.CurrentInput; // Update the result label with the current input

            };
        }
        public static void OperationsClicked(FlowLayoutPanel button, string operation, CalculatorModel model, Panel result)
        {
            button.Click += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(model.CurrentInput))
                {
                    model.PreviousInput = model.CurrentInput;
                    model.Operation = operation; // Set the operation
                    model.CurrentInput = ""; // Reset the current input for the next number
                    result.Text = "0"; //Reset result 
                }
            };
        }
    }
}
