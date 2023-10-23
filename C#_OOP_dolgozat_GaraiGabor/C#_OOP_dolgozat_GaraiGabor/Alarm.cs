using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace C__OOP_dolgozat_GaraiGabor
{
    internal class Alarm
    {
        private int alarmHour;
        private int alarmMinute;
        private bool isAlarmOn;

        public Alarm(int hour, int minute) { 
            this.alarmHour = hour;
            this.alarmMinute = minute;
        }

        void SetAlarm(int hour, int minute)
        {
            this.alarmHour = hour;
            this.alarmMinute = minute;
        }

        void TurnOnAlarm()
        {
            this.isAlarmOn = true;
        }
        void TurnOffAlarm()
        {
            this.isAlarmOn = false;
        }

        public bool IsAlarmTime(int hour, int minute)
        {
            if(hour == this.alarmHour && minute == this.alarmMinute)
                return true;
            else 
                return false;
        }

        public override string ToString()
        {
            if (this.alarmHour < 10 && this.alarmMinute > 10)
            {
                return $"Ébresztő ideje: 0{this.alarmHour}:{this.alarmMinute}";
            }
            else if (this.alarmHour > 10 && this.alarmMinute < 10)
            {
                return $"Ébresztő ideje: {this.alarmHour}:0{this.alarmMinute}";
            }
            else if(this.alarmHour <10 && this.alarmMinute < 10)
            {
                return $"Ébresztő ideje: 0{this.alarmHour}:0{this.alarmMinute}";
            }
            else { return $"Ébresztő ideje: {this.alarmHour}:{this.alarmMinute}"; }
        }

    }

    
}
