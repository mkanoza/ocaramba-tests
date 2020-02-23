using Ocaramba.Extensions;
using Ocaramba.Types;
using OpenQA.Selenium;
using System;

namespace Ocaramba.UITests3.PageObjects
{
    class AuthenticationPage : ProjectPageBase
    {
        private IWebDriver driver;
        private static object driverContext;

        private readonly ElementLocator CreateAccountEmailTextfield = new ElementLocator(Locator.Id, "email_create");
        private readonly ElementLocator CreateAccountButton = new ElementLocator(Locator.Id, "SubmitCreate");
        private readonly ElementLocator SignInEmailTextfield = new ElementLocator(Locator.Id, "email");
        private readonly ElementLocator SignInPasswordTextfield = new ElementLocator(Locator.Id, "passwd");
        private readonly ElementLocator SignInButton = new ElementLocator(Locator.Id, "SubmitLogin");

        public AuthenticationPage(DriverContext driverContext)
            : base(driverContext)
        {
        }

        public AuthenticationPage EnterEmailCreateAccount(string email)
        {
            this.Driver.GetElement(this.CreateAccountEmailTextfield).SendKeys(email);
            return this;
        }

        public CreateAccountPage ClickCreateAccountButton(DriverContext driverContext)
        {
            this.Driver.GetElement(this.CreateAccountButton).Click();
            return new CreateAccountPage(driverContext);
        }

        public AuthenticationPage EnterEmailSignIn(string email)
        {
            this.Driver.GetElement(this.SignInEmailTextfield).SendKeys(email);
            return this;
        }

        public AuthenticationPage EnterPasswordSignIn(string password)
        {
            this.Driver.GetElement(this.SignInPasswordTextfield).SendKeys(password);
            return this;
        }

        public MyAccountPage ClickSignInButton(DriverContext driverContext)
        {
            this.Driver.GetElement(this.SignInButton).Click();
            return new MyAccountPage(driverContext);
        }
    }
}
