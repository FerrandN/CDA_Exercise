using Bouteille2;
using System.Text;
using System;

string userInput;
float userLiter;
bool wantsToPlayBouteille = true;
Bouteille bottle = new Bouteille();

Console.WriteLine("Bonjour, voici une bouteille, bonne journée...");
Console.ReadLine();
Console.WriteLine("Je plaisante, que souhaitez vous faire avec cette bouteille ?");
do
{
    Console.WriteLine("Voici une liste de commande: ");
    Console.WriteLine("ouvrir - fermer - remplir un peu - remplir - vider un peu - vider - afficher l'état - quitter");
    userInput = Console.ReadLine();
    if (userInput == "ouvrir")
    {
        bottle.ouvrir();
    }
    else if (userInput == "fermer")
    {
        bottle.close();
    }
    else if (userInput == "remplir un peu")
    {
        Console.WriteLine("Merci d'entrer la valeur en litre que vous souhaiter ajouter à la bouteille");
        userLiter = float.Parse(Console.ReadLine());
        bottle.fill(userLiter);
    }
    else if (userInput == "remplir")
    {
        bottle.fillFull();
    }
    else if (userInput == "vider un peu")
    {
        Console.WriteLine("Merci d'entrer la valeur en litre que vous souhaiter enlever de la bouteille");
        userLiter = float.Parse(Console.ReadLine());
        bottle.empty(userLiter);
    }
    else if (userInput == "vider")
    {
        bottle.fullEmpty();
    }
    else if (userInput == "afficher l'état")
    {
        bottle.afficherStats();
    }
    else if (userInput == "quitter")
    {
        Console.WriteLine("Good bye");
        wantsToPlayBouteille = false;
    }
    else
    {
        Console.WriteLine("Commande Inconue");
    }
}while (wantsToPlayBouteille);