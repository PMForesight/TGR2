
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TGRTests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void OpenHomepage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        public void GoToObjects()
        {
            driver.FindElement(By.CssSelector("a.dcjq-parent > span")).Click();
        }

        public void GoToProjectRegister()
        {
            driver.FindElement(By.XPath(".//*[@id='nav-accordion']/li[1]/ul/li[5]/a")).Click();
        }
    }
}
