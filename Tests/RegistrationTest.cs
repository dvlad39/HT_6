using HT_6.Framework;
using HT_6.Framework.Models;
using HT_6.Pages;
using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System;




namespace HT_6.Tests
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        private User firstUser;
        


        [SetUp]

        protected void Initialize()
        {
            firstUser = User.User1();
          

        }



        [Test]
        public void RegistrationTestForUser1()
        {

            TablePage tablePage = SiteNavigator.NavigateToTablePage(Driver).EntryRegistrationData(firstUser);

            IWebElement elemTable = Driver.FindElement(By.XPath("//*[@style = 'width:100%']//tbody"));
            List<IWebElement> lstTdElem = new List<IWebElement>(elemTable.FindElements(By.TagName("th")));

            string strRowData = "";

            string[] TableCotainsUser1 = { User.User1().Username, User.User1().Password, User.User1().FirstName, User.User1().LastName };
            if (lstTdElem.Count > 0)
            {
                foreach (var elemTd in lstTdElem)
                {
                    
                    strRowData = strRowData + elemTd.Text + "\t\t";

                }
            }

            foreach (string el in TableCotainsUser1)
            {

                Assert.That(strRowData.Contains(el));
            }


            LoginPage loginPage1 = SiteNavigator.NavigateToLoginPage(Driver).EntryLoginData(firstUser); //не работает
            {

            }
            
        }
    }
}
        
                
            
            

     



