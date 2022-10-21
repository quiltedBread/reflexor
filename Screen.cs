namespace reflexor;

class Screen
{
    public static void WriteIntro()
    {
        Console.Clear();
        Console.WriteLine(
            "                     $$$$$$\\  $$\\                                         "
        );
        Console.WriteLine(
            "                    $$  __$$\\ $$ |                                        "
        );
        Console.WriteLine(
            " $$$$$$\\   $$$$$$\\  $$ /  \\__|$$ | $$$$$$\\  $$\\   $$\\  $$$$$$\\   $$$$$$\\  "
        );
        Console.WriteLine(
            "$$  __$$\\ $$  __$$\\ $$$$\\     $$ |$$  __$$\\ \\$$\\ $$  |$$  __$$\\ $$  __$$\\ "
        );
        Console.WriteLine(
            "$$ |  \\__|$$$$$$$$ |$$  _|    $$ |$$$$$$$$ | \\$$$$  / $$ /  $$ |$$ |  \\__|"
        );
        Console.WriteLine(
            "$$ |      $$   ____|$$ |      $$ |$$   ____| $$  $$<  $$ |  $$ |$$ |      "
        );
        Console.WriteLine(
            "$$ |      \\$$$$$$$\\ $$ |      $$ |\\$$$$$$$\\ $$  /\\$$\\ \\$$$$$$  |$$ |      "
        );
        Console.WriteLine(
            "\\__|       \\_______|\\__|      \\__| \\_______|\\__/  \\__| \\______/ \\__|      "
        );
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("[1] Start");
        Console.WriteLine("[2] Leaderboard");
        Console.WriteLine();
    }

    public static string GetUsername()
    {
        Console.Clear();
        Console.WriteLine("Enter a username:");
        string username = Console.ReadLine() ?? "";
        return username.Substring(0, Math.Min(username.Length, 8));
    }

    public static void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Clear();
            Console.Write($"Starting in {i}");
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("GO");
    }

    public static void WriteScore(int rank, string username, double seconds)
    {
        Console.Write($"{rank}.".PadRight(3));
        Console.Write($"{username}".PadRight(10));
        Console.Write($"{seconds}".PadRight(10));
        Console.WriteLine();
    }
}
