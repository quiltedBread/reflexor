namespace reflexor
{
    internal class Program
    {
        static void Main(String[] args)
        {
            ConsoleWriter.WriteIntro();

            string option = Console.ReadLine() ?? "";
            // Start
            if (option == "1")
            {
                var username = ConsoleWriter.GetUsername();
                if (username.Length == 0)
                {
                    Environment.Exit(0);
                }
                // ConsoleWriter.CountDown(3);
                var session = new Session(username);
                session.Start();
                session.Save();
            }
            // Leaderboard
            if (option == "2")
            {
                Console.WriteLine("leaderboard");
            }
        }
    }
}
