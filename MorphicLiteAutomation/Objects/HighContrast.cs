using System;
using System.IO;

namespace MorphicLiteAutomation.Objects
{
    class HighContrast : SetUp
    {

        public void CheckHighContrastOn()
        {
            try
            {
                driver.FindElementByName("Turn On High Contrast").Click();
                Console.WriteLine("Clicks on High Contrast On button");
            }
            catch (IOException e)
            {
                Console.WriteLine($"The On button on High Contrast was not found: '{e}'");
            }
        }
        public void CheckHighContrastOff()
        {
            try
            {
                driver.FindElementByName("Turn Off High Contrast").Click();
                Console.WriteLine("Clicks on High Contrasts Off button");
            }
            catch (IOException e)
            {
                Console.WriteLine($"The Off button on High Contrast was not found: '{e}'");
            }
        }
    }
}
