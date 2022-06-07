using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_pattern_example.StateFolder
{
    // Represents ussual working state of an atm.
    public class WorkingState : State
    {
        public override void Handle(ATM atm)
        {
            Console.WriteLine("\nProcessing your request...");
        }
    }
}
