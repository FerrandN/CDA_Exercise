using System.Text.RegularExpressions;

bool validAnswer = false;
string userInput;
double[] userValues = {0};
string measureUnit = "";
double value;
do
{
    try
    {
        Console.WriteLine("Please enter a number between 0.01 and 1000000, and the measure unit you want it to be as mi or km");
        userInput = Console.ReadLine();
        userValues = Regex.Matches(userInput, @"\d+").Select(m => double.Parse(m.Value)).ToArray();
        MatchCollection matches = Regex.Matches(userInput, "[a-z]{2}");
        if (matches.Count > 0)
        {
            if (matches[0].Value == "mi")
            {
                measureUnit = "mi";
            }
        }
        if (userValues[0] < 0.01 || userValues[0] > 1000000)
        {
            Console.WriteLine("Wrong input");
        }
        else
        {
            validAnswer = true;
        }
    }
    catch
    {
        Console.WriteLine("Wrong input");
    }

}while(!validAnswer);


if (measureUnit.Equals("mi"))
{
    Console.WriteLine(userValues[0] + "m est équal a:");
    userValues[0] = userValues[0] * 1.609;
    Console.WriteLine(userValues[0] + " km");
}
else
{
    Console.WriteLine(userValues[0] + "km est équal a:");
    userValues[0] = userValues[0] / 1.609;
    Console.WriteLine(userValues[0] + " m");
}