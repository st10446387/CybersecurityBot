using System;
using System.Runtime.InteropServices;

namespace CybersecurityBot
{
    public static class AudioService
    {
        [DllImport("winmm.dll")]
        private static extern bool PlaySound(string sound, IntPtr hmod, int flags);

        public static void PlayWelcome()
        {
            try
            {
                PlaySound("welcome.wav", IntPtr.Zero, 0x0001); // SND_ASYNC
            }
            catch (Exception)
            {
                Console.WriteLine("Audio playback failed");
            }
        }
    }
}