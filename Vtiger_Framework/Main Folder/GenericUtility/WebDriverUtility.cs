using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtiger_Framework.Main_Folder.GenericUtility
{/// <summary>
 /// This class is going to provide the Webdriver methods to the particular scripts.
 /// </summary>
    
    public class WebDriverUtility : BaseClass
    {
        /// <summary>
        /// This method is going to provide the implicit wait.
        /// </summary>
        /// <param name="driver"></param>
        [Owner("Datta")]
        public void WaitImplicitly(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);
        }
        /// <summary>
        /// This method is going to perfom the maximise of the browser window
        /// </summary>
        /// <param name="driver"></param>
        [Owner("Datta")]
        public void MaximiseWindow(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }
        /// <summary>
        /// This method is used to select the element present in the list box
        /// </summary>
        [Owner("Thejas")]
        public void ListBox_SelectByValue(IWebElement element, string value)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByValue(value);

        }
    }
}
