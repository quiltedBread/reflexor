using System.Diagnostics;

namespace reflexor;

class Session
{
    public string Username { get; set; }
    public decimal Seconds { get; set; }
    string RandomChars { get; set; }
    int CharCount = 1;
    string PotentialChars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz123456789";

    public Session(string username)
    {
        Username = username;
        RandomChars = GetRandomChars();
    }

    string GetRandomChars()
    {
        string chars = "";
        Random rnd = new Random();
        for (var i = 0; i <= CharCount; i++)
        {
            chars += PotentialChars[rnd.Next(0, PotentialChars.Length)];
        }
        return chars;
    }

    public void Start()
    {
        var timer = new Stopwatch();
        timer.Start();
        foreach (char c in RandomChars)
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
        RecordRepository.AddRecord(new Record(Username, Seconds));
        var records = RecordRepository.Records;
        foreach (var r in records)
        {
            Console.WriteLine($"{r.Username}, {r.Seconds}");
        }
    }
}
