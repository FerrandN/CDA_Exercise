internal class Program
{
    private static void Main(string[] args)
    {
        int number1;
        int number2;
        float average;
        String input;
        Boolean wrongInput;

        Console.WriteLine("Veuillez rentrer un nombre");
        input = Console.ReadLine();
        number1 = Int32.Parse(input);
   

        Console.WriteLine("Veuillez rentrer un nombre");
        input = Console.ReadLine();
        number2 = Int32.Parse(input);
  

        average = (number1 + number2) / 2;

        Console.WriteLine("La moyenne est égale à " + average);
    }
}