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
            Console.WriteLine("[1] to start");
            Console.WriteLine("[2] to view leaderboard");
            Console.WriteLine();

            string choice = Console.ReadLine() ?? "";

            if(choice == "1"){
                Console.WriteLine("Enter a username:");
                string username = Console.ReadLine() ?? "";
                if(username.Length == 0) {
                    Environment.Exit(0);
                }
                Console.Write("Starting in 3");
                Thread.Sleep(1000);
                Console.Write("\b");
                Console.Write("2");
                Thread.Sleep(1000);
                Console.Write("\b");
                Console.Write("1");
                Thread.Sleep(1000);
                Console.WriteLine("GO");
                // public static void ClearCurrentConsoleLine()
                // {
                //     int currentLineCursor = Console.CursorTop;
                //     Console.SetCursorPosition(0, Console.CursorTop);
                //     Console.Write(new string(' ', Console.WindowWidth)); 
                //     Console.SetCursorPosition(0, currentLineCursor);
                // }

                
                

            }
        }
    }
}

