using System.Text.RegularExpressions;

string userInput;
List<int> age = new List<int>();
Regex rx = new Regex(@"\d+");
bool atLeastOneAdult = false;
bool atLeastOneChild = false;
List<int> adult = new List<int>();
List<int> child = new List<int>();
bool twentyEntryFound = false;
try
{
    MatchCollection matches;

    do
    {
        Console.WriteLine("Veuillez entrée 20 ages");
        userInput = Console.ReadLine();
        matches = rx.Matches(userInput);
        if (age.Count + matches.Count <= 20)
        {
            foreach (Match match in matches)
            {
                age.Add(int.Parse(match.Value));
            }
            
            twentyEntryFound = age.Count == 20;
        }
    } while (!twentyEntryFound);
}
catch
{
    Console.WriteLine("Error");
}

for(int i = 0; i < age.Count; i++)
{
    if(age[i] >= 20)
    {
        atLeastOneAdult = true;
        adult.Add(age[i]);
    }
    else if(age[i] < 20)
    {
        atLeastOneChild = true;
        child.Add(age[i]);
    }
}

if(!atLeastOneAdult)
{
    Console.WriteLine("TOUTES LES PERSONNES ONT MOINS DE 20 ANS");
}
else if(!atLeastOneChild)
{ 
    Console.WriteLine("TOUTES LES PERSONNES ONT PLUS DE 20 ANS"); 
}
else
{
    Console.WriteLine("Il y a " + adult.Count + " adults");
    Console.WriteLine("Il y a " + child.Count + " enfants");
}