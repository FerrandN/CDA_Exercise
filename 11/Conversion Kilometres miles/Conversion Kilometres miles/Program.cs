bool userQuit = false;
double kilometer = 0;
double miles = 0;
String userInput;
bool validAnswer = true;

while (!userQuit)
{
    Console.WriteLine("Please enter a kilometer valued between 0.01 - 1 000 000, press q to quit");
    do
    {
        try
        {
            userInput = Console.ReadLine();

            if (userInput == "q")
            {
                Console.WriteLine("Have a good day");
                userQuit = true;
            }
            else
            {
                kilometer = double.Parse(userInput);

                if (kilometer < 0.01 | kilometer > 1000000)
                {
                    Console.WriteLine("Please enter a kilometer valued between 0.01 - 1 000 000");
                    validAnswer = false;
                }
                else
                {
                    miles = kilometer / 1.609;
                    Console.WriteLine(kilometer + " km = " + miles + " m");
                    validAnswer = true;
                }
            }
        }
        catch
        {
            Console.WriteLine("Wrong input");
            validAnswer = false;
        }
    } while (!validAnswer && !userQuit);
}
