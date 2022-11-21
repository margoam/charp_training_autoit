using System;

namespace addressbook_autoit
{
    public class TestBase
    {
        public ApplicationManager app;
        [OneTimeSetUp]
        public void InitApplication()
        {
            app = new ApplicationManager();
        }

        [OneTimeTearDown]
        public void StopApplication()
        {
            app.Stop();
        }
    }
}

