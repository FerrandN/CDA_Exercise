string words = ".";
char userInput = 'a';
int count = 0;

/*
string saisie = Console.ReadLine();
char monChar;
if (saisie.Length == 1)
    monChar = saisie[0];
else
    // ERREUR
*/

try
{
    Console.WriteLine("Enter a sentence");
    words = Console.ReadLine();
    words = words.ToLower();
    Console.WriteLine("Enter a letter");
    userInput = (char)Console.Read();
    userInput = Char.ToLower(userInput);
}
catch
{
    Console.WriteLine("Wrong input");
}

for (int i = 0; i < words.Length; i++)
{
    if(words[i] == userInput)
    {
        count++;
    }
}
if(words.Length > 0)
{
    if (count == 0)
    {
        Console.WriteLine("Letter not found");
    }
    else
    {
        Console.WriteLine(userInput + " was found " + count + " time, in the sentence");
    }
}
else
{
    Console.WriteLine("Sentence empty");
}