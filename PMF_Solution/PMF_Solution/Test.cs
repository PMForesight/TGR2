using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TGRTests
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;

        protected LoginHelper loginhelper;
        //protected NavigationHelper navhelper;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://10.1.14.16/";
            verificationErrors = new StringBuilder();

            loginhelper = new LoginHelper(driver);
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTest()
        {
            OpenHomepage();
            loginhelper.Login(new UserData("admin", "123456"));
            loginhelper.Logout();
        }

        

        private void OpenHomepage()
        {
            driver.Navigate().GoToUrl(baseURL + "/asyst/authselect.html?ReturnUrl=%2fasyst%2fpage%2findex");
        }
        /* private bool IsElementPresent(By by)
{
    try
    {
        driver.FindElement(by);
        return true;
    }
    catch (NoSuchElementException)
    {
        return false;
    }
}*/
    }
}
