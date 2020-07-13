using System;
using System.IO;

namespace MorphicLiteAutomation.Objects
{
    class Volume : SetUp
    {
        public void CheckTurntheVolumeUp()
        {
            try
            {
                driver.FindElementByName("Turn the Volume Up").Click();
                Console.WriteLine("Clicks on Volume plus button");
            }
            catch (IOException e)
            {
                Console.WriteLine($"The plus button on Volume was not found: '{e}'");
            }
        }
        public void CheckTurntheVolumeDown()
        {
            try
            {
                driver.FindElementByName("Turn the Volume Down").Click();
                Console.WriteLine("Clicks on the Volume minus button");
            }
            catch (IOException e)
            {
                Console.WriteLine($"The minus button on Volume was not found: '{e}'");
            }
        }

        public void CheckMuteAllSounds()
        {
            try
            {
                driver.FindElementByName("Mute All Sounds").Click();
                Console.WriteLine("Clicks on the Volume mute button");
            }
            catch (IOException e)
            {
                Console.WriteLine($"The mute button on Volume was not found: '{e}'");
            }
        }
    }
}
