int[] t = new int[10];
Random rand = new Random();

for (int i = 0; i < t.Length; i++)
{
    t[i] = rand.Next(0,10);
}

for (int i = 0; i < t.Length; i++)
{
    for (int j = 0; j < t.Length; j++)
    {
        if (t[i] < t[j])
        {
            int temp = t[i];
            t[i] = t[j];
            t[j] = temp;
        }
    }
}

for (int i = 0; i < t.Length; i++)
{
    Console.WriteLine(t[i]);
}