
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TGRTests
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void Login(UserData user)
        {
            driver.FindElement(By.XPath("//a[@id='formLogin']")).Click();
            driver.FindElement(By.Id("UserName")).Clear();
            driver.FindElement(By.Id("UserName")).SendKeys(user.Username);
            driver.FindElement(By.Id("UserPassword")).Clear();
            driver.FindElement(By.Id("UserPassword")).SendKeys(user.Password);
            driver.FindElement(By.Id("PersistCookie")).Click();
            driver.FindElement(By.Id("Button1")).Click();
        }

        public void Logout()
        {
            /*var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("b.caret.mobile-collapse"))).Click();*/
             driver.FindElement(By.CssSelector("b.caret.mobile-collapse")).Click();

            //wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Выход"))).Click();
            driver.FindElement(By.LinkText("Выход")).Click();
        }
    }
}
