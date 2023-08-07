using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
        ///<summary>
        ///this method is used to do the mouse hover actions on the web elements using actions class
        ///</summary>
        [Owner("Thejas")]
        public void MouseHover(IWebElement element)
        {
            Actions action=new Actions(driver);
            action.MoveToElement(element).Perform();
    }
    }
}
