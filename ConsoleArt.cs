namespace CybersecurityBot
{
    public static class ConsoleArt
    {
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n");

            Console.WriteLine(@"   ____       _                     ____                      _     _            _   ");
            Console.WriteLine(@"  / ___| ___ | |__   ___  _ __     / ___|___  _ __ ___  _ __ | |__ (_)_ __   ___| |_ ");
            Console.WriteLine(@" | |    / _ \| '_ \ / _ \| '_ \   | |   / _ \| '_ ` _ \| '_ \| '_ \| | '_ \ / _ \ __|");
            Console.WriteLine(@" | |___| (_) | |_) | (_) | | | |  | |__| (_) | | | | | | |_) | | | | | | | |  __/ |_ ");
            Console.WriteLine(@"  \____|\___/|_.__/ \___/|_| |_|   \____\___/|_| |_| |_| .__/|_| |_|_|_| |_|\___|\__|");
            Console.WriteLine(@"                                                     |_|                             ");
            Console.WriteLine();

            // Stylized Shield with Lock
            Console.WriteLine(@"                _______");
            Console.WriteLine(@"             .-'       `-.");
            Console.WriteLine(@"            /             \ ");
            Console.WriteLine(@"           |  .--. .--.    |   Cyber Shield Activated");
            Console.WriteLine(@"           |  |__||__|    |");
            Console.WriteLine(@"           |  .--' '--.   |   Data Protection Engaged");
            Console.WriteLine(@"           |  |______|    |");
            Console.WriteLine(@"            \           /");
            Console.WriteLine(@"             `-._____.-'");
            Console.WriteLine(@"                 | |");
            Console.WriteLine(@"                 |_|");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"=============================================================");
            Console.WriteLine(@"            CYBERSECURITY AWARENESS BOT INITIATED            ");
            Console.WriteLine(@"=============================================================");
            Console.ResetColor();
        }
    }
}
