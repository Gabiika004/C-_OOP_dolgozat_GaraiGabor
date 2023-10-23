using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace C__OOP_dolgozat_GaraiGabor
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            //Feladat #1
            Clock myClock = new Clock(12, 30, 45, "UTC+2", true); 
            Clock myClock12 = new Clock(5, 20, 15, "UTC+2", false);

            //Feladat #2
            List<Alarm> alarms = new List<Alarm>();
            alarms.Add(new Alarm(6,0));
            alarms.Add(new Alarm(8,0));

            //Feladat #3
            Timer timer1 = new Timer(10);

            //Feladat #4
            Console.WriteLine("Teszt #1");
            Console.WriteLine();
            myClock.DisplayTime();
            myClock12.DisplayTime();

            //További tesztek

            //Feladat #5

            Console.WriteLine("Teszt #2");
            Console.WriteLine();
            for (int i = 0; i < alarms.Count; i++)
            {
                if (alarms[i].IsAlarmTime(myClock.Hour, myClock.Minute) == true)
                {
                    Console.WriteLine(alarms[i]);
                    Console.WriteLine("Az ébresztő megszólalt!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(alarms[i]);
                    Console.WriteLine("Az ébresztő nem szólalt meg!");
                }
            }

            Console.WriteLine();

            //---------------------------------------

            DateTime currentDate = DateTime.Now;
            Clock now = new Clock(currentDate.Hour, currentDate.Minute, currentDate.Second, "UTC + 2",true);
            alarms.Add(new Alarm(now.Hour,now.Minute));

            Console.WriteLine("Teszt #3");
            Console.WriteLine();
            now.DisplayTime();

            foreach (Alarm alarm in alarms.Where(x => x.IsAlarmTime(now.Hour, now.Minute) == true))
            {
                Console.WriteLine(alarm);
                Console.WriteLine("Az ébresztő megszólalt!");
                Console.WriteLine();
            }

            //---------------------------------------
            Console.WriteLine();
            Console.WriteLine("Teszt #4");
            Console.WriteLine();

            myClock = new Clock(6, 00, 00, "UTC+2", true);
            myClock.DisplayTime();
            foreach (Alarm alarm in alarms.Where(x => x.IsAlarmTime(myClock.Hour, myClock.Minute) == true))
            {
                Console.WriteLine(alarm);
                Console.WriteLine("Az ébresztő megszólalt!");
                Console.WriteLine();
            }
            Console.WriteLine();
            //---------------------------------------

            //Feladat #6

            Console.WriteLine("Teszt #5");
            Clock newClock = new Clock(now.Hour, now.Minute, now.Second, "UTC+2", false);
            string time = Convert.ToString(newClock.Hour) + ":" +  Convert.ToString(newClock.Minute+1) + ":" + Convert.ToString(newClock.Second);
            // Későbbi időpont

            alarms.Add(new Alarm(now.Hour, now.Minute+1));

            Console.WriteLine(alarms[alarms.Count-1]);


            DateTime startTime = DateTime.Now;
            DateTime endTime = Convert.ToDateTime(time);

            TimeSpan elapsed = endTime - startTime;
            int elapsedSeconds = (int)elapsed.TotalSeconds;

            int seconds = elapsedSeconds;
            Timer myTimer = new Timer(seconds);

            myTimer.StartTimer();

            //Feladat #7 
            //Tesztelés

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
