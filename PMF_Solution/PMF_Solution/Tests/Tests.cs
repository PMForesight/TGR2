
using NUnit.Framework;
using OpenQA.Selenium;

namespace TGRTests
{
    [TestFixture]
    public class Tests : TestBase
    {               
        [Test]
        public void Login()
        {
            
        }

        [Test]
        public void SimpleProjectCreation()
        {
            app.Nav.GoToObjects();
            app.Nav.GoToProjectRegister();
            //app.Contr.WaitHideElement(By.ClassName(""));
            app.Proj.InitProjectCreation();
            app.Proj.FillProjectForm();
           // app.Proj.SaveProject();
        }
    }
}
