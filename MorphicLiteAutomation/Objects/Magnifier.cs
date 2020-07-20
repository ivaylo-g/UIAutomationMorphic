using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace MorphicLiteAutomation.Objects
{
    class Magnifier : SetUp
    {

        public void CheckMagnifierShow()
        {
            try
            {
                driver.FindElementByName("Show a Magnifying Glass").Click();
                Console.WriteLine("Clicks on Show button on Magnifying Glass");
                Thread.Sleep(3000);

                //This is to view what it is the process name of Mangifier
/*                Process[] localAll = Process.GetProcesses();*/

                Process[] pname = Process.GetProcessesByName("Magnify");
                if (pname.Length > 0)
                {
                    Console.WriteLine("Magnifier process is running");
                }
                else
                {
                    throw new IOException(" Magnifier process is not running");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"The show button on Magnifier was not found: '{e}'");
            }
        }
        public void CheckMagnifierHide()
        {
            try
            {
                driver.FindElementByName("Hide the Magnifying Glass").Click();
                Console.WriteLine("Clicks on Hide button on Magnifying Glass");

                Thread.Sleep(3000);


                Process[] pname = Process.GetProcessesByName("Magnify");
                if (pname.Length == 0)
                {
                    Console.WriteLine("Magnifier process is not running");
                }
                else
                {
                    throw new IOException("Magnifier process is running after the button for stopping has been pressed");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"The hide button on Magnifier was not found: '{e}'");
            }
        }
    }
}
