namespace reflexor
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Screen.WriteIntro();
            string option = Screen.GetOption();

            bool isPlaying = true;

            while (isPlaying)
            {
                // Start
                if (option == "1")
                {
                    bool awaitUsername = true;
                    while (awaitUsername)
                    {
                        var username = Screen.GetUsername();
                        if (username.Length > 0)
                        {
                            awaitUsername = false;
                            // Screen.CountDown(3);
                            var session = new Session(username);
                            session.Start();
                            session.Save();
                        }
                    }
                    option = Screen.PromptPlayAgain() ? "1" : "3";
                }
                // Leaderboard
                if (option == "2")
                {
                    Console.Clear();
                    var leaders = RecordRepository.GetRecords(21);
                    for (int i = 0; i < leaders.Count(); i++)
                    {
                        Screen.WriteScore(i + 1, leaders[i].Username, leaders[i].Seconds);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return to menu");
                    Console.ReadKey();
                    Console.Clear();
                    Screen.WriteIntro();
                    option = Screen.GetOption();
                }
                if (option == "3")
                {
                    isPlaying = false;
                    Console.Clear();
                    Console.WriteLine("Thanks for Playing");
                }
            }
        }
    }
}
