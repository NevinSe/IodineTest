using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinClockRadio
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] thing = new string[5];

            ClockRadio myClockRadio = new ClockRadio();
            myClockRadio.DisplaySettings();
            myClockRadio.ChangeSettings();
            myClockRadio.DisplaySettings();
        }
    }
}
