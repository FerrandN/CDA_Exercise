using System.Text.RegularExpressions;

string userInput;
string measureUnit= "";
double valueToConvert = 0;
bool validAnswer = false;
Regex getValue = new Regex(@"\d+");
Regex getMeasureUnit = new Regex(@"[a-z]+");
Console.WriteLine("Please enter the value to convert followed by the value to convert it into as F for farhenheit or C for celsius");
do
{
    try
    {
        userInput = Console.ReadLine();
        
            MatchCollection matchesNumber = getValue.Matches(userInput);
            valueToConvert = double.Parse(matchesNumber[0].Value);
        if (valueToConvert < -459.67 || valueToConvert > 5000000)
        {
            Console.WriteLine("Value must be between -459.67 and 5 000 000");
        }
        else
        {
            MatchCollection matchesLetter = getMeasureUnit.Matches(userInput);
            measureUnit = matchesLetter[0].Value;
            measureUnit = measureUnit.ToLower();
            if (measureUnit.Equals("c") || measureUnit.Equals("f"))
            {
                validAnswer = true;
            }
            else
            {
                Console.WriteLine("Something went wrong, please retry");
            }
        }

    }
    catch
    {
        Console.WriteLine("Wrong input");
    }
} while (!validAnswer);



if (measureUnit.Equals("f"))
{
    Console.WriteLine(valueToConvert + "f is equal to");
    valueToConvert = (valueToConvert - 32)*(5.0/9.0);
    Console.WriteLine(valueToConvert + "c");
}
else
{
    Console.WriteLine(valueToConvert + "c is equal to");
    valueToConvert = (valueToConvert * (9 / 5)) +32 ;
    Console.WriteLine(valueToConvert + "f");
}