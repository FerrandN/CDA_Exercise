int[] nombre = new int[5] {1, 2, 3, 5, 7};
string userInput;
int numberToGuess = 0;
bool numberFound = false;
bool validAnswer = false;

Console.WriteLine("Please, enter a number");

do
{
    userInput = Console.ReadLine();
    try
    {
        numberToGuess = int.Parse(userInput);
        validAnswer = true;
    }
    catch
    {
        Console.WriteLine("Invalid answer");
    }
}
while (!validAnswer);
for (int i = 0; i < nombre.Length; i++)
{
    if (numberToGuess == nombre[i])
    {
        numberFound = true;
    }
}

if (!numberFound)
{
    Console.WriteLine("404 Not found");
}
else
{
    Console.WriteLine(numberToGuess + " is a valid answer");
}