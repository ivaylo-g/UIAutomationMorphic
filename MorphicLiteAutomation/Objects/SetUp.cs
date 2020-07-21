using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace MorphicLiteAutomation.Objects
{


    class SetUp
    {
        public const string appPath = @"C:\Program Files\Morphic\Morphic.exe";
        public const string url = "http://127.0.0.1:4723/";
        public static WindowsDriver<WindowsElement> driver;

        public void Initialize()
        {
            AppiumOptions desiredCapabilities = new AppiumOptions();
            desiredCapabilities.
                AddAdditionalCapability("app", appPath);
            desiredCapabilities.AddAdditionalCapability("platformName", "Windows");
            desiredCapabilities.AddAdditionalCapability("deviceName", "WindowsPC");
            driver = new WindowsDriver<WindowsElement>(new Uri(url), desiredCapabilities);
        }
    }
}
