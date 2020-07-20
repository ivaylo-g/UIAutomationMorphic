using System;
using System.IO;

namespace MorphicLiteAutomation.Objects
{
    class TextSize : SetUp
    {
        public void TestIncreaseTextSize()
        {
            try
            {
                driver.FindElementByName("Increase Text Size").Click();
                Console.WriteLine("Clicks on the Plus button on Text Size");
            }
            catch (IOException e)
            {
                Console.WriteLine($"The plus button on Text Size was not found: '{e}'");
            }
        }
        public void TestDecreaseTextSize()
        {
            try
            {
                driver.FindElementByName("Decrease Text Size").Click();
                Console.WriteLine("Clicks on the Minus buttton on Text Size");
            }
            catch (IOException e)
            {
                Console.WriteLine($"The minus button on Text Size was not found: '{e}'");
            }
        }
    }
}
