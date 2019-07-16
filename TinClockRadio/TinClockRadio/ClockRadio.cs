using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinClockRadio
{
    class ClockRadio
    {
        //member variables (Has A)
        Clock clock;
        Radio radio;
        //constructor (Spawner)
        public ClockRadio()
        {
            clock = new Clock("1:00am", false, "5:00am");
            radio = new Radio();
        }
        //member methods(Can Do)
        public void DisplaySettings()
        {
            clock.DisplayCurrrentTime();
            clock.GetAlarmTime();
            radio.DisplayStation();
        }
        public void ChangeSettings()
        {
            clock.SetAlarmTime();
            clock.SetTime();
            radio.ChangeStation();
        }
        public void TogglePower()
        {
            clock.ToggleAlarm();
            radio.TogglePower();
        }
    }
}
