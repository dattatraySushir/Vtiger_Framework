using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtiger_Framework.Main_Folder.GenericUtility;

namespace Vtiger_Framework.Main_Folder.ObjectRepository.CampaignsRepo
{
    /// <summary>
    /// all the elements elements of vtiger home will be loaded here
    /// </summary>
    public class VTigerHomePage
    {

        [FindsBy(How = How.XPath, Using = "//img[@src='themes/softed/images/menuDnArrow.gif']")] private IWebElement moreDropDown { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@name='Campaigns']")] private IWebElement campaignLink { get; set; }

        public VTigerHomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void MoreDropDown()
        {
            WebDriverUtility webAction = new WebDriverUtility();
            // webAction.MouseHover(moreDropDown);
            moreDropDown.Click();

        }
        public void CampaignLink()
        {
            campaignLink.Click();
        }
    }
}
