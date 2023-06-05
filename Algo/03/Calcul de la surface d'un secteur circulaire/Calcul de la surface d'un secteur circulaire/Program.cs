using System.Globalization;
using System.Text.RegularExpressions;

int R = 0;
int A = 0;
String userInput;
bool wrongInput = false;
double area = 0;

Console.WriteLine("Please enter the radius first. If you have a floating point number, use a coma. followed by the angle here is an example: 5,5 3,5");
do
{
    try
    {
        userInput = Console.ReadLine();
        /*
        int[] numbers = Regex.Matches(userInput, @"\d+").Select(m => int.Parse(m.Value)).ToArray();
        */
        MatchCollection mc = Regex.Matches(userInput, "[0-9]+[,]*[0-9]*");
        double[] numbers = mc.Select(m => double.Parse(m.Value)).ToArray();

        area = (Math.PI * Math.Pow(numbers[0], 2) * numbers[1])/360;
        wrongInput = true;
    }
    catch
    {
        wrongInput = false;
        Console.WriteLine("Wrong input, please retry");
    }
}while (!wrongInput);

Console.WriteLine("the area is equal to: " + area);

