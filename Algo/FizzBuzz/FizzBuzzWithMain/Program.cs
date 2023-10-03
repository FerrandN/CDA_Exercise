using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace FizzBuzzWithMain
{
    internal class Program
    {
        private const string ValueCanBeDividedBy3 = "fizz";
        private const string ValueCanBeDividedBy5 = "buzz";
        private const int min = 1;
        private const int max = 100;
        static void Main(string[] args)
        {
            

            for (int i = min; i < max; i++)
            {
                string answer = "";

                if(i % 3 == 0 && i % 5 == 0)
                {
                    answer += ValueCanBeDividedBy3;
                    answer += ValueCanBeDividedBy5;
                }
                else if(i % 3 == 0)
                {
                    answer += ValueCanBeDividedBy3;
                }
                else if(i % 5 == 0)
                {
                    answer += ValueCanBeDividedBy5;
                }
                else
                {
                    answer = i.ToString();
                }
                Console.WriteLine(answer + "\n");
            }
        }
    }
}