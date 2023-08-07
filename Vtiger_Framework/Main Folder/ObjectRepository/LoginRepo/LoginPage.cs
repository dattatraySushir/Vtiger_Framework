using Bytescout.Spreadsheet;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtiger_Framework.Main_Folder.GenericUtility;

namespace Vtiger_Framework.Main_Folder.ObjectRepository.LoginRepo
{
    /// <summary>
    /// This class is going to store all the web elements of the login page and provide the business logic for the login scenario.
    /// </summary>
    public class LoginPage
    {
        //decleration
        [FindsBy(How = How.Name, Using = "user_name")]
        private IWebElement username;
        [FindsBy(How =How.Name,Using = "user_password")]
       private IWebElement password;
        [FindsBy(How =How.Id,Using = "submitButton")]
        private IWebElement loginbutton;
        //initialisation
        public LoginPage(IWebDriver driver) {
            PageFactory.InitElements(driver, this);
        }
        //business library

        /// <summary>
        /// This mehtod is going to provide the login functionality to the test scripts.
        /// </summary>
        public void Login()
        {
            username.SendKeys(CommonData.username);
            password.SendKeys(CommonData.password);
            loginbutton.Click();
        }
        public void Login(string Un, string Pwd)
        {
            username.SendKeys(Un);
            password.SendKeys(Pwd);
            loginbutton.Click();
        }
    }
}
