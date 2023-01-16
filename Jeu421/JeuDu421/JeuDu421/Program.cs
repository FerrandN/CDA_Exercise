using JeuDu421;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue au jeu du 421\nCombien de manches souhaitez vous jouer?");

        string userInput = Console.ReadLine();
        Regex controlDiceToReroll = new Regex(@"[1-3]{1}");
        Regex controlRoundInput = new Regex(@"[0-9]");

        MatchCollection numbers = controlRoundInput.Matches(userInput);
        byte nbManche = 0;
        foreach (Match match in numbers)
        {
            byte b = Convert.ToByte(match.Value);
            nbManche = b;
        }

        Partie partie = new Partie(nbManche);

        while(partie.AEncoreUneMancheAjouer() && partie.getScore()>0)
        {
            while (partie.mancheCourante.AEncoreUnLance())
            {
                Console.WriteLine(partie.getScore());
                Console.WriteLine(partie.mancheCourante.ToString());
                if (partie.mancheCourante.EstGagnee())
                {
                    Console.WriteLine("you won this round");
                    partie.setScore(30);
                    partie.mancheCourante.setNbLancerEffectue(partie.mancheCourante.nbLancerMax);
                }
                else
                {
                    Console.WriteLine("Quels dés souhaitez vous relancer?");
                    userInput = Console.ReadLine();
                    MatchCollection matches = controlDiceToReroll.Matches(userInput);

                    foreach (Match match in matches)
                    {
                        byte b = Convert.ToByte(match.Value);
                        b--;
                        partie.mancheCourante.Relance(b);
                    }
                    partie.mancheCourante.setNbLancerEffectue(1);
                }
                if(partie.mancheCourante.nbLancerMax == partie.mancheCourante.getNbLancerEffectue() && !partie.mancheCourante.EstGagnee())
                {
                    Console.WriteLine("you lost this round");
                    partie.setScore(-10);
                }
            }
            partie.CreerUneNouvelleManche();
        }
        Console.WriteLine("Merci d'avoir joué !");

    }
}