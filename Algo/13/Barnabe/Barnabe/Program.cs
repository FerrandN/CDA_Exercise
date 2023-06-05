double balance = 1500;
double depense;

do
{
    Console.WriteLine("Barnabe a " + balance + " euros");
    depense = (balance / 2) + 1;
    if (balance - depense > 1)
    {
        balance = balance - depense;
    }
    else
    {
        depense = balance;
        balance = 0;
    }
    Console.WriteLine("Barnabe a dépensé " + depense + " euros." + " IL lui reste " + balance);
} while (balance > 0);