using System.Diagnostics;

namespace reflexor;

class Session
{
    int CharCount = 10;
    string PotentialChars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz123456789";

    public string Chars { get; set; }

    public Session()
    {
        Chars = GetChars();
    }

    string GetChars()
    {
        string chars = "";
        Random rnd = new Random();
        for (var i = 0; i <= CharCount; i++)
        {
            chars += PotentialChars[rnd.Next(0, PotentialChars.Length + 1)];
        }
        return chars;
    }

    public void Start()
    {
        var timer = new Stopwatch();
        timer.Start();
        foreach (char c in Chars)
        {
            Console.Clear();
            Console.WriteLine(c);
            while (Console.ReadKey().KeyChar != c) { }
        }
        timer.Stop();
        Console.WriteLine(timer.Elapsed);
    }
}
