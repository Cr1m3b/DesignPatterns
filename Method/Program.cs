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

}
