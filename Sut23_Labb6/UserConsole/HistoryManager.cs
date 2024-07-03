using Sut23_Labb6.CalculatorMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sut23_Labb6.UserConsole
{
    public class HistoryManager
    {
        private List<Calculation> calculationHistory = new List<Calculation>();

        public void AddCalculation(Calculation calculation)
        {
            calculationHistory.Add(calculation);
        }

        public void ShowHistory()
        {
            if (calculationHistory.Count == 0)
            {
                Console.WriteLine("Inga tidigare uträkningar.");
            }
            else
            {
                Console.WriteLine("Tidigare uträkningar:");
                foreach (var calc in calculationHistory)
                {
                    Console.WriteLine(calc);
                }
            }
        }
    }
}
