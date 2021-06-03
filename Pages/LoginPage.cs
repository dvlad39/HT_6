using OpenQA.Selenium;
using HT_6.Framework.Models;
using OpenQA.Selenium.Support.UI;
using System;

namespace HT_6.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }


        //private IWebElement HrefHere => Driver.FindElement(By.XPath("//a[@href='http://testingchallenges.thetestingmap.org/login/login.php'] "));
        private IWebElement UsernameBox => Driver.FindElement(By.XPath("//input[@type = 'text']"));


        private IWebElement PasswordBox => Driver.FindElement(By.Name("password"));

        private IWebElement SubmitButton => Driver.FindElement(By.XPath("//button[@type= 'submit']"));

        public LoginPage EntryLoginData(User user)

        {
            //HrefHere.Click();
            //var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            //wait.Until(x => x.FindElement(By.Name("username")).Displayed);
            UsernameBox.Click();
            UsernameBox.SendKeys(user.Username);
            PasswordBox.Click();
            PasswordBox.SendKeys(user.Password);
            SubmitButton.Click();


            return new LoginPage(Driver);
        }
        private
    

    }
}
