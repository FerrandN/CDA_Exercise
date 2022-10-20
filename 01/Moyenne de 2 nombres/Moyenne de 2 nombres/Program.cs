internal class Program
{
    private static void Main(string[] args)
    {
        int number1 = 0;
        int number2 = 0;
        double average;
        String input;
        Boolean wrongInput;

        Console.WriteLine("Veuillez rentrer un nombre");
        bool saisieValide = false;
        do
        {
            input = Console.ReadLine();
            try
            {
                number1 = int.Parse(input);
                saisieValide = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine("invalid input");
                /*input = Console.ReadLine();
                number1 = Int32.Parse(input);*/
            }
        } while (!saisieValide);

        Console.WriteLine("Veuillez rentrer un nombre");
        saisieValide = false;
        do
        {
            input = Console.ReadLine();
            try
            {
                number1 = int.Parse(input);
                saisieValide = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine("invalid input");
                /*input = Console.ReadLine();
                number1 = Int32.Parse(input);*/
            }
        } while (!saisieValide);


        average = (number1 + number2) / 2;

        Console.WriteLine("La moyenne est égale à " + average);
    }
}
