string userInput;
int number;

bool isPrimeNumber = true;

Console.WriteLine("enter a number");
number = int.Parse(userInput = Console.ReadLine());

for (int i = 2; i < number-1; i++)
{
    int result = number % i;
    if (result == 0)
    {
        isPrimeNumber = false;
    }
}

if(isPrimeNumber)
Console.WriteLine(number + " is a prime number");
else
Console.WriteLine(number + " isn't a prime number");