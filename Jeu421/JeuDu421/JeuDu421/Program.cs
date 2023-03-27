using JeuDu421;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue au jeu du 421\nCombien de manches souhaitez vous jouer?");

        //instanciate user input string and Regex that we will use to check the string
        string userInput;
        Regex controlDiceToReroll = new Regex(@"[1-3]{1}");
        Regex controlRoundInput = new Regex(@"[0-9]{1,3}");
        MatchCollection numbers;
        byte nbManche = 0;
        do
        {
            userInput = Console.ReadLine();
            numbers = controlRoundInput.Matches(userInput);
            foreach (Match match in numbers)
            {
                byte b = Convert.ToByte(match.Value);
                nbManche = b;
            }
        } while (nbManche < 1);

        Partie partie = new Partie(nbManche);

        while(partie.AEncoreUneMancheAjouer() && partie.Score>0)
        {
            Console.WriteLine("Nombre de manches jouer: " + partie.NombreDeManchesEffectuees);
            Console.WriteLine("Nombre de manche à jouer: " + partie.NombreDeManchesSouhaitees);
            while (partie.AEncoreUnLance())
            {
                Console.WriteLine(partie.Score);
                Console.WriteLine(partie.MancheToString());
                if (partie.EstGagnee())
                {
                    Console.WriteLine("you won this round");
                    partie.AddThirtyToScore();
                    partie.SetNbLancerEffectue(partie.GetNbLancerMax());
                }
                else
                {
                    bool validAnswer = false;
                    MatchCollection matches = null;
                    do
                    {
                        Console.WriteLine("Quels dés souhaitez vous relancer?");
                        userInput = Console.ReadLine();
                        matches = controlDiceToReroll.Matches(userInput);
                        if (matches != null)
                        {
                            validAnswer = true;
                        }
                    } while (validAnswer == false);

                    for(int i = 0; i < matches.Count();i++)
                    {
                        byte value = Convert.ToByte(matches[i].Value);
                        value--;
                        partie.RelancerLesDesDeLaMancheCourantes(value);
                    }
                    partie.AddOneToNbLancerEffectue();
                }
                if(partie.GetNbLancerMax() == partie.GetMancheNbLancerEffectue() && !partie.EstGagnee())
                {
                    Console.WriteLine(partie.MancheToString());
                    Console.WriteLine("you lost this round");
                    partie.SubstractTenFromScore();
                }
            }
            partie.CreerUneNouvelleManche();
        }
        Console.WriteLine("Merci d'avoir joué !");

    }
}