using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinClockRadio
{
    class Clock
    {
        //member variables (Has A)
        public string currentTime;
        public string alarmTime;
        public bool alarmStatus;

        //constructor (Spawner)
        public Clock(string CurrentTime, bool AlarmStatus, string staringAlarmTime)
        {
            currentTime = CurrentTime;
            alarmStatus = AlarmStatus;
            alarmTime = staringAlarmTime;
        }
        //member methods(Can Do)
        public void DisplayCurrrentTime()
        {
            Console.WriteLine("The current time is: " + currentTime);
  
        }
        public void SetTime()
        {
            Console.WriteLine("Please enter the current time: ");
            currentTime = Console.ReadLine();
            DisplayCurrrentTime();
        }
        public void GetAlarmTime()
        {
            Console.WriteLine("The current alarm time is: " + alarmTime);
     
        }
        public void SetAlarmTime()
        {
            Console.WriteLine("Please enter the new alarm time: ");
            alarmTime = Console.ReadLine();
            GetAlarmTime();
        }
        public void ToggleAlarm()
        {
            alarmStatus = !alarmStatus;
        }

    }
}
