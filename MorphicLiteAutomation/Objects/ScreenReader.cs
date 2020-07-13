using System;
using System.IO;

namespace MorphicLiteAutomation.Objects
{
    class ScreenReader : SetUp
    {
        public void CheckScreenReaderShow()
        {
            try
            {
                driver.FindElementByName("Turn On Screen Reader").Click();
                Console.WriteLine("Clicks on the Screen Reader On button");
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
            }
            catch (IOException e)
            {
                Console.WriteLine($"The Off button on Screen Reader was not found: '{e}'");
            }
        }
    }
}
