using System;
namespace Facade
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BankSystemFacade bank = new BankSystemFacade();

            bank.WithdrawLogic();
            Console.WriteLine("-------------");
            bank.DepositLogic();
            Console.WriteLine("-------------");


        }
    }
    public class BankSystemFacade
    {
        private DatabaseSystem db;
        private UserInterfaceSystem ui;
        private AuthenticationSystem auth;
        public BankSystemFacade()
        {
            db = new DatabaseSystem();
            ui = new UserInterfaceSystem();
            auth = new AuthenticationSystem();
        }

        public void WithdrawLogic()
        {
            db.ConnectToDataBase();
            auth.GetCredentials();
            db.LoadUser();
            ui.WithdrawView();
            db.WithdrawMoney();
        }
        public void DepositLogic()
        {
            db.ConnectToDataBase();
            auth.GetCredentials();
            db.LoadUser();
            ui.DepositView();
        }
        public void AccountLogic()
        {
            db.ConnectToDataBase();
            auth.GetCredentials();
            db.LoadUser();
        }


    }

}
