using NUnit.Framework;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MorphicLiteAutomation.Objects
{
    internal class Contrast : SetUp
    {
        public void CheckHighContrastOn()
        {

            try
            {
                driver.FindElementByName("Turn On High Contrast").Click();
                Console.WriteLine("Clicks on High Contrast On button");

                // This is to check the value of SystemInformation.HighContrast 
                /*                Console.WriteLine(SystemInformation.HighContrast.ToString());*/

                Assert.AreEqual(SystemInformation.HighContrast.ToString(), "True");
                Thread.Sleep(3000);
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
                Thread.Sleep(3000);
                Assert.AreEqual(SystemInformation.HighContrast.ToString(), "False");
            }
            catch (IOException e)
            {
                Console.WriteLine($"The Off button on High Contrast was not found: '{e}'");
            }
        }
    }
}
