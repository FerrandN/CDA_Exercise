int a = 0;
int b = 0;
String userInput;
bool validInput = false;
do
{
    try
    {
        Console.WriteLine("Please enter a number");
        userInput = Console.ReadLine();
        a = Int32.Parse(userInput);
        validInput= true;
    }
    catch
    {
        Console.WriteLine("Wrong input");
    }
}while(!validInput);

validInput = false;
do
{
    try
    {
        Console.WriteLine("Please enter another number");
        userInput = Console.ReadLine();
        b = Int32.Parse(userInput);
        validInput = true;
    }
    catch
    {
        Console.WriteLine("Wrong input");
    }
} while (!validInput);

int swap = a;

a = b;
b = swap;

Console.WriteLine("We swapped the numbers... because why not after all. Now the first number is " + a +" and the second number is " + b);