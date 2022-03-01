namespace FactoryMethod
{
    public class MasterCard : ICard
    {
        public string GetCardType() { return "Master Card."; }
        public int GetCreditLimit() { return 35000; }
    }

}
