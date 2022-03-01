using System;

namespace FactoryMethod
{
    public class PaySafeCardFactory : ICreateFactory
    {
        public ICard CreateCard()
        {
            throw new NotImplementedException();
        }
    }

}
