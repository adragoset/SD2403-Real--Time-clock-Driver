using System;
using Gadgeteer.Modules.DFRobot;
using Microsoft.SPOT;


namespace TestApp
{
    public partial class Program
    {
        // This method is run when the mainboard is powered up or reset.   
        void ProgramStarted()
        {
            /*******************************************************************************************
            Modules added in the Program.gadgeteer designer view are used by typing 
            their name followed by a period, e.g.  button.  or  camera.
            
            Many modules generate useful events. Type +=<tab><tab> to add a handler to an event, e.g.:
                button.ButtonPressed +=<tab><tab>
            
            If you want to do something periodically, use a GT.Timer and handle its Tick event, e.g.:
                GT.Timer timer = new GT.Timer(1000); // every second (1000ms)
                timer.Tick +=<tab><tab>
                timer.Start();
            *******************************************************************************************/


            // Use Debug.Print to show messages in Visual Studio's "Output" window during debugging.
            Debug.Print("Program Started");

            SD2405_Real_Time_Clock rtc = new SD2405_Real_Time_Clock(3);

            DateTime test = rtc.GetDateTime();
            
            Debug.Print(test.ToString());

            test = new DateTime(2013, 3, 26, 2, 0, 0);

            Debug.Print(test.ToString());

            rtc.SetDateTime(test);

            test = rtc.GetDateTime();

            Debug.Print(test.ToString());

        }
    }
}
