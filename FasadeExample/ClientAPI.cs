using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    public class ClientAPI
    {
        private BallanceAccount ballanceAccount;
        private MoneySpent moneySpent;
        private MoneyTransfer moneyTransfer;

        public ClientAPI()
        {
            this.ballanceAccount = new BallanceAccount();
            this.moneySpent = new MoneySpent();
            this.moneyTransfer = new MoneyTransfer();
        }
        public void Account()
        {
            ballanceAccount.DisplayStateAccount();
        }
        public void MoneySpend()
        {
            moneySpent.MoneySpentLastMonth();
        }
        public void MoneyTransfer()
        {
            moneyTransfer.MakeMoneyTransfer();
        }
    }
    public class BallanceAccount
    {
        public void DisplayStateAccount()
        {
            Console.WriteLine("Wyświetlam stan konta : 10zł");
        }
    }
    public class MoneySpent
    {
        public void MoneySpentLastMonth()
        {
            Console.WriteLine("Wyświetlam sumę wydaną w zeszłym miesiącu : 12zł");
        }
    }
    public class MoneyTransfer
    {
        public void MakeMoneyTransfer()
        {
            Console.WriteLine("Wysłano pieniądze w kwocie : 3zł");
        }
    }
}
