
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TGRTests
{
    public class ControlHelper : HelperBase
    {
        public ControlHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void WaitHideElement(By iClassName)
        {
            WebDriverWait iWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            iWait.Until(ExpectedConditions.InvisibilityOfElementLocated(iClassName));

            /*var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("b.caret.mobile-collapse"))).Click();*/
            // iClassName: By.Id("id"), By.CssSelector("selector") и т.д.
            //loader-indicator
        }

        public void WaitShowElement(By iClassName)
        {
            WebDriverWait iWait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            iWait.Until(ExpectedConditions.ElementIsVisible(iClassName));
        }
    }
}
