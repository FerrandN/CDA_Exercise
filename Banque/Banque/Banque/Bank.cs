using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using BankAccount;

namespace Banques
{
    public class Bank
    {
        List<BankAccounts> accounts = new List<BankAccounts>();

        public List<BankAccounts> Accounts { get { return accounts; } }

        int accountCount;
        string name;
        string town;
        
        public Bank(string name, string town)
        {
            this.name = name;
            this.town = town;
        }
        private void AddAccount(BankAccounts account)
        {
            accounts.Add(account);
        }
        public void AddAccount(double _balance, double _Id, double _overdraft, string _ownerName)
        {
            accounts.Add(new BankAccounts(_balance,_Id,_overdraft,_ownerName));
            accountCount++;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Number of Accounts: {0}\nBank name: {1}\nTown: {2}", accountCount, name, town);
            foreach (BankAccounts account in accounts)
            {
                int i = 0;
                Console.WriteLine("Account {0} information:\n",i++);
                account.DisplayInformation();
            }
        }

        public BankAccounts returnAccountWithHighestBalance()
        {
            BankAccounts highestBankAccount = new BankAccounts(0,0,0,"noname");
            foreach (BankAccounts account in accounts)
            {
                if(account.balance > highestBankAccount.balance)
                {
                    highestBankAccount = account;
                }
            }
            return highestBankAccount;
        }

        public BankAccounts returnAccountLookingByID(int ID)
        {
            if(ID>accounts.Count() || ID < 0)
            {
                return null;
            }
            return accounts[ID];
        }

        public bool transfertValueToOtherBankAccount(BankAccounts accountToTakeFrom, BankAccounts accountToTransfert, double value)
        {
            if(accountToTakeFrom.Transfert(value, accountToTransfert) == true)
            {
                Console.WriteLine("Transfert successfull");
                return true;
            }
            else
            {
                Console.WriteLine("Transfert Failed");
                return false;
            }
        }
    }
}
