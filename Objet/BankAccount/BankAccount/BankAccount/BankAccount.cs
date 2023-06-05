using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccounts
    {
        public double balance;
        public double Id;
        public double overdraft;
        public string ownerName;

        public BankAccounts(double _balance, double _Id, double _overdraft, string _ownername)
        {
            this.balance = _balance;
            this.Id = _Id;
            this.overdraft = _overdraft;
            this.ownerName = _ownername;
        }
        public bool CompareToOtherAccount(BankAccounts acc)
        {
            if (acc.balance < balance)
            {
                return true;
            }
            return false;
        }

        public bool Credit(double toAdd)
        {
            try
            {
                balance += toAdd;
                Console.WriteLine("crédit de {0} réussit", toAdd);
                return true;
            }
            catch
            {
                Console.WriteLine("crédit de {0} pas réussit", toAdd);
                return false;
            }
        }

        public bool Withdraw(double toWithdraw)
        {

            if (balance + overdraft < toWithdraw)
            {
                Console.WriteLine("débit de {0} pas réussit", toWithdraw);
                return false;
            }
            balance -= toWithdraw;
            Console.WriteLine("débit de {0} réussit", toWithdraw);
            return true;

        }

        public bool Transfert(double toTransfert, BankAccounts toCredit)
        {
            if (Withdraw(toTransfert))
            {
                toCredit.Credit(toTransfert);
                return true;
            }
            return false;
        }

        public void DisplayInformation()
        {
            Console.WriteLine(" balance: {0} \n Id: {1} \n Overdraft: {2} \n Owner Name: {3}", balance, Id, overdraft, ownerName);
        }
    }
}
