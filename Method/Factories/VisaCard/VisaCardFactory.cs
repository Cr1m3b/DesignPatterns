using System;

namespace FactoryMethod
{
    public class VisaCardFactory : ICreateFactory
    {
        public ICard CreateCard()
        {
            throw new NotImplementedException();
        }
    }

}
