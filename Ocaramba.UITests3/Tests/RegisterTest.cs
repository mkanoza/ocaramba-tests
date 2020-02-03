using NUnit.Framework;
using Ocaramba.UITests3.DataDriven;
using Ocaramba.UITests3.PageObjects;

namespace Ocaramba.UITests3.Tests
{
    [TestFixture]
    class RegisterTest : ProjectTestBase
    {
        private HomePage homePage;
        private AuthenticationPage authenticationPage;
        private CreateAccountPage createAccountPage;
        private MyAccountPage myAccountPage;

        private static readonly string expectedHeader = "MY ACCOUNT";
        private static readonly string expectedAccountName = UserData.fistName + " " + UserData.lastName;


        [Test]
        public void CreateAccount()
        {
            homePage = new HomePage(this.DriverContext);
            homePage.OpenHomePage();
            authenticationPage = homePage.ClickSignInButton(this.DriverContext);
            authenticationPage.EnterEmailCreateAccount(UserData.randomEmailAddress);
            createAccountPage = authenticationPage.ClickCreateAccountButton(this.DriverContext);

            Assert.AreEqual(UserData.randomEmailAddress, createAccountPage.GetEmailValue());

            myAccountPage = createAccountPage
                .ClickMaleRadioButton()
                .EnterFirstName(UserData.fistName)
                .EnterLastName(UserData.lastName)
                .EnterPassword(UserData.randomPassword)
                .SelectDayOfBirth(4)
                .SelectMonthOfBirth(8)
                .SelectYearOfBirth(32)
                .ClickNewsletterCheckbox()
                .ClickOffersCheckbox()
                .EnterFirstNameAddress(UserData.fistName)
                .EnterLastNameAddress(UserData.lastName)
                .EnterCompanyAddress("Random company")
                .EnterAddressLine1Address("Random street")
                .EnterAddressLine2Address("21/37")
                .EnterCityAddress("Random Town")
                .SelectStateAddress(3)
                .EnterZipcodeAddress("00000")
                .SelectCountryAddress(1)
                .EnterAdditionalInfoAddress("Random additional information")
                .EnterHomePhoneAddress("123123123")
                .EnterMobilePhoneAddress("456456456")
                .EnterAliasAddress("Random address")
                .ClickRegisterButton(DriverContext);

            Assert.AreEqual(expectedHeader, myAccountPage.GetPageHeader());
            Assert.AreEqual(expectedAccountName, myAccountPage.GetAccountName());

            //Optional: if account was created successfuly user can override existing account credentials
            createAccountPage.OverwriteCredentials(true);
        }
    }
}
