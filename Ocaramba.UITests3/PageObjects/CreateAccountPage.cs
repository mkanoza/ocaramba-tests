using Ocaramba.Extensions;
using Ocaramba.Types;
using Ocaramba.UITests3.DataDriven;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocaramba.UITests3.PageObjects
{
    class CreateAccountPage : ProjectPageBase
    {
        private IWebDriver driver;
        private DriverContext driverContext;

        //PERSONAL INFORMATION SECTION
        private readonly ElementLocator GenderMaleRadioButton = new ElementLocator(Locator.Id, "uniform-id_gender1");
        private readonly ElementLocator GenderFemaleRadioButton = new ElementLocator(Locator.Id, "uniform-id_gender2");
        private readonly ElementLocator FirstNameTextField = new ElementLocator(Locator.Id, "customer_firstname");
        private readonly ElementLocator LastNameTextField = new ElementLocator(Locator.Id, "customer_lastname");
        private readonly ElementLocator EmailTextField = new ElementLocator(Locator.CssSelector, "input[id='email']:not([value=''])");
        private readonly ElementLocator PasswordTextField = new ElementLocator(Locator.Id, "passwd");
        private IWebElement DayBirthDropdown => Driver.FindElement((By.Id("days")));
        private IWebElement MonthBirthDropdown => Driver.FindElement((By.Id("months")));
        private IWebElement YearBirthDropdown => Driver.FindElement((By.Id("years")));
        private readonly ElementLocator NewsletterCheckbox = new ElementLocator(Locator.Id, "uniform-newsletter");
        private readonly ElementLocator OffersCheckbox = new ElementLocator(Locator.Id, "uniform-optin");

        //ADDRESS SECTION
        private readonly ElementLocator FirstNameAddressTextField = new ElementLocator(Locator.Id, "firstname");
        private readonly ElementLocator LastNameAddressTextField = new ElementLocator(Locator.Id, "lastname");
        private readonly ElementLocator CompanyAddressTextField = new ElementLocator(Locator.Id, "company");
        private readonly ElementLocator FirstAddressLineAddressTextField = new ElementLocator(Locator.Id, "address1");
        private readonly ElementLocator SecondAddressLineAddressTextField = new ElementLocator(Locator.Id, "address2");
        private readonly ElementLocator CityAddressTextField = new ElementLocator(Locator.Id, "city");
        private readonly ElementLocator StateAddressDropdown = new ElementLocator(Locator.Id, "id_state");
        private IWebElement StateAddressDropdown1 => Driver.FindElement((By.Id("id_state")));
        private readonly ElementLocator ZipcodeAddressTextField = new ElementLocator(Locator.Id, "postcode");
        private readonly ElementLocator CountryAddressDropdown = new ElementLocator(Locator.Id, "id_country");
        private IWebElement CountryAddressDropdown1 => Driver.FindElement((By.Id("id_country")));
        private readonly ElementLocator OtherInfoAddressTextField = new ElementLocator(Locator.Id, "other");
        private readonly ElementLocator HomePhoneAddressTextField = new ElementLocator(Locator.Id, "phone");
        private readonly ElementLocator MobilePhoneAddressTextField = new ElementLocator(Locator.Id, "phone_mobile");
        private readonly ElementLocator AliasAddressTextField = new ElementLocator(Locator.Id, "alias");

        private readonly ElementLocator RegisterButton = new ElementLocator(Locator.Id, "submitAccount");

        public CreateAccountPage(DriverContext driverContext)
            : base(driverContext)
        {
        }

        public CreateAccountPage WaitForLoading()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            return this;
        }

        //PERSONAL INFORMATION SECTION
        public CreateAccountPage ClickMaleRadioButton()
        {
            this.Driver.GetElement(this.GenderMaleRadioButton).Click();
            return this;
        }

        public CreateAccountPage ClickFemaleRadiobutton()
        {
            this.Driver.GetElement(this.GenderFemaleRadioButton).Click();
            return this;
        }

        public CreateAccountPage EnterFirstName(string firstName)
        {
            this.Driver.GetElement(this.FirstNameTextField).SendKeys(firstName);
            return this;
        }

        public CreateAccountPage EnterLastName(string lastName)
        {
            this.Driver.GetElement(this.LastNameTextField).SendKeys(lastName);
            return this;
        }

        public CreateAccountPage EnterEmail(string email)
        {
            this.Driver.GetElement(this.EmailTextField).SendKeys(email);
            return this;
        }

        public string GetEmailValue()
        {
            return this.Driver.GetElement(this.EmailTextField).GetAttribute("value");
        }

        public CreateAccountPage EnterPassword(string password)
        {
            this.Driver.GetElement(this.PasswordTextField).SendKeys(password);
            return this;
        }

        public CreateAccountPage SelectDayOfBirth(string day)
        {
            SelectElement selectElement = new SelectElement(DayBirthDropdown);
            selectElement.SelectByText(day);
            return this;
        }

        public CreateAccountPage SelectDayOfBirth(int index)
        {
            SelectElement selectElement = new SelectElement(DayBirthDropdown);
            selectElement.SelectByIndex(index);
            return this;
        }

        public CreateAccountPage SelectMonthOfBirth(string month)
        {
            SelectElement selectElement = new SelectElement(MonthBirthDropdown);
            selectElement.SelectByText(month);
            return this;
        }

        public CreateAccountPage SelectMonthOfBirth(int index)
        {
            SelectElement selectElement = new SelectElement(MonthBirthDropdown);
            selectElement.SelectByIndex(index);
            return this;
        }

        public CreateAccountPage SelectYearOfBirth(string year)
        {
            SelectElement selectElement = new SelectElement(YearBirthDropdown);
            selectElement.SelectByText(year);
            return this;
        }

        public CreateAccountPage SelectYearOfBirth(int index)
        {
            SelectElement selectElement = new SelectElement(YearBirthDropdown);
            selectElement.SelectByIndex(index);
            return this;
        }

        public CreateAccountPage ClickNewsletterCheckbox()
        {
            this.Driver.GetElement(this.NewsletterCheckbox).Click();
            return this;
        }

        public CreateAccountPage ClickOffersCheckbox()
        {
            this.Driver.GetElement(this.OffersCheckbox).Click();
            return this;
        }

        //ADDRESS SECTION
        public CreateAccountPage EnterFirstNameAddress(string firstName)
        {
            this.Driver.GetElement(this.FirstNameAddressTextField).Clear();
            this.Driver.GetElement(this.FirstNameAddressTextField).SendKeys(firstName);
            return this;
        }

        public CreateAccountPage EnterLastNameAddress(string lastName)
        {
            this.Driver.GetElement(this.LastNameAddressTextField).Clear();
            this.Driver.GetElement(this.LastNameAddressTextField).SendKeys(lastName);
            return this;
        }

        public CreateAccountPage EnterCompanyAddress(string company)
        {
            this.Driver.GetElement(this.CompanyAddressTextField).SendKeys(company);
            return this;
        }

        public CreateAccountPage EnterAddressLine1Address(string address1)
        {
            this.Driver.GetElement(this.FirstAddressLineAddressTextField).SendKeys(address1);
            return this;
        }

        public CreateAccountPage EnterAddressLine2Address(string address2)
        {
            this.Driver.GetElement(this.SecondAddressLineAddressTextField).SendKeys(address2);
            return this;
        }

        public CreateAccountPage EnterCityAddress(string city)
        {
            this.Driver.GetElement(this.CityAddressTextField).SendKeys(city);
            return this;
        }

        public CreateAccountPage SelectStateAddress(string state)
        {
            SelectElement selectElement = new SelectElement(StateAddressDropdown1);
            selectElement.SelectByText(state);
            return this;
        }

        public CreateAccountPage SelectStateAddress(int index)
        {
            SelectElement selectElement = new SelectElement(StateAddressDropdown1);
            selectElement.SelectByIndex(index);
            return this;
        }

        public CreateAccountPage EnterZipcodeAddress(string zipcode)
        {
            this.Driver.GetElement(this.ZipcodeAddressTextField).SendKeys(zipcode);
            return this;
        }

        public CreateAccountPage SelectCountryAddress(string country)
        {
            this.Driver.GetElement(this.CountryAddressDropdown).GetCssValue(country);
            return this;
        }

        public CreateAccountPage SelectCountryAddress(int index)
        {
            SelectElement selectElement = new SelectElement(CountryAddressDropdown1);
            selectElement.SelectByIndex(index);
            return this;
        }

        public CreateAccountPage EnterAdditionalInfoAddress(string additionalInfo)
        {
            this.Driver.GetElement(this.OtherInfoAddressTextField).SendKeys(additionalInfo);
            return this;
        }

        public CreateAccountPage EnterHomePhoneAddress(string homePhone)
        {
            this.Driver.GetElement(this.HomePhoneAddressTextField).SendKeys(homePhone);
            return this;
        }

        public CreateAccountPage EnterMobilePhoneAddress(string mobilePhone)
        {
            this.Driver.GetElement(this.MobilePhoneAddressTextField).SendKeys(mobilePhone);
            return this;
        }

        public CreateAccountPage EnterAliasAddress(string alias)
        {
            this.Driver.GetElement(this.AliasAddressTextField).Clear();
            this.Driver.GetElement(this.AliasAddressTextField).SendKeys(alias);
            return this;
        }


        public MyAccountPage ClickRegisterButton(DriverContext driverContext)
        {
            this.Driver.GetElement(this.RegisterButton).Click();
            return new MyAccountPage(driverContext);
        }

        public CreateAccountPage OverwriteCredentials(bool overwrite)
        {
            if (overwrite)
            {
                UserData.currentAccountEmail = UserData.randomEmailAddress;
                UserData.currentAccountPassword = UserData.randomPassword;
            }
            return this;
        }
    }
}
