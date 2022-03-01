namespace FactoryMethod
{
    public class MasterCardFactory : ICreateFactory
    {
        public ICard CreateCard()
        {
            return new MasterCard();
        }
    }

}
