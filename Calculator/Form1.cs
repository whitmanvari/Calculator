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
        public Calculator()
        {
            InitializeComponent();
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
