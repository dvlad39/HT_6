using OpenQA.Selenium;

namespace HT_6.Pages
{
    public class BasePage
    {
        public IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }
    }
}