using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICard card = new MasterCardFactory().CreateCard();
            Console.WriteLine(card.GetCardType());
            Console.WriteLine(card.GetCreditLimit());
        }
    }
    interface ICreateFactory
    {
        ICard CreateCard();
    }
    public interface ICard
    {
        string GetCardType();
        int GetCreditLimit();
    }
    public class MasterCardFactory : ICreateFactory
    {
        public ICard CreateCard()
        {
            return new MasterCard();
        }
    }
    public class MasterCard : ICard
    {
        public string GetCardType() { return "Master Card."; }
        public int GetCreditLimit() { return 35000; }
    }
    public class VisaCardFactory : ICreateFactory
    {
        public ICard CreateCard()
        {
            throw new NotImplementedException();
        }
    }
    public class VisaCard : ICard
    {
        public string GetCardType() { return "Visa Card."; }
        public int GetCreditLimit() { return 25000; }
    }
    public class PaySafeCardFactory : ICreateFactory
    {
        public ICard CreateCard()
        {
            throw new NotImplementedException();
        }
    }
    public class PaySafeCard : ICard
    {
        public string GetCardType() { return "Pay Safe Card."; }
        public int GetCreditLimit() { return 15000; }
    }

}
