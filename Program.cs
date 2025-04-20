using CybersecurityBot;
using System;

namespace CybersecurityBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Voice greeting
            AudioService.PlayWelcome();

            Thread.Sleep(2000);

            // Start chat session
            new ChatManager().StartChat();
        }
    }
}

