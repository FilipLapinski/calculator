using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Calculator
    {
        public double result = 0;
        public String operation = "";
        public bool process = false;
        public Calculator()
        {
        }

        public double Add(double variable1, double variable2)
        {
            return variable1 + variable2;
        }

        public double Subtract(double variable1, double variable2)
        {
            return variable1 - variable2;
        }

        public double Multiply(double variable1, double variable2)
        {
            return variable1 * variable2;
        }

        public double Divide(double variable1, double variable2)
        {
            return variable1 / variable2;
        }

        public double Power(double variable1, double variable2)
        {
            return Math.Pow(variable1, variable2);
        }

        public double Root(double variable1, double variable2)
        {
            return Math.Pow(variable1, 1 / variable2);
        }

        public double Square(double variable1)
        {
            return variable1 * variable1;
        }

        public double SquareRoot(double variable1)
        {
            return Math.Sqrt(variable1);
        }

        public double Fraction(double variable1)
        {
            return 1 / variable1;
        }

        public double Negation(double variable1)
        {
            return - variable1;
        }

        public double Precent(double variable1)
        {
            return variable1 * 0.01;
        }
    }
}
