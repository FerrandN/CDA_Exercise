Console.WriteLine("Enter your age please.");
String userInput;
int a = 0;
bool validAnswer = false;

do
{
    try
    {
        userInput = Console.ReadLine();
        a = int.Parse(userInput);
        validAnswer = true;
    }
    catch
    {
        Console.WriteLine("Wrong input");
    }
} while (!validAnswer);

if (a >= 18)
{
    Console.WriteLine("Vous êtes majeur");
}
else if (a >= 0 && a < 18)
{
    Console.WriteLine("Vous êtes mineurs");
}
else
{ 
    Console.WriteLine("Vous n'êtes pas encore né");
}