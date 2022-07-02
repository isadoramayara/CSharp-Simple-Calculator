using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMSS.Calculator
{
    public partial class Calculator : Form
    {
        char[] mathOP = {'+','-','÷','×'};
        bool cleanDisplay = false;
        double num1;
        double num2;
        double? result = null;

        public Calculator()
        {
            InitializeComponent();
        }
 
        // Calculator Display
        private void boxDisplay_TextChanged(object sender, EventArgs e)
        {
            if (boxDisplay.TextLength > 17)
               boxDisplay.Text = boxDisplay.Text.Substring(0, 17);
        }

        // Generic Buttons
        private void numButtons(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (cleanDisplay == true)
                boxDisplay.Text = "";
                cleanDisplay = false;

            if (btn.Text != "." || !boxDisplay.Text.Contains("."))
                boxDisplay.Text += btn.Text;
        }

        // Mathematical Operators buttons
        private void mathOperators(object sender, EventArgs e)
        {
            Button operators = (Button)sender;

            if (boxDisplay.Text == "")
                boxDisplay.Text = "0";

            lblExpression.Text += boxDisplay.Text;
            expressionVerification();
            lblExpression.Text += operators.Text;

            cleanDisplay = true;

        }

        // Equal button
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (mathOP.Any(m => lblExpression.Text.Contains(m)))
            {
                lblExpression.Text += boxDisplay.Text;
                startCalculation();
            }
        }

        void startCalculation()
        {
            string[] expression = lblExpression.Text.Split(mathOP);

            double.TryParse(expression[0], out num1);
            double.TryParse(expression[1], out num2);

            basicOperations();

            boxDisplay.Text = result.ToString();
            lblExpression.Text = "";
            Array.Clear(expression,0,expression.Length);
            cleanDisplay = true;
        }

        // Clear last character
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                boxDisplay.Text = boxDisplay.Text.Substring(0, boxDisplay.TextLength - 1);
            }
            catch
            {
                Console.Beep();
            }
        }

        // Clear all calculator operations and box
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            boxDisplay.Text = "";
            lblExpression.Text = "";
            result = null;
        }

        /** Equal Button click Events **/
        void expressionVerification()
        {
            if (boxDisplay.Text.Substring(0,1) == "-")
            {
                lblExpression.Text = "0";
                boxDisplay.Text = "";
            }

            string[] expression = lblExpression.Text.Split(mathOP);

            if (expression.Length >= 2)
            {
                startCalculation();
                lblExpression.Text = result.ToString();
            }
        }

        /** Math Operations **/
        void basicOperations()
        {

            if (lblExpression.Text.Contains('+')) 
                result = num1 + num2;

            if (lblExpression.Text.Contains('-'))
                result = num1 - num2;

            if (lblExpression.Text.Contains('÷'))
                result = num1 / num2;

            if (lblExpression.Text.Contains('×'))
                result = num1 * num2;
        }
    }
}