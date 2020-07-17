using System;
using System.IO;
using System.Threading;

namespace MorphicLiteAutomation.Objects
{
    class LogoButton : SetUp
    {
        public void CheckLogoButton()
        {
            try
            {
                driver.FindElementByName("Main Menu").Click();
                Console.WriteLine("Clicks on Morphic Logo button");

            }
            catch (IOException e)
            {
                Console.WriteLine($"The Main Menu button was not found: '{e}'");
            }
            Thread.Sleep(1000);

/*            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);*/
        }
    }
}
