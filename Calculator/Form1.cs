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
            ButtonHelper.NumberClicked(btn_zero, "0", _model, pnl_simultaneousResult);
            ButtonHelper.NumberClicked(btn_one, "1", _model, pnl_simultaneousResult);
            ButtonHelper.NumberClicked(btn_two, "2", _model, pnl_simultaneousResult);
            ButtonHelper.NumberClicked(btn_three, "3", _model, pnl_simultaneousResult);
            ButtonHelper.NumberClicked(btn_four, "4", _model, pnl_simultaneousResult);
            ButtonHelper.NumberClicked(btn_five, "5", _model, pnl_simultaneousResult);
            ButtonHelper.NumberClicked(btn_six, "6", _model, pnl_simultaneousResult);
            ButtonHelper.NumberClicked(btn_seven, "7", _model, pnl_simultaneousResult);
            ButtonHelper.NumberClicked(btn_eigth, "8", _model, pnl_simultaneousResult);
            ButtonHelper.NumberClicked(btn_nine, "9", _model, pnl_simultaneousResult);
            ButtonHelper.OperationsClicked(btn_plus, "+", _model, pnl_simultaneousResult);
            ButtonHelper.OperationsClicked(btn_minus, "-", _model, pnl_simultaneousResult);
            ButtonHelper.OperationsClicked(btn_multiply, "x", _model, pnl_simultaneousResult);
            ButtonHelper.OperationsClicked(btn_divide, "/", _model, pnl_simultaneousResult);
            ButtonHelper.OperationsClicked(btn_sin, "sin", _model, pnl_simultaneousResult);
            ButtonHelper.OperationsClicked(btn_cos, "cos", _model, pnl_simultaneousResult);
            ButtonHelper.OperationsClicked(btn_tan, "tan", _model, pnl_simultaneousResult);
            ButtonHelper.OperationsClicked(btn_ctg, "cot", _model, pnl_simultaneousResult);
            ButtonHelper.OperationsClicked(btn_sec, "sec", _model, pnl_simultaneousResult);

            btn_equal.Click += (sender, e) =>
            {
                if(!string.IsNullOrWhiteSpace(_model.PreviousInput) && !string.IsNullOrWhiteSpace(_model.CurrentInput))
                {
                    var num1 = double.Parse(_model.PreviousInput);
                    var num2 = double.Parse(_model.CurrentInput);
                    var basicOperation = new Operations.BasicOperations();
                    _model.Result = basicOperation.Calculate(num1, num2);
                    pnl_simultaneousResult.Text = _model.Result.ToString();
                    _model.CurrentInput = _model.Result.ToString(); // Update current input with the result
                    _model.ResetInput = true; // Reset the input for the next calculation
                }
            };
            btn_deleteAll.Click += (sender, e) =>
            {
                _model.CurrentInput = "";
                _model.PreviousInput = "";
                _model.Operation = "";
                _model.Result = 0.0;
                pnl_simultaneousResult.Text = "0"; // Reset the display
            };
        }

        private void pnl_exit_Paint(object sender, PaintEventArgs e)
        {
            this.Close();
        }

        private void pnl_maximize_Paint(object sender, PaintEventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pnl_minimize_Paint(object sender, PaintEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
