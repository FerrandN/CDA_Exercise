int userNumber = 0;
int computerNumber;
Random random = new Random();
int userScore = 0;
int computerScore = 0;
bool userWantsToQuit = false;


do
{
    try
    {
        bool wrongAnswer = false;
        while (!wrongAnswer)
        {
            Console.WriteLine("Guess a number between 0 and 2, use a negative number to quit");
            userNumber = int.Parse(Console.ReadLine());
            if(userNumber > 2)
            {
                Console.WriteLine("wrong answer");
            }
            else
            {
                wrongAnswer = true;
            }
        }
        if (userNumber < 0)
        {
            Console.WriteLine("Have a nice day !");
            userWantsToQuit = true;
        }
        else
        {
            computerNumber = random.Next(0,3);
            int result = computerNumber - userNumber;
            if (result != 0)
            {
                if (result == 1 || result == -2)
                {
                    userScore++;
                    Console.WriteLine("Computer guess: " + computerNumber + " your guess: " + userNumber);
                    Console.WriteLine("User scored, well played !");
                }
                else
                {
                    computerScore++;
                    Console.WriteLine("Computer guess: " + computerNumber + " your guess: " + userNumber);
                    Console.WriteLine("Computer scored, oh no :( !");
                }
            }
            else
            {
                Console.WriteLine("Computer guess: " + computerNumber + " your guess: " + userNumber);
                Console.WriteLine("No one score");
            }

            Console.WriteLine("Your score: " + userScore + " computer score: " + computerScore);

        }
        
    }
    catch
    {
        Console.WriteLine("Wrong Input");
    }
} while (userScore < 10 ^ computerScore < 10 ^ !userWantsToQuit);

if (userScore>computerScore && !userWantsToQuit)
{
    Console.WriteLine("Well played !");
}
else if(userScore < computerScore && !
    
    userWantsToQuit)
{
    Console.WriteLine("Better luck next time !");
}
