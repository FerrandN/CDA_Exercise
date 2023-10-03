using Singleton;

ClassSingleton premier = ClassSingleton.GetInstance();
ClassSingleton second = ClassSingleton.GetInstance();

if (premier == second)
{
    Console.WriteLine("GG");
}
else
{
    Console.WriteLine("Oh no !");
}