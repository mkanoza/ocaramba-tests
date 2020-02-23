using Ocaramba.Extensions;
using Ocaramba.Types;
using OpenQA.Selenium;
using System;

namespace Ocaramba.UITests3.PageObjects
{
    class HomePage : ProjectPageBase
    {
        private IWebDriver driver;
        private DriverContext driverContext;
        private TimeSpan waitTime;

        private readonly ElementLocator SignInButton = new ElementLocator(Locator.CssSelector, "a[class='login']");
        private readonly ElementLocator SearchTextfield = new ElementLocator(Locator.Id, "search_query_top");


        public HomePage(DriverContext driverContext)
            : base(driverContext)
        {
        }

        public void OpenHomePage()
        {
            var url = BaseConfiguration.GetUrlValue;
            this.Driver.NavigateTo(new Uri(url));
        }

        public AuthenticationPage ClickSignInButton(DriverContext driverContext)
        {
            this.Driver.GetElement(this.SignInButton, "Element not visible").Click();
            return new AuthenticationPage(driverContext);
        }

        public HomePage EnterSearchQuery(string searchQuery)
        {
            this.Driver.GetElement(this.SearchTextfield).SendKeys(searchQuery);
            return this;
        }
    }
}
