using State_pattern_example.StateFolder;
using System;

namespace State_pattern_example
{
    public class Program
    {
        static void Main()
        {
            Card card = new Card(1250, "Alex Furov", 1, "4441 5757 1249 4183", "848");

            ATM atm = new ATM(new WorkingState(), 100);

            Menu(atm, card);
        }

        static void Menu(ATM atm, Card card)
        {
            bool working = true;
            while (working)
            {
                Console.WriteLine("Enter option: ");
                Console.WriteLine("1. Insert card;");
                Console.WriteLine("2. Exit.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        atm.InsertCard(card);
                        if(atm._currentCard != null)
                            UserMenu(atm);
                        break;
                    case 2:
                        working = false;
                        break;
                }
            }
        }

        static void UserMenu(ATM atm)
        {
            bool working = true;
            while (working)
            {
                Console.WriteLine("Enter option: ");
                Console.WriteLine("1. Remove card;");
                Console.WriteLine("2. Deposit;");
                Console.WriteLine("3. Withdraw;");
                Console.WriteLine("4. Check balance.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        atm.RemoveCard();
                        working = false;
                        break;
                    case 2:
                        atm.Deposit();
                        break;
                    case 3:
                        atm.Withdraw();
                        break;
                    case 4:
                        atm.CheckBalance();
                        break;
                }
            }
        }
    }
}
