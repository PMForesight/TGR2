using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace TGRTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver, wait;
        protected string baseURL;

        protected LoginHelper loginhelper;
        protected NavigationHelper navhelper;
        protected ProjectHelper projecthelper;
        protected ControlHelper controlhelper;


        public ApplicationManager()
        {
            //driver = new ChromeDriver();
            driver = new FirefoxDriver();
            baseURL = "http://10.1.14.16";

            loginhelper = new LoginHelper(this);
            navhelper = new NavigationHelper(this, baseURL);
            projecthelper = new ProjectHelper(this);
            controlhelper = new ControlHelper(this);
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

        public ProjectHelper Proj
        {
            get
            {
                return projecthelper;
            }
        }
        public ControlHelper Contr
        {
            get
            {
                return controlhelper;
            }
        }

    }
}

