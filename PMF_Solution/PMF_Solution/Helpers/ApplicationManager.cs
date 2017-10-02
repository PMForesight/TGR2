using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TGRTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected LoginHelper loginhelper;
        protected NavigationHelper navhelper;


        public ApplicationManager()
        {
            driver = new ChromeDriver();
            baseURL = "http://10.1.14.16";

            loginhelper = new LoginHelper(this);
            navhelper = new NavigationHelper(this, baseURL);
        }

        public void Stop() //остановка всего внутри ApplicationManager
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginhelper;
            }
        }

        public NavigationHelper Nav
        {
            get
            {
                return navhelper;
            }
        }

    }
}

