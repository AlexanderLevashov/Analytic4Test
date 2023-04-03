using System;
using Analytic4Tests.BaseObjects;
using Analytic4Tests.JsonHandler;
using NUnit.Framework;

namespace Analytic4Tests.Tests.NonFunctionalTesting
{
    [TestFixture]
    public class AuthorisationTestJson : BaseTest
    {
        [Test]
        public void LogInLogined()
        {
            //Console.WriteLine(_environmentConstants.Login);

            EnvironmentConstantWriter environmentConstantWriter = new EnvironmentConstantWriter();
            environmentConstantWriter.WriteDown();
        }
    }
}
