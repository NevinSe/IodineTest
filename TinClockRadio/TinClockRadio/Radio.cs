using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinClockRadio
{
    class Radio
    {
        //member variables (Has A)
        public string currentStation;
        public bool radioStatus;
        //constructor (Spawner)
        public Radio()
        {
            currentStation = "whatever";
            radioStatus = false;
        }
        //member methods(Can Do)
        public void TogglePower()
        {
            radioStatus = !radioStatus;
        }

        public void ChangeStation()
        {
            Console.WriteLine("Please enter a new radio station: ");
            currentStation = Console.ReadLine();
            DisplayStation();
        }

        public void DisplayStation()
        {
            Console.WriteLine("The current radio station is :" + currentStation);
    
        }
    }
}
