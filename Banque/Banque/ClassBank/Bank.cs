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
        List<BankAccounts> accounts;

        public List<BankAccounts> Accounts { get { return accounts; } }

        string name;
        string town;
        
        public Bank(string name, string town)
        {
            accounts = new List<BankAccounts>();
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
        }

        public string DisplayInformation()
        {
            string s = string.Format("Number of Accounts: {0}\nBank name: {1}\nTown: {2}",Accounts.Count, name, town); ;
            foreach (BankAccounts account in accounts)
            {
                int i = 0;
                s += ("Account {0} information:\n",i++);
                account.DisplayInformation();
            }
            return s;
        }

        public BankAccounts ReturnAccountWithHighestBalance()
        {
            BankAccounts highestBankAccount = null;
            foreach (BankAccounts account in accounts)
            {
                if(account.balance > highestBankAccount.balance || highestBankAccount == null)
                {
                    highestBankAccount = account;
                }
            }
            return highestBankAccount;
        }

        public BankAccounts ReturnAccountLookingByID(int ID)
        {
            try
            {
                return accounts[ID];
            }
            catch
            {
                throw new Exception("Le compte n'a pas été trouvé");
            }
        }

        public bool TransfertValueToOtherBankAccount(BankAccounts accountToTakeFrom, BankAccounts accountToTransfert, double value)
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
