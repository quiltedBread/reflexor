using System.Diagnostics;
using System.Globalization;

using CsvHelper;

namespace reflexor;

class Session
{
    public string Username { get; set; }
    public decimal Seconds { get; set; }
    string Chars { get; set; }
    int CharCount = 10;
    string PotentialChars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz123456789";

    public Session(string username)
    {
        Username = username;
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

    public void Save()
    {
        using (var reader = new StreamReader("sessions.csv"))
        {
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<Session>();
        }
        Console.WriteLine("saved");
    }
}
