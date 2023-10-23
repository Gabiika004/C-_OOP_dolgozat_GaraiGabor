using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace C__OOP_dolgozat_GaraiGabor
{
    internal class Clock
    {
        private int hour;
        private int minute;
        private int second;
        private string timeZone;
        private bool is24HourFormat;


        public int Hour { get => hour; set => hour = value; }
        public int Minute { get => minute; set => minute = value; }
        public int Second { get => second; set => second = value; }
        public string TimeZone { get => timeZone; set => timeZone = value; }
        public bool Is24HourFormat {  get => is24HourFormat; set => is24HourFormat = value; }

        
        public Clock(int hour, int minute, int second, string timeZone, bool is24HourFormat)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.timeZone = timeZone;
            this.is24HourFormat = is24HourFormat;
        }

        public void SetTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void DisplayTime()
        {
            if (is24HourFormat) {
                Console.WriteLine($"Az aktuális idő (24 órás formátum):\n" +
                    $"{this.Hour}:{this.Minute}:{this.second} - {this.timeZone}"
                    );
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine($"Az aktuális idő (12 órás formátum):\n" +
                    $"{this.hour}:{this.minute}:{this.second} - {this.timeZone}"
                    );
                Console.WriteLine();
            }
        }

        public void SetTimeZone(string timeZone)
        {
            this.timeZone = timeZone;
        }

        void ToggleTimeFormat()
        {
            if (is24HourFormat)
                this.is24HourFormat = false;
            else  
                this.is24HourFormat = true;
        }


    }
}
