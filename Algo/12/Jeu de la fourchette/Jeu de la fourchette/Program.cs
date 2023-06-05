int numberToFind = 0;
int max = 101;
int min = 0;
String userInput;
int userNumber = 0;
bool validAnswer = false;
bool gameEnd = false;
int tryCount = 0;

//generate random number and ask user to try to guess
do
{
    Random randomGeneratedNumber = new Random();
    numberToFind = randomGeneratedNumber.Next(min, max);
    validAnswer = false;
    Console.WriteLine("Welcome, the goal is to find the number between 0 and 100 included");
    Console.WriteLine("Please enter a number");

    do
    {
        try
        {
            userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            if (userNumber >= min && userNumber < max)
            {
                validAnswer = true;
                tryCount++;
            }
            else
            {
                Console.WriteLine("Please, use a number between 0 and 100 included");
            }
        }
        catch
        {
            Console.WriteLine("Wrong answer, please retry");
        }
    } while (validAnswer == false);

    //compare user input to number to guess
    validAnswer = false;
    if (userNumber == numberToFind)
    {
        Console.WriteLine("Welldone ! You guessed " + numberToFind + " with " + tryCount + " try.");
        Console.WriteLine("Do you want to play again? if yes, press y. if no, press n");
        do
        {
            try
            {
                userInput = Console.ReadLine();
                if (userInput == "y")
                {
                    Console.WriteLine("Good Luck !");
                    numberToFind = 0;
                    max = 101;
                    min = 0;
                    userNumber = 0;
                    validAnswer = true;
                    tryCount = 0;
                }
                else if (userInput == "n")
                {
                    Console.WriteLine("Have a nice day, thanks for playing");
                    gameEnd = true;
                    validAnswer = true;
                }
                else
                {
                    Console.WriteLine("Incorrect answer, please retry");
                }
            }
            catch
            {
                Console.WriteLine("Please enter y or n");
            }
        } while (validAnswer == false);
    }
    else if (userNumber > numberToFind)
    {
        max = userNumber;
        Console.WriteLine(userNumber + " is to high !");
        Console.WriteLine("you should guess between " + min + " and" + " " + max);
    }
    else
    {
        min = userNumber;
        Console.WriteLine(userNumber + " is to low !");
        Console.WriteLine("you should guess between " + min + " and" + " " + max);
    }
} while (gameEnd == false);