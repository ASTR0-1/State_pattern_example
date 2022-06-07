using State_pattern_example.StateFolder;
using System;

namespace State_pattern_example
{
    public class ATM
    {
        public State State;
        public decimal _availableMoneyInATM;
        public Card _currentCard;

        public ATM(State state, decimal availableMoneyInAtm)
        {
            State = state;
            _availableMoneyInATM = availableMoneyInAtm;
        }

        public void InsertCard(Card card)
        {
            State.Handle(this);

            Console.Write("Please enter card pin: ");
            string _pin = Console.ReadLine();
            if (_pin != card.pin || _pin == null)
            {
                State = new InvalidPinState();
                State.Handle(this);
            }
            else if (_pin == card.pin && _pin != null)
                _currentCard = card;
            else
                Console.WriteLine("Something went wrong. Please try again.");

        }
        public void RemoveCard()
        {
            State.Handle(this);

            _currentCard = null;
            Console.WriteLine("Card removed successfuly.");
        }

        public void CheckBalance()
        {
            State.Handle(this);

            Console.WriteLine($"Your current balance is: {_currentCard.moneyAmount}");
        }

        public void Deposit()
        {
            State.Handle(this);

            Console.Write("Insert sum you want to deposit: ");
            decimal moneyToDeposit = Convert.ToDecimal(Console.ReadLine());
            _currentCard.moneyAmount += moneyToDeposit;
            _availableMoneyInATM += moneyToDeposit;
            Console.WriteLine("You've successfully deposited money!");
        }

        public void Withdraw()
        {
            State.Handle(this);

            if (_availableMoneyInATM > 0)
            {
                Console.Write("Insert sum you want to withdraw: ");
                decimal moneyToWithdraw = Convert.ToDecimal(Console.ReadLine());
                if (moneyToWithdraw > _availableMoneyInATM)
                {
                    State = new NEMoneyInAtmState();
                    State.Handle(this);
                }
                else if (moneyToWithdraw < _availableMoneyInATM && moneyToWithdraw > _currentCard.moneyAmount)
                {
                    State = new NEMoneyOnAccountState();
                    State.Handle(this);
                }
                else
                {
                    State.Handle(this);

                    _currentCard.moneyAmount -= moneyToWithdraw;
                    _availableMoneyInATM -= moneyToWithdraw;
                }
            }
        }
    }
}
