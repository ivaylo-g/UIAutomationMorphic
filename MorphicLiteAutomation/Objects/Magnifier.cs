using System;
using System.IO;

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
            }
            catch (IOException e)
            {
                Console.WriteLine($"The hide button on Magnifier was not found: '{e}'");
            }
        }
    }
}
