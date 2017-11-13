
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TGRTests
{
    public class ProjectHelper : HelperBase
    {
        private string baseURL;

        public ProjectHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void InitProjectCreation()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            driver.FindElement(By.CssSelector("#right-menu > a.btn.dropdown-toggle")).Click();//открыть меню "шестеренка"
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            driver.FindElement(By.XPath(".//*[@id='menuItemAdd']/a")).Click(); //кнопка "+ добавить"

            /*   IJavaScriptExecutor jsc = (IJavaScriptExecutor) driver;
               jsc.ExecuteScript("")*/        
    
        }

        public void FillProjectForm()
        {
            driver.FindElement(By.Id("Name")).Clear();
            driver.FindElement(By.Id("Name")).SendKeys("Проект для тестирования функционала"); //заполнение названия
            driver.FindElement(By.Id("ShortName")).Clear();
            driver.FindElement(By.Id("ShortName")).SendKeys("Тестовый проект");
            driver.FindElement(By.Id("StrategicDirectionId_chosen")).Click();
            driver.FindElement(By.XPath(".//*[@id='StrategicDirectionId_chosen']/a/span")).Click();
            //driver.FindElement(By.LinkText("Здравоохранение")).Click();


            //new SelectElement(driver.FindElement(By.));
            //new SelectElement(driver.FindElement(By.));




            //driver.FindElement(By.Id("Description")).Click();
            /*        driver.FindElement(By.Id("Description")).Clear();
                    driver.FindElement(By.Id("Description")).SendKeys("Тестовая сущность");
                    driver.FindElement(By.Id("Explanation")).Clear();
                    driver.FindElement(By.Id("Explanation")).SendKeys("Тестирование функционала");
                    driver.FindElement(By.Id("Prerequisite")).Clear();
                    driver.FindElement(By.Id("Prerequisite")).SendKeys("Тестирование функционала");
                    driver.FindElement(By.LinkText("Роли")).Click();
                    driver.FindElement(By.CssSelector("a.chosen-single.chosen-default > span")).Click();
                    driver.FindElement(By.CssSelector("a.chosen-single.chosen-default > span")).Click();
                    driver.FindElement(By.CssSelector("input.default")).Click();
                    driver.FindElement(By.CssSelector("#WorkGroup_chosen > ul.chosen-choices > li.search-field > input.default")).Click();
                    driver.FindElement(By.CssSelector("a.chosen-single.chosen-default > span")).Click();*/
        }

        public void SaveProject()
        {
            driver.FindElement(By.Id("saveButton")).Click(); //сохранение проекта
        }
    }
}
