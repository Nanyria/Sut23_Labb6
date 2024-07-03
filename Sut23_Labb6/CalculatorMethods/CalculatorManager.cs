using Sut23_Labb6.UserConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sut23_Labb6.CalculatorMethods
{
    public class CalculatorManager
    {
        private HistoryManager historyManager = new HistoryManager();
        private Calculator calculator = new Calculator();
        private UserInterface userInterface = new UserInterface();

        public void PerformCalculation(int choice)
        {
            double number1 = userInterface.GetNumber("Mata in det första talet:");
            double number2 = userInterface.GetNumber("Mata in det andra talet:");
            double result = 0;
            string operation = "";

            try
            {
                switch (choice)
                {
                    case 1:
                        result = calculator.Add(number1, number2);
                        operation = "+";
                        break;
                    case 2:
                        result = calculator.Subtract(number1, number2);
                        operation = "-";
                        break;
                    case 3:
                        result = calculator.Multiply(number1, number2);
                        operation = "*";
                        break;
                    case 4:
                        result = calculator.Divide(number1, number2);
                        operation = "/";
                        break;
                    default:
                        userInterface.ShowMessage("Ogiltigt val.");
                        return;
                }

                var calculation = new Calculation(number1, number2, operation, result);
                historyManager.AddCalculation(calculation);
                userInterface.ShowMessage("Resultat: " + result);
            }
            catch (DivideByZeroException dbzEx)
            {
                userInterface.ShowMessage(dbzEx.Message);
            }
            catch (Exception ex)
            {
                userInterface.ShowMessage("Ett fel uppstod: " + ex.Message);
            }
        }

    }
}
