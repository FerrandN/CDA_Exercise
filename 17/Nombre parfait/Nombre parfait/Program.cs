int number = 0;
string userInput;
int count;
int max = 4;

while (max > 0)
{
	count = 0;
	number++;
	for (int i = 1; i < number; i++)
	{
		if (number % i == 0)
			count = count + i;
	}
	if (count == number)
	{
		Console.WriteLine(number+" is a perfect number");
		max--;
	}
}