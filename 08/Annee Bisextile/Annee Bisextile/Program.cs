int userYear = 0;
String userInput = "a";
bool validAnswer = false;
Console.WriteLine("Please, enter a year");
bool yearIsBissextile = false;
do
{
    try
    {
        userInput = Console.ReadLine();
        userYear = int.Parse(userInput);
        validAnswer = true;
    }
    catch
    {
        Console.WriteLine("Wrong input");
    }
} while (!validAnswer);

if (userYear % 4 == 0)
{
    if (userYear % 100 == 0)
    {
        yearIsBissextile = true;
        if (userYear % 400 == 0)
        {
            Console.WriteLine("Year " + userYear + " isn't bissextile");
            yearIsBissextile = false;
        }
    }
    if (yearIsBissextile == true)
    {
        Console.WriteLine("Year " + userYear + " is bissextile");
    }
}
else
{
    Console.WriteLine("Year " + userYear + " isn't bissextile");
}