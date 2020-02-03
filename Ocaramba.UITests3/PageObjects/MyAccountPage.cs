using Ocaramba.Extensions;
using Ocaramba.Types;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Ocaramba.UITests3.PageObjects
{
    class MyAccountPage : ProjectPageBase
    {
        private IWebDriver driver;
        private DriverContext driverContext;

        private ElementLocator PageHeader = new ElementLocator(Locator.CssSelector, "h1[class='page-heading']");
        private IWebElement PageHeaderText => driver.FindElement(By.CssSelector("h1[class='page-heading']"));
        private ElementLocator AccountNameButton => new ElementLocator(Locator.CssSelector, "a[class='account'] span:first-child");
        private IWebElement SearchTextfield => driver.FindElement(By.Id("search_query_top"));
        private IWebElement SubmitSearchButton => driver.FindElement(By.CssSelector("button[name='submit_search']"));
        private IList<IWebElement> CategoryButtons => driver.FindElements(By.XPath("//ul[@class='sf-menu clearfix menu-content sf-js-enabled sf-arrows']/li/a"));


        public MyAccountPage(DriverContext driverContext)
            : base(driverContext)
        {
        }

        public string GetPageHeader()
        {
            return this.Driver.GetElement(this.PageHeader).Text;
        }

        public string GetAccountName()
        {
            return this.Driver.GetElement(this.AccountNameButton).Text;
        }

        public MyAccountPage EnterSearchQuery(string searchQuery)
        {
            SearchTextfield.SendKeys(searchQuery);
            return this;
        }
    }
}
