
using OpenQA.Selenium;


namespace HT_6.Pages
{
    public class TablePage : BasePage
    {
        public TablePage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement Table => Driver.FindElement(By.XPath("//*[@style = 'width:100%']//child::tr//th"));
        

        public string GetTable()
        {
            return Table.Text;
        }

    }
}