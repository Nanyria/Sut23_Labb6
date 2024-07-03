using Sut23_Labb6.CalculatorMethods;
using Sut23_Labb6.UserConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sut23_Labb6
{
    public class Application
    {
        private UserInterface userInterface = new UserInterface();
        private CalculatorManager calculatorManager = new CalculatorManager();

        public void Run()
        {
            while (true)
            {
                int choice = userInterface.GetUserChoice();

                if (choice == 6)
                {
                    break;
                }

                if (choice == 5)
                {
                    var historyManager = new HistoryManager();
                    historyManager.ShowHistory();
                    continue;
                }

                calculatorManager.PerformCalculation(choice);
            }
        }
    }
}
