// NUnit 3 tests
// See documentation : https://github.com/ObjectivityLtd/Ocaramba 

using NUnit.Framework;
using Ocaramba.UITests3.DataDriven;
using Ocaramba.UITests3.PageObjects;
using OpenQA.Selenium;

namespace Ocaramba.UITests3
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class LoginTest : ProjectTestBase
    {
        private HomePage homePage;
        private AuthenticationPage authenticationPage;
        private MyAccountPage myAccountPage;
        private static readonly string expectedHeader = "MY ACCOUNT";

        [Test]
        public void LoginIntoAccount()
        {
            homePage = new HomePage(this.DriverContext);
            homePage.OpenHomePage();
            authenticationPage = homePage.ClickSignInButton(this.DriverContext);
            myAccountPage = authenticationPage
                .EnterEmailSignIn(UserData.currentAccountEmail)
                .EnterPasswordSignIn(UserData.currentAccountPassword)
                .ClickSignInButton(this.DriverContext);

            Assert.AreEqual(expectedHeader, myAccountPage.GetPageHeader());         
        }
    }
}
