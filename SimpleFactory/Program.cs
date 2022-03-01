using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICard card = SimpleFactory(Card.MasterCard);
            ICard card2 = SimpleFactory(Card.VisaCard);
            ICard card3 = SimpleFactory(Card.PaySafeCard);
            Console.WriteLine(card.GetCardType());
            Console.WriteLine(card.GetCreditLimit());
            Console.WriteLine(card2.GetCardType());
            Console.WriteLine(card2.GetCreditLimit());
            Console.WriteLine(card3.GetCardType());
            Console.WriteLine(card3.GetCreditLimit());

        }

        public static ICard SimpleFactory(Card choise)
        {
            switch (choise)
            {
                case Card.MasterCard: return new MasterCard();
                case Card.VisaCard: return new VisaCard();
                case Card.PaySafeCard: return new PaySafeCard();
                default: return null;
            }
        }
    }
    
    enum Card
    {
        MasterCard,
        VisaCard,
        PaySafeCard
    }

    interface ICard
    {
        string GetCardType();
        int GetCreditLimit();
    }
    class MasterCard : ICard
    {
        public string GetCardType() { return "Master Card."; }
        public int GetCreditLimit() { return 35000; }
    }
    class VisaCard : ICard
    {
        public string GetCardType() { return "Visa Card."; }
        public int GetCreditLimit() { return 25000; }
    }
    class PaySafeCard : ICard
    {
        public string GetCardType() { return "Pay Safe Card."; }
        public int GetCreditLimit() { return 15000; }
    }
}
