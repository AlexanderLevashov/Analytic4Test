using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.Tests
{
    [TestFixture]
    public class AuthorisationBruteTest : BaseTest
    {
        private const int _nameSize = 5;
        private const int _sizePassword = 5;
        [Test]
        public void LogInBruteForce()
        {
            var authorisation = new AuthorisationPageObject(_webDriver);
            authorisation
                .LoginBruteForce(TestGenerateData.GenerateRandomUser(), TestGenerateData.GenerateRandomPassword(_sizePassword));
                        
            Assert.IsTrue(authorisation.SearchWarningElementLoginPass());
            //Assert.Throws<ElementNotVisibleException>(() => authorisation.SearchWarningElementLoginPass());
        }
    }
}
