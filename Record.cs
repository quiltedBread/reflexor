namespace reflexor;

class Record
{
    public string Username { get; set; }
    public decimal Seconds { get; set; }

    public Record(string username, decimal seconds)
    {
        Username = username;
        Seconds = seconds;
    }
}
