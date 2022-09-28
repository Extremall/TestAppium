using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Appium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium;

namespace MyTests
{
    [TestFixture()]
    public class iOSTests
    {
        private IOSDriver<IOSElement> driver;

        public iOSTests()
        {
        }

        [SetUp]
        public void BeforeEachTest()
        {
            string filePath = "path to your ipa";

            AppiumOptions options = new AppiumOptions();
            options.PlatformName = "iOS";
            options.AddAdditionalCapability("platformVersion", "14.5");
            options.AddAdditionalCapability("deviceName", "iPhone 11");
            options.AddAdditionalCapability("automationName", "XCUITest");
            //options.AddAdditionalCapability("bundleId", "your bundleID when you don't use IPA file");
            options.AddAdditionalCapability("app", filePath);
            Uri url = new Uri("http://127.0.0.1:4723/wd/hub");

            driver = new IOSDriver<IOSElement>(url, options, TimeSpan.FromSeconds(30));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [Test]
        public void AppLaunches()
        {
        }
    }
}
