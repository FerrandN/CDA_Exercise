using System.Text.RegularExpressions;

string[] names = { "agathe", "berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie"};
string userInput;
bool lookForName = true;
int[] checkAtMiddle = { 0, names.Length };
bool found = false;
Console.WriteLine("Please enter a name");
userInput = Console.ReadLine().ToLower();
userInput = Regex.Replace(userInput, "[^a-zÀ-ž]", "");

while (lookForName && !found)
{

    int delta = (checkAtMiddle[1] - checkAtMiddle[0]) / 2;
    int index = checkAtMiddle[0] + delta;
    if (userInput.CompareTo(names[index]) == 0)
    {
        Console.WriteLine(userInput + " was found at index " + (index+1));
        lookForName = false;
        found = true;
    }
    else if (userInput.CompareTo(names[index]) >= 0)
    {
        checkAtMiddle[0] = index;
    }
    else
    {
        checkAtMiddle[1] = index;
    }
    if(delta == 0)
    {
        lookForName = false;
    }   
}
if (!found)
    Console.WriteLine("0");