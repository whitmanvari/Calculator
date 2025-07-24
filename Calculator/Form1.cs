using Calculator.Helpers;
using Calculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private CalculatorModel _model = new CalculatorModel();
        public Calculator()
        {
            InitializeComponent();
            InitializeButtonEvents();
        }

        private void InitializeButtonEvents()
        {
            ButtonHelper.NumberClicked(btn_zero, "0", _model, lbl_currentResult);
            ButtonHelper.NumberClicked(btn_one, "1", _model, lbl_currentResult);
            ButtonHelper.NumberClicked(btn_two, "2", _model, lbl_currentResult);
            ButtonHelper.NumberClicked(btn_three, "3", _model, lbl_currentResult);
            ButtonHelper.NumberClicked(btn_four, "4", _model, lbl_currentResult);
            ButtonHelper.NumberClicked(btn_five, "5", _model, lbl_currentResult);
            ButtonHelper.NumberClicked(btn_six, "6", _model, lbl_currentResult);
            ButtonHelper.NumberClicked(btn_seven, "7", _model, lbl_currentResult);
            ButtonHelper.NumberClicked(btn_eigth, "8", _model, lbl_currentResult);
            ButtonHelper.NumberClicked(btn_nine, "9", _model, lbl_currentResult);
            ButtonHelper.OperationsClicked(btn_plus, "+", _model, lbl_currentResult);
            ButtonHelper.OperationsClicked(btn_minus, "-", _model, lbl_currentResult);
            ButtonHelper.OperationsClicked(btn_multiply, "x", _model, lbl_currentResult);
            ButtonHelper.OperationsClicked(btn_divide, "/", _model, lbl_currentResult);
            ButtonHelper.OperationsClicked(btn_sin, "sin", _model, lbl_currentResult);
            ButtonHelper.OperationsClicked(btn_cos, "cos", _model, lbl_currentResult);
            ButtonHelper.OperationsClicked(btn_tan, "tan", _model, lbl_currentResult);
            ButtonHelper.OperationsClicked(btn_ctg, "cot", _model, lbl_currentResult);
            ButtonHelper.OperationsClicked(btn_sec, "sec", _model, lbl_currentResult);

            btn_equal.Click += (sender, e) =>
            {
                if(!string.IsNullOrWhiteSpace(_model.PreviousInput) && !string.IsNullOrWhiteSpace(_model.CurrentInput))
                {
                    
                    var num1 = double.Parse(_model.PreviousInput);
                    var num2 = double.Parse(_model.CurrentInput);
                    
                    var basicOperation = new Operations.BasicOperations();
                    _model.Result = basicOperation.Calculate(num1, num2,_model.Operation);
                    lbl_currentResult.Text = _model.Result.ToString();
                    _model.CurrentInput = _model.Result.ToString(); // Update current input with the result
                    lbl_result.Text = _model.Result.ToString(); // Display the result
                    _model.PreviousInput = ""; // Clear previous input after calculation
                    _model.ResetInput = true; // Reset the input for the next calculation
                }
            };
            btn_deleteAll.Click += (sender, e) =>
            {
                _model.CurrentInput = "";
                _model.PreviousInput = "";
                _model.Operation = "";
                _model.Result = 0.0;
                lbl_currentResult.Text = "0"; // Reset the display
                lbl_result.Text = ""; // Clear the result label
            };
        }

        private void pnl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pnl_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
