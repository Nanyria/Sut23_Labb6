using Sut23_Labb6.CalculatorMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sut23_Labb6.UserConsole
{
    public class UserInterface
    {
        public int GetUserChoice()
        {
            Console.WriteLine("Välj ett räknesätt: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Visa alla tidigare uträkningar");
            Console.WriteLine("6. Avsluta");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
            {
                Console.WriteLine("Ogiltigt val. Försök igen.");
            }

            return choice;
        }

        public double GetNumber(string prompt)
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ogiltig inmatning. Mata in ett giltigt nummer.");
            }
            return number;
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}

