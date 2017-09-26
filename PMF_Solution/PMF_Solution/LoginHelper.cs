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
    public class LoginHelper : HelperBase
    {
        public LoginHelper(IWebDriver driver) : base(driver)
        {
        }

        public void Logout()
        {
            driver.FindElement(By.LinkText("Выход")).Click();
        }

        public void Login(UserData user)
        {
            driver.FindElement(By.XPath("//a[@id='formLogin']/div/div")).Click();
            driver.FindElement(By.Id("UserName")).Clear();
            driver.FindElement(By.Id("UserName")).SendKeys("admin");
            driver.FindElement(By.Id("UserPassword")).Clear();
            driver.FindElement(By.Id("UserPassword")).SendKeys("123456");
            driver.FindElement(By.Id("PersistCookie")).Click();
            driver.FindElement(By.Id("Button1")).Click();
            driver.FindElement(By.Id("usernameinfo")).Click();
        }

    }
}
