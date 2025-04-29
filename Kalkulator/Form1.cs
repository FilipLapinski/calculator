using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        Calculator calculator = new Calculator();
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if ((TextBoxResult.Text == "0") || (calculator.process))
            {
                TextBoxResult.Clear();
            }

            Button button = (Button)sender;
            
            if (button.Text == ",")
            {
                if (!TextBoxResult.Text.Contains(","))
                {
                    TextBoxResult.Text = TextBoxResult.Text + button.Text;
                } 
            }
            else
            {
                TextBoxResult.Text = TextBoxResult.Text + button.Text;
            }
            calculator.process = false;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(calculator.result != 0)
            {
                Equals.PerformClick();
                calculator.operation = button.Text;
                LabelOperation.Text = calculator.result + " " + calculator.operation;
                calculator.process = true;
                calculator.result = Double.Parse(TextBoxResult.Text);
            }
            else
            {
                calculator.operation = button.Text;
                calculator.result = Double.Parse(TextBoxResult.Text);
                LabelOperation.Text = calculator.result + " " + calculator.operation;
                calculator.process = true;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = "0";
            calculator.result = 0;
            LabelOperation.Text = "";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (calculator.operation)
            {
                case "+":
                    TextBoxResult.Text = calculator.Add(calculator.result, Double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "-":
                    TextBoxResult.Text = calculator.Subtract(calculator.result, Double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "*":
                    TextBoxResult.Text = calculator.Multiply(calculator.result, Double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "/":
                    TextBoxResult.Text = calculator.Divide(calculator.result, Double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "+/-":
                    TextBoxResult.Text = calculator.Negation(calculator.result).ToString();
                    break;
                case "%":
                    TextBoxResult.Text = calculator.Precent(calculator.result).ToString();
                    break;
                case "1/x":
                    TextBoxResult.Text = calculator.Fraction(calculator.result).ToString();
                    break;
                case "^2":
                    TextBoxResult.Text = calculator.Square(calculator.result).ToString();
                    break;
                case "^1/2":
                    TextBoxResult.Text = calculator.SquareRoot(calculator.result).ToString();
                    break;
                case "^x":
                    TextBoxResult.Text = calculator.Power(calculator.result, Double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "^1/x":
                    TextBoxResult.Text = calculator.Power(calculator.result, Double.Parse(TextBoxResult.Text)).ToString();
                    break;
                default:
                    break;

            }
            calculator.result = Double.Parse(TextBoxResult.Text);
            LabelOperation.Text = "";
        }
    }
}
