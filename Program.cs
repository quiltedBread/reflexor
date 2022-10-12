using System.Threading;

namespace reflexor{
    internal class Program{
        // string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
        // int NumCharacters = 10;
        static void Main(String[] args){
            Console.WriteLine("                     $$$$$$\\  $$\\                                         ");
            Console.WriteLine("                    $$  __$$\\ $$ |                                        ");
            Console.WriteLine(" $$$$$$\\   $$$$$$\\  $$ /  \\__|$$ | $$$$$$\\  $$\\   $$\\  $$$$$$\\   $$$$$$\\  ");
            Console.WriteLine("$$  __$$\\ $$  __$$\\ $$$$\\     $$ |$$  __$$\\ \\$$\\ $$  |$$  __$$\\ $$  __$$\\ ");
            Console.WriteLine("$$ |  \\__|$$$$$$$$ |$$  _|    $$ |$$$$$$$$ | \\$$$$  / $$ /  $$ |$$ |  \\__|");
            Console.WriteLine("$$ |      $$   ____|$$ |      $$ |$$   ____| $$  $$<  $$ |  $$ |$$ |      ");
            Console.WriteLine("$$ |      \\$$$$$$$\\ $$ |      $$ |\\$$$$$$$\\ $$  /\\$$\\ \\$$$$$$  |$$ |      ");
            Console.WriteLine("\\__|       \\_______|\\__|      \\__| \\_______|\\__/  \\__| \\______/ \\__|      ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[1] Start");
            Console.WriteLine("[2] Leaderboard");
            Console.WriteLine();

            string choice = Console.ReadLine() ?? "";
            if(choice == "1"){
                Console.Clear();
                Console.WriteLine("Enter a username:");
                string username = Console.ReadLine() ?? "";
                if(username.Length == 0) {
                    Environment.Exit(0);
                }
                Console.Clear();
                Console.Write("Starting in 3");
                Thread.Sleep(1000);
                Console.Clear();
                Console.Write("Starting in 2");
                Thread.Sleep(1000);
                Console.Clear();
                Console.Write("Startign in 1");
                Thread.Sleep(1000);
                Console.WriteLine("GO");
                Console.Clear();

                int unicode = 65;
                Console.WriteLine(Convert.ToChar(unicode));
                while (Console.ReadKey().Key != ConsoleKey.A) {}
            }
        }
    }
}

