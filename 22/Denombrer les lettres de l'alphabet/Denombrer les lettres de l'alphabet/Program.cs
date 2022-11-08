string sentence = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis nat".ToLower();
int count;

for (char c = 'a' ; c <= 'z'; c++)
{
    count = 0;
    for(int i = 0; i < sentence.Length; i++)
    {
        if (sentence[i] == c)
        {
            count++;
        }
    }
    Console.WriteLine("there's " + count + " time the letter " + c + " in the sentence");
}