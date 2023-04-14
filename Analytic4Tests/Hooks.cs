using Allure.Commons;
using Analytic4Tests.BaseObjects;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Analytic4Tests
{
    [Binding]
    public class Hooks : BaseTest
    {
        public static new AllureLifecycle allure = AllureLifecycle.Instance;
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //allure.CleanupResultDirectory();
        }
    }
}
