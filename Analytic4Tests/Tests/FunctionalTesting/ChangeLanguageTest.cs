using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.Settings;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    [AllureNUnit]
    public class ChangeLanguageTest : BaseTest
    {
        [Test, Order(1)]
        [Description("01. Выполнить вход пользователя")]
        public void LogIn()
        {
            var authorisation = new AuthorisationPageObject(_webDriver);
            var dashboardIsDisplayed = new VerifyDashboardIsDisplayed(_webDriver);
            authorisation
                .Login(UsersForTests.StartLogin, UsersForTests.StartPass);

            dashboardIsDisplayed.verifyDashboardIsDisplayed();
        }

        [Test, Order(2)]
        [Description("02. Изменить язык")]
        public void ChangeLanguage()
        {
            var mainNavigator = new MainNavigatorPageObject(_webDriver);        
            mainNavigator
                .Obscure()
                .LogOut(LogOutForNavigatorTests.Language)
                .ChangeLanguage(ParametersForAuthorisationTests.English)
                .LogOut(LogOutForNavigatorTests.LanguageEnglish)
                .ChangeLanguage(ParametersForAuthorisationTests.Chinese)
                .LogOut(LogOutForNavigatorTests.LanguageChinise)
                .ChangeLanguage(ParametersForAuthorisationTests.Russian)
                //
                .LogOut(LogOutForNavigatorTests.Localisation)
                .ChangeLocalisation(LocalisationSettings.TurnOn)
                .LogOut(LogOutForNavigatorTests.Localisation)
                .ChangeLocalisation(LocalisationSettings.TurnOn);


            //mainNavigator.Obscure();

            //foreach (var language in new[]
            //    {LogOutForNavigatorTests.Language, LogOutForNavigatorTests.LanguageEnglish, LogOutForNavigatorTests.LanguageChinise})
            //{
            //    mainNavigator.LogOut(language);

            //    foreach (var lang in new[]
            //        {ParametersForAuthorisationTests.English, ParametersForAuthorisationTests.Chinese, ParametersForAuthorisationTests.Russian})
            //    {
            //        mainNavigator.ChangeLanguage(lang);
            //        mainNavigator.LogOut($"{language}{lang}");
            //    }
            //}
        }
    }
}
