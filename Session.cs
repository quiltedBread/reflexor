using System.Diagnostics;

namespace reflexor;

class Session
{
    public string Username { get; set; }
    public double Seconds { get; set; }
    string RandomChars { get; set; }
    int CharCount = 1;
    string PotentialChars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnPpQqRrSsTtUuVvWwXxYyZz123456789";

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
        Seconds = timer.Elapsed.TotalSeconds;
    }

    public void Save()
    {
        Console.Clear();
        RecordRepository.AddRecord(new Record(Username, Seconds));
        // display top 10 records
        var TopRecords = RecordRepository.GetRecords(10);
        for (int i = 0; i < TopRecords.Count(); i++)
        {
            Screen.WriteScore(i + 1, TopRecords[i].Username, TopRecords[i].Seconds);
        }
        // display rank if score not in top 10 records
        var rank = RecordRepository.GetRank(Seconds);
        if (rank > 10)
        {
            Console.WriteLine();
            Console.WriteLine("...");
            Screen.WriteScore(rank, Username, Seconds);
        }
    }
}
