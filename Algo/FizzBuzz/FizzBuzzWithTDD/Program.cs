namespace FizzBuzzWithTDD
{
    public class Program
    {
        private const int PremiereValeur = 3;
        private const int SecondeValeur = 5;
        public static string ReferenceEquals(int nombre)
        {
            if(nombre % PremiereValeur == 0 && nombre % SecondeValeur == 0)
            {
                return "fizzbuzz";
            }
            else if(nombre % SecondeValeur == 0)
            {
                return "buzz";
            }
            else if (nombre % PremiereValeur == 0)
            {
                return "fizz";
            }
            return nombre.ToString();
        }

        static void Main(string[] args)
        {
            
        }
    }
}