using BankAccount;
using Banques;
using System.ComponentModel.DataAnnotations.Schema;

//Bank myBank = new Bank("LBP","Lyon");
//myBank.AddAccount(1000, 0, 200, "Rodolphe");
//myBank.AddAccount(1500, 1, 200, "Gerard");
//myBank.AddAccount(100, 2, 200, "Mathieu");
//myBank.AddAccount(90000, 3, 200, "Nicolas");

//myBank.DisplayInformation();
//myBank.ReturnAccountWithHighestBalance().DisplayInformation();

//myBank.Accounts[1].Transfert(50, myBank.Accounts[2]);
Bank otherBank = new Bank("nom","ville");

otherBank.ReturnAccountWithHighestBalance();
Console.WriteLine(otherBank.DisplayInformation());