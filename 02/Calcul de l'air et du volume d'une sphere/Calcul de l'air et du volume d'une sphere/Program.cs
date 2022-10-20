int R = 0;
bool ValidInput = false;

Console.WriteLine("Enter R value in cm");
string userInput = Console.ReadLine();
do
{
    try
    {
        R = int.Parse(userInput);
        ValidInput = true;
    }
    catch
    {
        Console.WriteLine("Invalid Input");
        Console.WriteLine("Enter R value");
        userInput = Console.ReadLine();
    }
} while (!ValidInput);

double area = (4 * Math.PI * Math.Pow(R, 2));
double volume = ((4 / 3) * Math.PI * Math.Pow(R, 3));

Console.WriteLine("Area value is equal to " + area.ToString("#.##") + "cm²");
Console.WriteLine("Volume value is equal to " + volume.ToString("#.##") + "cm³");

