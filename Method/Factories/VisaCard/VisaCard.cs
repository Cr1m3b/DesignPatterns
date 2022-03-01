namespace FactoryMethod
{
    public class VisaCard : ICard
    {
        public string GetCardType() { return "Visa Card."; }
        public int GetCreditLimit() { return 25000; }
    }

}
