using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choise = "1";
            if (choise == "1")
            {
                MasterCard m = new MasterCard();
                m.GetCardType();
            }
            else if (choise == "2")
            {
                VisaCard v = new VisaCard();
                v.GetCardType();
            }
            else if (choise == "3")
            {
                PaySafeCard p = new PaySafeCard();
                p.GetCardType();
            }

        }

        class MasterCard
        {
            public string GetCardType()
            {
                return "Master Card.";
            }
            public int GetCreditLimit()
            {
                return 35000;
            }
        }
        class VisaCard
        {
            public string GetCardType()
            {
                return "Visa Card.";
            }
            public int GetCreditLimit()
            {
                return 25000;
            }
        }
        class PaySafeCard
        {
            public string GetCardType()
            {
                return "Pay Safe Card.";
            }
            public int GetCreditLimit()
            {
                return 15000;
            }
        }


    }
}
