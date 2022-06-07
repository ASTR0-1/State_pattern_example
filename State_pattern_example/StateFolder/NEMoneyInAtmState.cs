using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_pattern_example.StateFolder
{
    // Represents NotEnoughMoneyInAtm state.
    public class NEMoneyInAtmState : State
    {
        public override void Handle(ATM atm)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nWe can't process your withdraw because of not enough money in this ATM. \nPlease try again later.");
            Console.ResetColor();
            atm.State = new WorkingState();
        }
    }
}
