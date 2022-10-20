int money = 1500;
double interest = 0.10;
int years = 5;
double sum = 0;

sum = money * (1 + years * interest);

Console.WriteLine("La somme des interêt simple est de: " + sum);

sum = money*(Math.Pow((1 + interest), years));

Console.WriteLine("La somme des interêt composé est de: " + sum);