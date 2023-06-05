bool weatherSunny = true;
bool bicycleBroken = true;
bool fixTakesLongTime = true;
bool bookFound = true ;
bool bookAvailable = true ;

Console.WriteLine("Hello, here is a little story. We're are going to ask Yes or No question. Depending on your answer, the story will change. Have fun ! Answer with 'y' or 'n' ");
Console.WriteLine("Bob wants to do a bicycle ride. He checks the weather. Is the weather sunny ?");

weatherSunny = askUser(weatherSunny);

if(weatherSunny)
{
    Console.WriteLine("The weather is nice ! Bob didn't use his bicycle since a couple months. Is the bicycle damaged?");
    bicycleBroken = askUser(bicycleBroken);
    if(bicycleBroken)
    {
        Console.WriteLine("Bob will take his bicycle to the mechanic. If the repair takes too long, he won't be able to use his bicycle for the ride. Is the repair taking too long?");
        fixTakesLongTime = askUser(fixTakesLongTime);
        if(fixTakesLongTime)
        {
            Console.WriteLine("Since the weather is nice, Bob decide to go for a walk near the pound and harvest some flowers.");
        }
        else
        {
            Console.WriteLine("The mechanic fixed the bicycle in time, Bob did his ride on his bicycle. He can't be happier :D");
        }
    }
    else
    {
        Console.WriteLine("Bob did his ride on his bicycle. He can't be happier :D");
    }
}
else
{
    Console.WriteLine("Since the weather is terrible, Bob decide to read a book. He wants to reread 'Games of thrones'. Is the book in his library ?");
    bookFound = askUser(bookFound);
    if(bookFound)
    {
        Console.WriteLine("Bob read his book near his chemney smoke. He his having a good time :D");
    }
    else
    {
        Console.WriteLine("Oh no :( , Bob didn't find the book, but he won't let his bad luck takes the lead ! Bob is now going to the municipal library to get the book");
        Console.WriteLine("Does Bob find a copy of 'Game Of thrones' there?");
        bookAvailable = askUser(bookAvailable);
        if(bookAvailable)
        {
            Console.WriteLine("Bob leads home to read his book near his chemney smoke. He his having a good time :D");
        }
        else
        {
            Console.WriteLine("Bob is very disapointed :(, he decides this series of event was too much. He just pick any polar he finds at the municipal library and heads home to read near his chemney smoke");
        }
    }
}

static bool askUser(bool bToCheck)
{
    char userAnswer;
    string userInput;
    bool validAnswer = false;
    do
    {
        userInput = Console.ReadLine();
        userAnswer = char.Parse(userInput);
        userAnswer = char.ToLower(userAnswer);
        if (userAnswer == 'y' | userAnswer == 'n')
        {
            bToCheck = checkAnswer(userAnswer);
            validAnswer = true;
        }
        else
        {
            Console.WriteLine("Wrong answer");
        }
    } while (!validAnswer);
    return bToCheck;
}
static bool checkAnswer(char input)
{
    if (input == 'y') return true; 
    else return false; 
}