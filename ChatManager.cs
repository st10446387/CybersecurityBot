using System;
using System.Threading;

namespace CybersecurityBot
{
    public class ChatManager
    {
        private const int TypingDelay = 30; 
        public string UserName { get; private set; }

        public void StartChat()
        {
            GetUserName();
            ShowWelcome();

            while (true)
            {
                ShowPrompt(); 
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a valid query.");
                    continue;
                }

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                var response = GetResponse(input);
                DisplayResponse(response);
            }

            ShowGoodbye();
        }

        private void ShowPrompt()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"{UserName}: ");
            Console.ResetColor();
        }

        private void GetUserName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeWrite("Before we begin, please enter your name: ");
            Console.ResetColor();

            while (true)
            {
                UserName = Console.ReadLine()?.Trim();
                if (!string.IsNullOrEmpty(UserName)) break;
                PrintError("Invalid input. Please enter your name: ");
            }
        }

        private void ShowWelcome()
        {
            Console.Clear();
            ConsoleArt.DisplayLogo();

            Console.ForegroundColor = ConsoleColor.Green;
            TypeWrite($"\nWelcome, {UserName}!\n");
            Console.ResetColor();

            TypeWrite("I'm your Cybersecurity Awareness Assistant.\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n╔════════════════════════════════════╗");
            Console.WriteLine(  "║         Available Commands         ║");
            Console.WriteLine(  "╠════════════════════════════════════╣");
            Console.WriteLine(  "║ 1. Password security               ║");
            Console.WriteLine(  "║ 2. Phishing protection             ║");
            Console.WriteLine(  "║ 3. Safe browsing                   ║");
            Console.WriteLine(  "║ help - Show this menu              ║");
            Console.WriteLine(  "║ exit - Close the application       ║");
            Console.WriteLine(  "╚════════════════════════════════════╝\n");
            Console.ResetColor();
        }

        private string GetResponse(string input)
        {
            input = input.ToLower();

            return input switch
            {
                _ when input == "1" || input.Contains("pass") => FormatResponse(
                    "PASSWORD SECURITY GUIDELINES",
                    "• Minimum 12 characters\n" +
                    "• Combine uppercase, lowercase, numbers\n" +
                    "• Use a password manager (e.g., Bitwarden)\n" +
                    "• Enable two-factor authentication"),

                _ when input == "2" || input.Contains("phish") || input.Contains("scam") => FormatResponse(
                    "PHISHING PROTECTION TIPS",
                    "• Verify sender email addresses\n" +
                    "• Hover over links before clicking\n" +
                    "• Watch for urgent/scare tactics\n" +
                    "• Never share credentials via email"),

                _ when input == "3" || input.Contains("browse") || input.Contains("internet") => FormatResponse(
                    "SAFE BROWSING PRACTICES",
                    "• Always check for HTTPS padlock\n" +
                    "• Avoid sensitive tasks on public WiFi\n" +
                    "• Keep browsers/plugins updated\n" +
                    "• Use ad-blockers (uBlock Origin)"),

                "help" => FormatResponse(
                    "COMMAND REFERENCE",
                    "1. Password security\n" +
                    "2. Phishing protection\n" +
                    "3. Safe browsing\n" +
                    "help - Show this menu\n" +
                    "exit - Close application"),

                _ when input.Contains("how are you") => "I'm functioning optimally, thank you for asking!",
                _ when input.Contains("purpose") => "My purpose is to educate users about cybersecurity best practices.",
                _ => FormatResponse("COMMAND NOT RECOGNIZED", "Type 'help' for available commands")
            };
        }

        private string FormatResponse(string title, string content)
        {
            return $"{title}\n{new string('═', title.Length)}\n{content}";
        }

        private void DisplayResponse(string response)
        {
            
            int consoleWidth = Console.WindowWidth > 10 ? Console.WindowWidth - 1 : 60;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            Console.WriteLine("\n" + new string('─', consoleWidth));

           
            string[] parts = response.Split('\n');
            string title = parts[0];
            string content = string.Join("\n", parts.Skip(1));

       
            Console.WriteLine(title);
            Console.WriteLine(new string('─', title.Length));
            Console.ResetColor();

            TypeWrite(content + "\n"); 

            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(new string('─', consoleWidth) + "\n");
            Console.ResetColor();
        }

        private void ShowGoodbye()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeWrite($"\nThank you, {UserName}! ");
            TypeWrite("Remember to practice good cyber hygiene.\n");
            Console.WriteLine(@"  _____                 _               _   _             ");
            Console.WriteLine(@" / ____|               | |             | | (_)            ");
            Console.WriteLine(@"| |  __  ___   ___   __| | ___  ___  __| |  _  ___  _ __  ");
            Console.WriteLine(@"| | |_ |/ _ \ / _ \ / _` |/ _ \/ _ \/ _` | | |/ _ \| '_ \ ");
            Console.WriteLine(@"| |__| | (_) | (_) | (_| |  __/  __/ (_| | | | (_) | | | |");
            Console.WriteLine(@" \_____|\___/ \___/ \__,_|\___|\___|\__,_| |_|\___/|_| |_|");
            Console.ResetColor();
        }

        private void TypeWrite(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(TypingDelay);
            }
        }

        private void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n! {message}");
            Console.ResetColor();
        }
    }
}