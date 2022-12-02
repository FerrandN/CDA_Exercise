using ConsoleApp1;

bool withdrawSuccessfull = true;

BankAccount acc = new BankAccount(01, "Ferrand Nicolas", 500, -100);
BankAccount otherAcc = new BankAccount(02,"quelqu'un",1000000,-500);

acc.Display();
acc.Credits(500);
Console.WriteLine();
acc.Display();
Console.WriteLine();
acc.Withdraw(500);
Console.WriteLine();
acc.BankTransfert(acc, otherAcc, 500);
Console.WriteLine();

if(acc.isHigher(acc,otherAcc))
{
    Console.WriteLine("Ce compte à un montant superieur au compte " + acc.id);
}
else
{
    Console.WriteLine("Ce compte à un montant inferieur au compte " + otherAcc.id);
}

Console.WriteLine();
acc.Display();