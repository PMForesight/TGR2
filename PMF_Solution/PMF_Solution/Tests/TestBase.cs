using NUnit.Framework;

namespace TGRTests
{
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
            app.Nav.OpenHomepage();
            app.Auth.Login(new UserData("admin", "123456"));
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Auth.Logout();
            app.Stop();
        }
    }
}
