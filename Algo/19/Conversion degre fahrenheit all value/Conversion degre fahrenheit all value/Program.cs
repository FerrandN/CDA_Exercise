string userInput;
char userMeasureUnit;
int min;
int max;
double results;
bool validAnswer = false;
do
{
    try
    {
        Console.WriteLine("Please enter a measure unit as C for Celsius or F for Farhenheit or press 'quit' to quit");
        userInput = Console.ReadLine();
        if (userInput == "quit")
        {
            Console.WriteLine("Have a nice day !");
            validAnswer = true;
        }
        else
        {
            userInput.ToLower();
            userMeasureUnit = userInput[0];

            Console.WriteLine("Please enter the min value you want");
            userInput = Console.ReadLine();
            min = int.Parse(userInput);

            Console.WriteLine("Please enter the max value you want");
            userInput = Console.ReadLine();
            max = int.Parse(userInput);

            if (userMeasureUnit == 'f')
                for (int i = min; i <= max; i++)
                {
                    results = (i - 32) * (5.0 / 9.0);
                    Console.WriteLine(results + "f");
                }
            else
            {
                for (int i = min; i <= max; i++)
                {
                    results = (i * (9.0 / 5.0)) + 32;
                    Console.WriteLine(results + "c");
                }
            }
            validAnswer = true;
        }
    }
    catch
    {
        Console.WriteLine("Wrong input");
    }
} while (!validAnswer);