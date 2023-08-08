using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Vtiger_Framework.Main_Folder.GenericUtility;

namespace Vtiger_Framework.Main_Folder.ObjectRepository.HomeRepo
{
    /// <summary>
    /// This class is going to provide the home page elements to the scripts.
    /// </summary>
    public class HomePage
    {
        //decleration
        [FindsBy(How = How.XPath, Using = "//table[@class='hdrTabBg']/tbody/tr/td/a")]
        private IWebElement homepage;
        [FindsBy(How =How.XPath,Using = "//a[text()='Calendar']")]
        private IWebElement calender;
        [FindsBy(How=How.XPath,Using = "//table[@class='hdrTabBg']/descendant::a[text()='Leads']")]
        private IWebElement leads;
        [FindsBy(How =How.XPath,Using = "//table[@class='hdrTabBg']/descendant::a[text()='Organizations']")]
        private IWebElement organisations;
        [FindsBy(How = How.XPath, Using = "//table[@class='hdrTabBg']/descendant::a[text()='Contacts']")]
        private IWebElement contacts;
        [FindsBy(How = How.XPath, Using = "//table[@class='hdrTabBg']/descendant::a[text()='Opportunities']")]
        private IWebElement opportunities;
        [FindsBy(How = How.XPath, Using = "//table[@class='hdrTabBg']/descendant::a[text()='Products']")]
        private IWebElement products;
        [FindsBy(How = How.XPath, Using = "//table[@class='hdrTabBg']/descendant::a[text()='Documents']")]
        private IWebElement documents;
        [FindsBy(How = How.XPath, Using = "//table[@class='hdrTabBg']/descendant::a[text()='Email']")]
        private IWebElement email;
        [FindsBy(How = How.XPath, Using = "//table[@class='hdrTabBg']/descendant::a[text()='Trouble Tickets']")]
        private IWebElement troubletickets;
        [FindsBy(How = How.XPath, Using = "//table[@class='hdrTabBg']/descendant::a[text()='Dashboard']")]
        private IWebElement dashboard;
        [FindsBy(How = How.XPath, Using = "//table[@class='hdrTabBg']/descendant::a[text()='More']")]
        public IWebElement more;
        [FindsBy(How =How.XPath,Using = "//span[text()=' Administrator']/parent::td/following-sibling::td/child::img[@src='themes/softed/images/user.PNG']")]
        public IWebElement administrator;
        [FindsBy(How =How.XPath,Using = "//a[text()='Sign Out']")]
        public IWebElement signout;

        //initialisation
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }
        //Business Library
        public void Logout()
        {
            WebDriverUtility webDriverUtility = new WebDriverUtility();
            //webDriverUtility.MouseHover(administrator);
            signout.Click();
        }
        public By getMore()
        {
            By locator = By.XPath("more");
            return locator;
        }
        public By getAdministrator()
        {
            By locator = By.XPath("//span[text()=' Administrator']/parent::td/following-sibling::td/child::img[@src='themes/softed/images/user.PNG']");
            return locator;
        }
        public void HomepageClick()
        {
            homepage.Click();
        }
        public void Calender()
        {
            calender.Click();
        }
        public void Leads()
        {
            leads.Click(); 
        }
        public void Organisations()
        {
            organisations.Click();
        }
        public void Contacts()
        {
            contacts.Click();
        }
        public void Oppourtunities()
        {
            opportunities.Click();
        }
        public void Products()
        {
            products.Click();
        }
        public void Documents()
        {
            documents.Click();
        }
        public void Email()
        {
            email.Click();
        }
        public void TroubleTickets()
        {
            troubletickets.Click();
        }
        public void DashBoard()
        {
            dashboard.Click();
        }
        
    }
}
