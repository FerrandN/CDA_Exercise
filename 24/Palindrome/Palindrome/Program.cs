using System.Globalization;

string palindrome = Console.ReadLine();
string sFormat = "";

sFormat = palindrome.ToLower().Replace(" ", "");
bool isPalindrome = true;

if (sFormat != "")
{
    for (int i = 0; i < sFormat.Length / 2; i++)
    {
        int j = sFormat.Length - i - 1;
        if (sFormat[i] != sFormat[j])
        {
            isPalindrome = false;
        }
    }
}
if(sFormat == "")
{
    Console.WriteLine("LA CHAINE EST VIDE");
}
else if(isPalindrome)
{
    Console.WriteLine(palindrome + " is a palindrome");
}
else
{
    Console.WriteLine(palindrome + " isn't a palindrome");
}
