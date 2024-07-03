using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sut23_Labb6.CalculatorMethods
{
    public class Calculation
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string Operation { get; set; }
        public double Result { get; set; }

        public Calculation(double number1, double number2, string operation, double result)
        {
            Number1 = number1;
            Number2 = number2;
            Operation = operation;
            Result = result;
        }

        public override string ToString()
        {
            return $"{Number1} {Operation} {Number2} = {Result}";
        }
    }
}
