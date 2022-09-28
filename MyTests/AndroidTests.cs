using System;

using NUnit.Framework;
using Appium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium;

namespace MyTests
{
    [TestFixture()]
    public class AndroidTests
    {
        private AndroidDriver<AndroidElement> driver;

        public AndroidTests()
        {
        }

        [SetUp]
        public void BeforeEachTest()
        {
            string filePath = "path to your apk";

            AppiumOptions options = new AppiumOptions();
            options.PlatformName = "Android";
            options.AddAdditionalCapability("deviceName", "Pixel_5_API_30");
            options.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "11.0");
            options.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
            options.AddAdditionalCapability(MobileCapabilityType.App, filePath);

            Uri url = new Uri("http://127.0.0.1:4723/wd/hub");

            driver = new AndroidDriver<AndroidElement>(url, options, TimeSpan.FromSeconds(30));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [Test]
        public void FirstLaunch()
        {
            Console.WriteLine("Your test code is here");
            Assert.IsTrue(true);
        }
    }
}
