using System.Text.RegularExpressions;

string wordInput = "";
char[] wordToGuess;
char[] wordHidden;
char letterUserGuessed = ' ';
string userInput = "";
bool wordGuessed = false;

//Set Word to guess
Console.WriteLine("Enter a word");
while(wordInput.Length<5)
{
    wordInput = Console.ReadLine().ToLower();
    wordInput = Regex.Replace(wordInput, "[^a-z]", " ").Replace(" ", "");
}

//Set word to display
wordHidden = wordInput.ToCharArray();
wordToGuess = wordInput.ToCharArray();
for (int i = 1; i < wordHidden.Length - 1; i++)
{
    wordHidden[i] = '-';
}

//Player 2 guess word.
while (!wordGuessed)
{
    Console.WriteLine(wordHidden);

    bool wrongInput = true;
    while (wrongInput)
    {
        try
        {
        Console.WriteLine("What is your guess ?");
        userInput = Console.ReadLine();
        letterUserGuessed = userInput[0];
            wrongInput = false;
        }
        catch
        {
            Console.WriteLine("Wrong input");
        }
    }
    //Replace dash by letter in wordHidden
    //bool letterFound = compareUserInputTowordInput(letterUserGuessed, wordToGuess);

    if (compareUserInputTowordInput(letterUserGuessed,wordToGuess))
    {
        Console.WriteLine(letterUserGuessed + " Has been found");
        for(int i = 0; i < wordToGuess.Length; i++)
        {
            if (wordToGuess[i] == letterUserGuessed)
            {
                wordHidden[i] = letterUserGuessed;
            }
        }
    }

    //end game if guessed
    wordGuessed = !(compareUserInputTowordInput('-', wordHidden));
    
}
if (wordGuessed == true)
{
    Console.WriteLine(" GG !");
}

static bool compareUserInputTowordInput(char userGuess, char[] hiddenWord)
{
    int i = 1;
    bool isFinded = false;
    while (i < hiddenWord.Count()-1 && !isFinded)
    {
        if (hiddenWord[i] == userGuess)
            isFinded = true;
        i++;
    }
    if(!isFinded)
    {
        Console.WriteLine("Oh no :( , you guessed wrong ;_;");
    }
    return isFinded;
}

/*
static bool compareCharArray(char[] compare, char[] compareTo)
{
    if (compare.Length == compareTo.Length)
    {
        int i = 0;
        while (compare[i] == compareTo[i] && i < compare.Length-1) { i++;  }
        return compare[i] == compareTo[i];
    }
    return false;
}
*/