resoudreHanoi(0, 1, 2, 4);

void resoudreHanoi(int d, int i, int f, int n)
{
    if(n == 1)
    {
        Console.WriteLine(String.Format("{0} -> {1}", d, f));
    } else if (n == 2)
    {
        Console.WriteLine(String.Format("{0} -> {1}", d, i));
        Console.WriteLine(String.Format("{0} -> {1}", d, f));
        Console.WriteLine(String.Format("{0} -> {1}", i, f));
    }
    else
    {
        resoudreHanoi(d, f, i, n - 1);
        Console.WriteLine(String.Format("{0} -> {1}", d, f));
        resoudreHanoi(i, d, f, n - 1);
    }
}