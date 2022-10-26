using System.Text.RegularExpressions;

string userInput;
Regex userWord = new Regex(@"\w+");
bool userWantsToQuit = false;
List<string> vegetables = new List<string> ();

do
{
    try
    {
        Console.WriteLine("Please, enter vegetable name followed by its price");
        userInput = Console.ReadLine();

        if (userInput == "go")
        {
            vegetables.ForEach(delegate (string vegetable) { Console.WriteLine(vegetable); });
            userWantsToQuit = true;
        }
        else
        {
            MatchCollection matchesWords = userWord.Matches(userInput);
            foreach (Match match in matchesWords)
            {
                vegetables.Add(match.Value);
            }
        }
    }
    catch
    {
        Console.WriteLine("Wrong input");
    }
}while(!userWantsToQuit);