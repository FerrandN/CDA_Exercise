using BankAccount;
using Banques;

Bank myBank = new Bank("LBP","Lyon");
myBank.AddAccount(1000, 0, 200, "Rodolphe");
myBank.AddAccount(1500, 1, 200, "Gerard");
myBank.AddAccount(100, 2, 200, "Mathieu");
myBank.AddAccount(90000, 3, 200, "Nicolas");

myBank.DisplayInformation();
myBank.returnAccountWithHighestBalance().DisplayInformation();

myBank.Accounts[1].Transfert(50, myBank.Accounts[2]);
bool result = myBank.transfertValueToOtherBankAccount(myBank.Accounts[1],myBank.Accounts[2],500);