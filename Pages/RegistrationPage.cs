using OpenQA.Selenium;
using HT_6.Framework.Models;

namespace HT_6.Pages
{
    public class RegistrationPage : BasePage
    {

        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement UsernameBox => Driver.FindElement(By.CssSelector("input[name = 'username']"));

        private IWebElement PasswordBox => Driver.FindElement(By.CssSelector("input[name = 'password']"));

        private IWebElement FirstNameBox => Driver.FindElement(By.CssSelector("input[name = 'firstname']"));

        private IWebElement LastNameBox => Driver.FindElement(By.CssSelector("input[name = 'lastname']"));
        private IWebElement SubmitButton => Driver.FindElement(By.XPath("//input[@value = 'Submit']"));

        public TablePage EntryRegistrationData(User user)
        {
            UsernameBox.Click();
            UsernameBox.SendKeys(user.Username);
            PasswordBox.Click();
            PasswordBox.SendKeys(user.Password);
            FirstNameBox.Click();
            FirstNameBox.SendKeys(user.FirstName);
            LastNameBox.Click();
            LastNameBox.SendKeys(user.LastName);
            SubmitButton.Click();

            return new TablePage(Driver);
        }

    }
}