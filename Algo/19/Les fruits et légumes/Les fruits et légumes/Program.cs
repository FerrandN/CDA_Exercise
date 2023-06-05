using System.Text.RegularExpressions;

string userInput;
Regex userWord = new Regex(@"[a-z]+");
Regex userPrice = new Regex(@"\d+");
bool userWantsToQuit = false;
List<string> vegetables = new List<string>();
List<double> price = new List<double>();
double lowestPrice = 0;
int index = 0;

do
{
    try
    {
        Console.WriteLine("Please, enter vegetable name followed by its price");
        userInput = Console.ReadLine();

        if (userInput == "go")
        {
            Console.WriteLine("cheapest vegetable is: " + vegetables[index] + " for " + lowestPrice + " euros");
            userWantsToQuit = true;
        }
        else
        {
            MatchCollection matchesWords = userWord.Matches(userInput);
            foreach (Match match in matchesWords)
            {
                vegetables.Add(match.Value);
            }
            MatchCollection matchesPrice = userPrice.Matches(userInput);
            foreach (Match match in matchesPrice)
            {
                price.Add(double.Parse(match.Value));
                if (lowestPrice == 0)
                {
                    lowestPrice = price.Last();
                }
                else
                {
                    if (price.Last() < lowestPrice)
                    {
                        lowestPrice = price.Last();
                        index = price.Count - 1;
                    }
                }
            }
        }
    }
    catch
    {
        Console.WriteLine("Wrong input");
    }
} while (!userWantsToQuit);