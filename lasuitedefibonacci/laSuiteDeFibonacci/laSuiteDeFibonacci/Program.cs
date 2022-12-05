int position;
int n = 0;
string resultat;
float nbPrecedent;
float nbCourant;
float nbSuivant;
bool quit = false;
string userInput;

Console.WriteLine("Bonjour, bienvenue dans le programme de la suite de fibonacci");
do
{

    bool validInput = false;
    do
    {
        Console.WriteLine("Veuillez entrer un nombre afin de savoir combien de nombre de la suite vous souhaitez obtenir");
        try
        {
            n = int.Parse(Console.ReadLine());
            validInput = true;
        }
         catch
        {
            Console.WriteLine("Entrée invalide");
        }
    } while (!validInput);

    position = 2;
    resultat = "0\n1";
    nbPrecedent = 0;
    nbCourant = 1;

    if ( n> 2)
    {
        while(position<n)
       {
            nbSuivant = nbPrecedent + nbCourant;
            resultat = resultat + "\n" + nbSuivant;
            nbPrecedent = nbCourant;
            nbCourant = nbSuivant;
            position = position+1;
        }
    }
    else
    {
        n = 2;
    }

    Console.WriteLine("Les " + n + " premiers nombres de la suite de Fibonacci sont \n" + resultat);

    Console.WriteLine("Souhaitez fermez le programme ? Si oui, merci de rentrer y. Sinon appuyer sur n'importe quel touche puis la touche <Entrée> pour redemarer le programme.");
    userInput = Console.ReadLine().ToLower();
    if (userInput == "y")
    {
        quit = true;
    }
}while (!quit);