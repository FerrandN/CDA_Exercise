
using BankAccount;

BankAccounts myBankAccount = new BankAccounts(100, 01 , 500 , "Poney");
BankAccounts ielBankAccount = new BankAccounts(0, 02, 500, "cat");

myBankAccount.DisplayInformation();

myBankAccount.Credit(100);
myBankAccount.Withdraw(1000);

myBankAccount.DisplayInformation();

myBankAccount.Transfert(100, ielBankAccount);

myBankAccount.DisplayInformation();
ielBankAccount.DisplayInformation();

myBankAccount.CompareToOtherAccount(ielBankAccount);