int a = 0;
int b = 0;
String userInput;
bool validInput = true;

Console.WriteLine("Please enter a number");

do 
{
    try
    {
        userInput = Console.ReadLine();
        a = int.Parse(userInput);
        validInput = true;
    }
    catch
    {
        Console.WriteLine("Wrong Input");
        validInput = false;
    }
}while (!validInput);


Console.WriteLine("Please enter a second number");

do
{
    try
    {
        userInput = Console.ReadLine();
        b = int.Parse(userInput);
        validInput = true;
    }
    catch
    {
        Console.WriteLine("Wrong Input");
        validInput = false;
    }
} while (!validInput);

if (b > a)
{
    Console.WriteLine(a +" "+ b);
}
else if (b == a)
{
    Console.WriteLine("both numbers are equal to: " + a);
}
else
{
    Console.WriteLine(b +" "+ a);
}