namespace reflexor;

class Record
{
    public string Username { get; set; }
    public double Seconds { get; set; }

    public Record(string username, double seconds)
    {
        Username = username;
        Seconds = seconds;
    }
}
