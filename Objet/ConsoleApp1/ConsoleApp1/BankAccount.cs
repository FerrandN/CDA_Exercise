using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BankAccount
    {
        public int id;
        string owner;
        public float balance;
        int overdraft;

        public BankAccount(int _id, string _owner, float _balance, int _overdraft)
        {
            id = _id;
            owner = _owner;
            balance = _balance;
            overdraft = _overdraft;
        }

        public void Display()
        {
            Console.WriteLine(owner);
            Console.WriteLine("Votre numero de compte est: " + id);
            Console.WriteLine("Il vous reste: "+balance+ " sur votre compte.");
            Console.WriteLine("Votre découvert autorisé est de: "+overdraft);
        }

        public float Credits(float toAdd)
        {
            balance += toAdd;
            return toAdd;
        }

        public bool Withdraw(float toWithdraw)
        {
            bool success = true;
            if(balance<toWithdraw)
            {
                Console.WriteLine("Transaction refusé");
                success = false;
            }
            else
            {
                balance -= toWithdraw;
                Console.WriteLine("L'opération s'est déroulé avec succès");
            }
            return success;
        }

        public bool BankTransfert(BankAccount a,BankAccount b, float value)
        {
            bool success = true;

                if(a.balance <= value)
                {
                    a.Withdraw(value);
                    b.Credits(value);
                    Console.WriteLine("L'operation de transfert de: " + value + " du compte " + a.id + " vers " + b.id + " s'est déroulé avec succès");
                }
                else
                {
                    success = false;
                }
            return success;
        }
        public bool isHigher(BankAccount a, BankAccount b)
        {
            bool isHigher = true;
            if (a.balance < b.balance)
            {
                isHigher = false;
            }
            return isHigher;
        }
    }
}
