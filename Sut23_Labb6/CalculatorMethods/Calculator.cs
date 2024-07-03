using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sut23_Labb6.CalculatorMethods
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division med noll är inte tillåten.");
            }
            return a / b;
        }
    }
}
