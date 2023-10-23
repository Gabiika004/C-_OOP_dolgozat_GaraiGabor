using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace C__OOP_dolgozat_GaraiGabor
{
    internal class Timer
    {
        private int remainingSeconds;
        private System.Timers.Timer timer;

        public Timer(int seconds)
        {
            remainingSeconds = seconds;
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += TimerElapsed;
        }

        public void SetTime(int seconds)
        {
            remainingSeconds = seconds;
        }

        public void StartTimer()
        {
            Console.WriteLine("Időzítő elindítva.");
            timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (remainingSeconds > 0)
            {
                Console.WriteLine("Hátralévő idő: " + remainingSeconds + " másodperc");
                remainingSeconds--;
            }
            else
            {
                timer.Stop();
                Console.WriteLine("Időzítő lejárt.");
            }
        }

    }
}
