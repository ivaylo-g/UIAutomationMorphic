using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace MorphicLiteAutomation.Objects
{
    class ScreenReader : SetUp
    {


        public void CheckScreenReaderShow()
        {
            try
            {
                driver.FindElementByName("Turn On Screen Reader").Click();
                Thread.Sleep(5000);

                Console.WriteLine("Clicks on the Screen Reader On button");

                Process[] CheckNarratorPersists = Process.GetProcessesByName("Narrator");
                if (CheckNarratorPersists.Length > 0)
                {
                    Console.WriteLine("Narrator process is running");
                }
                else
                {
                    throw new IOException("Narrator process is not running");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"The On button on Screen Reader was not found: '{e}'");
            }
        }
        public void CheckScreenReaderHide()
        {
            try
            {
                driver.FindElementByName("Turn Off Screen Reader").Click();
                Console.WriteLine("Clicks on the Screen Reader Off Button");
                Thread.Sleep(10000);

                Process[] CheckNarratorIsMissing = Process.GetProcessesByName("Narrator");
                if (CheckNarratorIsMissing.Length == 0)
                {
                    Console.WriteLine("Narrator process is stopped");
                }
                else
                {
                    throw new IOException("Narrator process is running");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"The Off button on Screen Reader was not found: '{e}'");
            }
        }
    }
}
