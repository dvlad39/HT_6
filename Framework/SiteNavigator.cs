using System.Configuration;
using HT_6.Pages;
using OpenQA.Selenium;

namespace HT_6.Framework
{
    public class SiteNavigator
    {
        public static RegistrationPage NavigateToTablePage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://testingchallenges.thetestingmap.org/challenge10.php");
            return new RegistrationPage(driver);

        }
        public static LoginPage NavigateToLoginPage(IWebDriver driver)
        {
          // driver.FindElement(By.XPath("//a[@href='http://testingchallenges.thetestingmap.org/login/login.php'] ")).Click();
            driver.Navigate().GoToUrl("http://testingchallenges.thetestingmap.org/login/login.php"); 
            return new LoginPage(driver);
        }
    }
}