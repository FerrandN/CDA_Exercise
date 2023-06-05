double a = 42.89151911;
double b = 1.56789;
double c = 63.54156;

if (a>b)
{
    double temp = a;
    a = numberParse(a, b);
    b = temp;
}

if (b > c)
{
    double temp;
    if (a > c)
    {
        temp = a;
        a = numberParse(a, c);
        c = temp;
    }
    temp = b;
    b = numberParse(b, c);
    c = temp;
}

double numberParse(double a, double b)
{
    if (a > b)
    {
        double c = 0;
        c = b;
        b = a;
        a = c;
    }
    return a;
}

Console.WriteLine(a + " " + b + " " + c);