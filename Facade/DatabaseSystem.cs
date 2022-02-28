using System;

namespace Facade
{
    public class DatabaseSystem
    {
        public void ConnectToDataBase()
        {
            Console.WriteLine("Connecting to DB.....");
        }
        public void LoadUser()
        {
            Console.WriteLine("Loading User.....");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("Withdrawing Money.....");
        }
        public void DepositMoney()
        {
            Console.WriteLine("Depositing Money.....");
        }
        public void BalanceMoney()
        {
            Console.WriteLine("Getting Account Money.....");
        }
        public void TransferMoney()
        {
            Console.WriteLine("Transfering Money...");
        }


    }

    
}
