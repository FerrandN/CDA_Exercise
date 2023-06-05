using System;
using System.Text.Json;
using Yaourts;
using static System.Net.Mime.MediaTypeNames;
//string[] datas = generateData(generateRandomNumber(500, 5000));
HttpClient client = new HttpClient();
var content = await client.GetStringAsync("https://api.devoldere.net/polls/yoghurts/");
string text = Convert.ToString(content);
Yaourt? datas = JsonSerializer.Deserialize<Yaourt>(text);
Console.WriteLine(App.run(datas.results));



/* This method generate <number> of datas
 */
static string[] generateData(int number)
{
    string[] colors = { "rouge", "jaune", "bleu" };
    string[] returnData = new string[number];
    for(int i = 0; i < number; i++)
    {
        returnData[i] = colors[generateRandomNumber(0, colors.Length-1)];
    }
    return returnData;
}

/* this method generate a random number between 
 * min and max including in the interval, french accent is so saxy yayayaya! 
 */
static int generateRandomNumber(int min, int max)
{
    Random rnd = new Random();
    return rnd.Next(min, max + 1);
}

static Yaourt? loadFromFile(string filepath)
{
    string text = File.ReadAllText(filepath);
    Yaourt? rt = JsonSerializer.Deserialize<Yaourt>(text);
    return rt;

}
