using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_pattern_example.StateFolder
{
    // Represents InvalidPin state.
    public class InvalidPinState : State
    {
        public override void Handle(ATM atm)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYou've entered invalid PIN. Please try again.");
            Console.ResetColor();
            atm.State = new WorkingState();
        }
    }
}
