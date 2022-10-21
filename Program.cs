namespace reflexor
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Screen.WriteIntro();

            string option = Console.ReadLine() ?? "";

            // Start
            if (option == "1")
            {
                var username = Screen.GetUsername();
                if (username.Length == 0)
                {
                    Environment.Exit(0);
                }
                // Screen.CountDown(3);
                var session = new Session(username);
                session.Start();
                session.Save();
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
            }
        }
    }
}
