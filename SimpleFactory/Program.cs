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
            ICard card = SimpleFactory("1");
            Console.WriteLine(card.GetCardType());
            Console.WriteLine(card.GetCreditLimit());
        }

        public static ICard SimpleFactory(string choise)
        {
            switch (choise)
            {
                case "1": return new MasterCard();
                case "2": return new VisaCard();
                case "3": return new PaySafeCard();
                default: return null;
            }
        }
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
