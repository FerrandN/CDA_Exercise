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

        public BankAccounts(double _balance, double _Id, double _overdraft, string _ownerName)
        {
            this.balance = _balance;
            this.Id = _Id;
            this.overdraft = _overdraft;
            this.ownerName = _ownerName;
        }
        public bool CompareToOtherAccount(BankAccounts acc)
        {
            if (acc.balance < balance)
            {
                Console.WriteLine(acc.ownerName + " a moin d'argent");
                return true;
            }
            else
            {
                Console.WriteLine(acc.ownerName + " a plus d'argent");
            }
            return false ;
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
            try
            {
                if(balance + overdraft < toWithdraw)
                {
                    Console.WriteLine("débit de {0} pas réussit", toWithdraw);
                    return false;
                }
                balance -= toWithdraw;
                Console.WriteLine("débit de {0} réussit", toWithdraw);
                return true;
            }
            catch
            {
                Console.WriteLine("débit de {0} pas réussit", toWithdraw);
                return false;
            }
        }

        public bool Transfert(double toTransfert, BankAccounts ToCredit)
        {
            try
            {
                Withdraw(toTransfert);
                ToCredit.Credit(toTransfert);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string DisplayInformation()
        {
            return string.Format("balance: {0} \n Id: {1} \n Overdraft: {2} \n Owner Name: {3}", balance, Id, overdraft, ownerName);
        }
    }
}
