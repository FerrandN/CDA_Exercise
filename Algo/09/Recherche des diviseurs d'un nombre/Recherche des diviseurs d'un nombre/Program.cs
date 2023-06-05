int number = 0;
String userInput;

Console.WriteLine("Enter a number");

try
{
    userInput = Console.ReadLine();
    number=int.Parse(userInput);
}
catch
{
    Console.WriteLine("Invalid input");
}

for (int i = 2; i < number; i++)
{
    if (number % i == 0)
    {
        Console.WriteLine(i + " is a divisor");
    }
}