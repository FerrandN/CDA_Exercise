using System.Text.RegularExpressions;

int number1;
int number2;
string userInput;

Console.WriteLine("Enter number 1");
userInput = Console.ReadLine();
userInput = Regex.Replace(userInput, "[^0-9]","");
number1 = int.Parse(userInput);

Console.WriteLine("Enter number 2");
userInput = Console.ReadLine();
userInput = Regex.Replace(userInput, "[^0-9]", "");
number2 = int.Parse(userInput);

while(number1 != number2)
{
    if (number1 > number2)
    {
        number1 = number1 - number2;
    }
    else
    {
        number2 = number2 - number1;
    }
}
Console.WriteLine("PGCD = " + number1);