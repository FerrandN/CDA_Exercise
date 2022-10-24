bool isPrimeNumber = true;
int number = 0;
bool wrongInput = false;
String userInput;

Console.WriteLine("Please enter a number");
do
{
    try
    {
        userInput = Console.ReadLine();
        number = int.Parse(userInput);
        wrongInput = true;
    }
    catch
    {
        Console.WriteLine("Wrong input");
    }
}while (wrongInput == false);

for (int i = 2; i < number; i++)
{ 
    if(number%i ==0)
    {
        isPrimeNumber = false;
    }
}

if (isPrimeNumber == false)
{
    Console.WriteLine(number + " isn't a prime number");
}
else
{
    Console.WriteLine(number + " is a prime number");
}