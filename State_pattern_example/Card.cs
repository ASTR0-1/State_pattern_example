namespace State_pattern_example
{
    public class Card
    {
        public decimal moneyAmount;
        public string fullName;
        public int accountId;
        public string cardNumber;
        public string pin;

        public Card(decimal amount, string fullName, int accountId, string cardNumber, string pin)
        {
            this.moneyAmount = amount;
            this.fullName = fullName;
            this.accountId = accountId;
            this.cardNumber = cardNumber;
            this.pin = pin;
        }
    }
}
