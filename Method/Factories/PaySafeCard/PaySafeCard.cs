namespace FactoryMethod
{
    public class PaySafeCard : ICard
    {
        public string GetCardType() { return "Pay Safe Card."; }
        public int GetCreditLimit() { return 15000; }
    }

}
